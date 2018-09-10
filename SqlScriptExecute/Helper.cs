using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data;
using ClosedXML.Excel;
using System.Diagnostics;


//https://www.wolfsys.net/exec-tsql-scripts-containing-go-statements-with-csharp/
//Need to goto Nuget Console (Tools, Nuget, Nuget Console)
//Install-Package Microsoft.SqlServer.Scripting

namespace SQLScriptExecute
{
    public class Helper
    {
        BackgroundWorker backgroundWorker1;
        DataTable excelDataTable = new DataTable();
       
        
        OptionData od = OptionData.Instance;

        //Constructor
        public Helper()
        {
            //Setup DataTable for Excel
            excelDataTable.Clear();
            excelDataTable.Columns.Add("Server");
            excelDataTable.Columns.Add("File");
            excelDataTable.Columns.Add("SuccessOrError");
            excelDataTable.Columns.Add("Date");
            excelDataTable.Columns.Add("Message");

            // Create background worker thread
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }


        /*-----------------------------------------------------
        Validates values of Option class
        -----------------------------------------------------*/
        public string ValidateValues(bool runtime)
        {
            string s = "";
            //Missing Server
            if (string.IsNullOrWhiteSpace(od.SelectedServer))
            {
                s += "Missing Server Name" + System.Environment.NewLine;
            }

            //Missing UserName or Password
            if (od.WindowsAuthentication == false)
            {
                if (string.IsNullOrWhiteSpace(od.UserName) || string.IsNullOrWhiteSpace(od.Password))
                {
                    s += "UserName and Password are required when NOT using Windows Authentication" + System.Environment.NewLine;
                }
            }

            //Only test at runtime
            if (runtime == true)
            {
                if (od.ProcessErrorFiles==true)
                {
                    //Invalid Error file.
                    IEnumerable<string> validItems = Enumerable.Empty<string>();
                    string t = "";
                    try
                    {
                        var tempList = File.ReadAllLines(od.ScriptsToExecutePath);
                        t = tempList.First();

                        if (t.Substring(0, 20) != "HEADER----StartTime:")
                        {
                            s += "Invalid Error File - Header is Invalid" + System.Environment.NewLine;
                        }
                    }
                    catch //(Exception ex)
                    {
                        s += "Invalid Error File" + System.Environment.NewLine;
                    }
                }
                
                //Missing Script Path
                if (string.IsNullOrWhiteSpace(od.ScriptsToExecutePath))
                {
                    s += "Missing Scripts To Execute Path" + System.Environment.NewLine;
                }

                //Missing Log Path
                if (string.IsNullOrWhiteSpace(od.LogPath))
                {
                    s += "Missing Log Path" + System.Environment.NewLine;
                }
            }
                        
            return s;
        }


        /*-----------------------------------------------------
        Test If Conncection to SQL Server Is Valid
        -----------------------------------------------------*/
        public string TestServerConnection(string cs)
        {
            string validateInput = ValidateValues(false);
            if (!string.IsNullOrWhiteSpace(validateInput))
            {
                return validateInput;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    try
                    {
                        connection.Open();                        
                        return "";              //Successful
                    }
                    catch (SqlException ex)
                    {
                        return ex.Message;      //Failed
                    }
                }
            }
            
        }


        /*-----------------------------------------------------
        Run Scripts
        -----------------------------------------------------*/
        public void ExecuteScripts()
        {
            string errorMessage = "";
            ResetRuntimeStats();
            od.TextBoxStatusLog = "";
            excelDataTable.Clear();

            //Don't run if not valid
            this.AppendTextBoxStatusWithTimeStamp("Validating Options.....");            
            errorMessage = this.ValidateValues(true);
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                this.AppendTextBoxStatus("Failed\r\n" + errorMessage);
                return;
            }
            this.AppendTextBoxStatus("Passed\r\n");

            //Check Connection String
            this.AppendTextBoxStatusWithTimeStamp("Checking Connection String.....");
            if (string.IsNullOrWhiteSpace(od.ConnectionString))
            {
                this.AppendTextBoxStatus("Failed\r\n");
                return;
            }
            this.AppendTextBoxStatus("Passed\r\n");

            //Check server connection
            this.AppendTextBoxStatusWithTimeStamp("Checking Server Connection.....");            
            if (!string.IsNullOrWhiteSpace(this.TestServerConnection(od.ConnectionString)))
            {
                this.AppendTextBoxStatus("Failed\r\n");
                return;
            }
            this.AppendTextBoxStatus("Passed\r\n");

            //Check to make sure scripts exist in selected file location
            this.AppendTextBoxStatusWithTimeStamp("Checking Path For SQL Script File Count.....");
            if (od.FileTotalCount <= 0)
            {
                this.AppendTextBoxStatus("Failed\r\n" + "There are 0 sql scripts found\r\n");
                return;
            }
            this.AppendTextBoxStatus("Passed\r\n");

            //Check background worker
            if (backgroundWorker1.IsBusy != true)
            {
                od.BuildLogFileName();  //Builds filename based on Root Scripts to Execute Path and timestamp
                this.AppendTextBoxStatusWithTimeStamp("Starting Worker Thread.....\r\n");
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                this.AppendTextBoxStatusWithTimeStamp("ERROR: Could Not Start Worker Thread.....\r\n");
                return;
            }
            //All good...
            od.ErrorListFileNames.Clear();
            od.CancelButtonEnabled = true;
            od.RunButtonEnabled = false;            
        }


        /*-----------------------------------------------------
        Reset Run Status
        -----------------------------------------------------*/
        private void ResetRuntimeStats()
        {
            //Reset Stats
            od.FileSuccessfullUpdateCount = 0;
            od.FilesErrorCount = 0;
            od.ProgressBarValue = 0;
        }


        /*-----------------------------------------------------
        BackgroundWorker DoWork - Main Thread
        -----------------------------------------------------*/
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            od.WorkerIsBusy = true;
            DateTime startTime = DateTime.Now;
            
            string fileFilter = "*.sql";
            string sqlScriptFile;
            string scriptsPath = "";
            string serverConnection = "";
            int scriptsUpdated = 0;
            int errorCount = 0;
            int currentCount = 0;
            int consecutiveErrorCount = 0;
            string exceptionMessage = "";
            string status = "";

            //LogFile - Append timestamp to FileName
            od.LogFileName += "_" + startTime.ToString("yyyyMMddHHmmss"); 
            StringBuilder errorMessages = new StringBuilder();

            //Search Option
            SearchOption option = od.IncludeSubFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            //Set vals from data class
            serverConnection = od.SelectedServer;
            scriptsPath = od.ScriptsToExecutePath;
            string sqlConnectionString = od.ConnectionString;                    

            //TODO: add max progress to class (currently hardcoded to 100)
            int step = 100 / od.FileTotalCount;
            //int step = circularProgressBar1.Maximum / totalScriptCount;
            
            //LogFile StreamWriter
            using (StreamWriter w = File.CreateText(od.LogPath + @"\" + od.LogFileName + @".log"))
            {
                //Log Header
                Log(GetLogHeader(), w, false);

                using (SqlConnection connection = new SqlConnection(sqlConnectionString))
                {
                    Server server = new Server(new ServerConnection(connection));
                    //SqlTransaction sqlTransaction = connection.BeginTransaction();  //Use Transactions...future maybe?

                    //Determine if processing error file or enumerating folders for .sql files
                    IEnumerable<string> validItems = Enumerable.Empty<string>();
                    if (od.ProcessErrorFiles == true)
                    {
                        //When processing error file get list of files from within the file
                        var tempList = File.ReadAllLines(od.ScriptsToExecutePath);
                        validItems = new List<string>(tempList).Skip(1); //Skip Header Record
                    }
                    else
                    {
                        //Enumerate directory
                        validItems = Directory.EnumerateFiles(scriptsPath, fileFilter, option).OrderBy(f => f);
                    }

                    //Loop through folders and files order by name
                    //foreach (string file in Directory.EnumerateFiles(scriptsPath, fileFilter, option).OrderBy(f => f))
                    foreach (string file in validItems)
                    {
                        currentCount++;
                        sqlScriptFile = File.ReadAllText(file);
                        AppendTextBoxStatusWithTimeStamp(file);

                        exceptionMessage = "";

                        try
                        {
                            server.ConnectionContext.ExecuteNonQuery(sqlScriptFile);    //Execute Script

                            AppendTextBoxStatus("  -- Complete" + "\r\n");
                            scriptsUpdated++;
                            consecutiveErrorCount = 0;  //Reset Consecutive Error count

                            //Log Success if LogErrorsOnly is false
                            if (od.LogErrorsOnly == false)
                            {
                                Log(file + "  -- Successful", w, true);
                            }
                        }

                        catch (Exception ex)
                        {
                            //Console.WriteLine(ex.InnerException.Message.ToString());
                            //Console.WriteLine(ex.GetBaseException().InnerException.ToString() );
                            //Console.WriteLine("Error: " + ex.GetBaseException().Message);

                            exceptionMessage = ex.InnerException.Message.ToString();
                            //Remove line feeds from error messages - ???
                            exceptionMessage = exceptionMessage.Replace(System.Environment.NewLine, "-");

                            AppendTextBoxStatus("  -- Error: " + exceptionMessage + "\r\n");

                            errorCount++;
                            consecutiveErrorCount++;

                            //Log Error
                            Log(file + "-- Error: " + exceptionMessage, w, true);
                            //Add Error FileName to ErrorList
                            od.ErrorListFileNames.Add(file);
                        }

                        //Compile values into an Array (ProgressStepValue, ScriptsUpdated, ErrorCount)
                        string[] arr1 = new string[] { step.ToString(), scriptsUpdated.ToString(), errorCount.ToString() };

                        backgroundWorker1.ReportProgress(0, arr1);
                        //backgroundWorker1.ReportProgress(step);   //orig

                        //Add to Datatable if Create Excel Log is True
                        if (od.CreateExcelLog == true)
                        {
                            if (string.IsNullOrWhiteSpace(exceptionMessage))
                            {
                                exceptionMessage = "Success";
                                status = "S";       //TODO: Enums???
                            }
                            else
                            {
                                status = "E";
                            }
                            //Only Log Errors if Log Errors Only = true
                            if (status == "E" || od.LogErrorsOnly == false)
                            {
                                PopulateDataTable(od.SelectedServer, file, status, DateTime.Now.ToString("yyyyMMddHHmmss"), exceptionMessage);
                            }
                        }

                        //If Stop after xx Errors is set, check here and cancel 
                        if (od.ExecuteScriptsUntilFinished == false)
                        {
                            if (od.ConsecutiveErrors == true)
                            {
                                if (consecutiveErrorCount >= od.StopAfterErrorCount)
                                {
                                    AppendTextBoxStatus("Max Consecutive Errors of " + od.StopAfterErrorCount.ToString() + " has been reached.....Canceling" + "\r\n");
                                    e.Cancel = true;
                                    break;
                                }
                            }
                            else if (errorCount >= od.StopAfterErrorCount)
                            {
                                AppendTextBoxStatus("Max Errors of " + od.StopAfterErrorCount.ToString() + " has been reached.....Canceling" + "\r\n");
                                e.Cancel = true;
                                break;
                            }
                        }

                        if (backgroundWorker1.CancellationPending)
                        {
                            // Set the e.Cancel flag so that the WorkerCompleted event
                            // knows that the process was Canceled.
                            e.Cancel = true;
                            AppendTextBoxStatusWithTimeStamp("User Canceled...");                            
                            //backgroundWorker1.ReportProgress(0);
                            return;
                        }
                    }
                }
                //Finished
                //totalRuntime = startTime;
                TimeSpan span = (DateTime.Now - startTime);
                AppendTextBoxStatus("Execution Complete--" + "\r\n");
                AppendTextBoxStatus("----------Total Runtime: " + String.Format("{0} minutes, {1} seconds", span.Minutes, span.Seconds) + "\r\n");
                AppendTextBoxStatus("----------Total Scripts In Queue: " + od.FileTotalCount.ToString() + "    Total Scripts Run: " + currentCount.ToString() + "    Total Errors: " + errorCount.ToString() + "\r\n");
                //Log
                Log(GetLogFooter(od.FileTotalCount, scriptsUpdated, errorCount), w, false);
                if (od.CreateExcelLog == true)
                {
                    //Create Excel LOG
                    CreateExcelLog();
                }
                //This is a file of just the error scripts.  Use incase you want to just execute these in a 2nd run
                WriteErrorFile(startTime, od.FileTotalCount, errorCount);
            }
        }

        /*-----------------------------------------------------
        BackgroundWorker Progress Changed
        -----------------------------------------------------*/
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string[] runStats = (string[])e.UserState;
            //Console.WriteLine(runStats[0].ToString());  //ProgressBar Step
            //Console.WriteLine(runStats[1].ToString());  //scriptsUpdated
            //Console.WriteLine(runStats[2].ToString());  //errorCount
            int progressStep = Int32.Parse(runStats[0]);

            od.FileSuccessfullUpdateCount = Int32.Parse(runStats[1]);
            od.FilesErrorCount = Int32.Parse(runStats[2]);
            od.ProgressBarValue += progressStep;
        }

        /*-----------------------------------------------------
        BackgroundWorker Completed
        -----------------------------------------------------*/
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            od.ProgressBarValue = 100;
            //MessageBox.Show("DONE!!!");
            od.WorkerIsBusy = false;
            od.CancelButtonEnabled = false;
            od.RunButtonEnabled = true;
        }

       /*-----------------------------------------------------
       Test If Conncection to SQL Server Is Valid
       -----------------------------------------------------*/
        public void CancelProcess()
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }


        /*-----------------------------------------------------
        Populate DataTable  - TODO: Do this better - May not want to populate entire datatable, might get too big
        -----------------------------------------------------*/
        private void PopulateDataTable(string server, string file, string status, string date, string message)
        {
            DataRow dr = excelDataTable.NewRow();
            dr[0] = server;     //Server
            dr[1] = file;       //File
            dr[2] = status;     //Status
            dr[3] = date;       //Date
            dr[4] = message;    //Message
            excelDataTable.Rows.Add(dr);//Add to end of the datatable
        }


        /*-----------------------------------------------------
        Write to Log
        -----------------------------------------------------*/
        private void Log(string logMessage, TextWriter w, bool includeDate)
        {
            if (includeDate == true)
            {
                w.WriteLine("{0} {1} {2}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString(), logMessage);
            }
            else
            {
                w.WriteLine(logMessage);
            }
        }

        /*-----------------------------------------------------
        Get Log Header
        -----------------------------------------------------*/
        private string GetLogHeader()
        {
            string logHeader = "";
            logHeader += "--------------------Execution Starting--------------------" + System.Environment.NewLine;
            logHeader += "--Start Time: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + System.Environment.NewLine;
            logHeader += "--Script To Execute Path: " + od.ScriptsToExecutePath + System.Environment.NewLine;
            logHeader += "--Selected Server: " + od.SelectedServer + System.Environment.NewLine;
            logHeader += "--Log Errors Only: " + od.LogErrorsOnly.ToString() + System.Environment.NewLine;
            logHeader += "--Create Excel Log: " + od.CreateExcelLog.ToString() + System.Environment.NewLine;
            logHeader += "--Include SubFolders: " + od.IncludeSubFolders.ToString() + System.Environment.NewLine;
            logHeader += "----------------------------------------------------------";
            return logHeader;
        }

        /*-----------------------------------------------------
        Get Log Footer
        -----------------------------------------------------*/
        private string GetLogFooter(int totalFiles, int successfulCount, int errorCount)
        {
            string logFooter = "";
            logFooter += "--------------------Execution Complete--------------------" + System.Environment.NewLine;
            logFooter += "--End Time: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + System.Environment.NewLine;
            logFooter += "--Total Files Evaluated: " + totalFiles.ToString() + System.Environment.NewLine;
            logFooter += "--Total Successful: " + successfulCount.ToString() + System.Environment.NewLine;
            logFooter += "--Total Errors: " + errorCount.ToString() + System.Environment.NewLine;
            logFooter += "----------------------------------------------------------";
            return logFooter;
        }


        /*-----------------------------------------------------
        Apend TextBox Status
        -----------------------------------------------------*/
        public void AppendTextBoxStatus(string text)
        {
            od.TextBoxStatusLog += text;
        }

        public void AppendTextBoxStatusWithTimeStamp(string text)
        {
            od.TextBoxStatusLog += DateTime.Now.ToString("yyyyMMddHHmmss") + "--" + text;            
        }


        /*-----------------------------------------------------
        Create Excel Log
        -----------------------------------------------------*/
        private void CreateExcelLog()
        {
            // use ClosedXML to write to excel
            using (var book = new XLWorkbook(XLEventTracking.Disabled))
            {
                book.Worksheets.Add(excelDataTable, "ExcelLog");
                book.SaveAs(od.ExcelFileName);
            }
        }

        /*-----------------------------------------------------
        Get Log Footer
        -----------------------------------------------------*/
        public void OpenLogLocation()
        {
            if (!string.IsNullOrWhiteSpace(od.LogPath))
            {
                Process.Start(od.LogPath);
            }
        }

        /*-----------------------------------------------------
        Error File Header
        -----------------------------------------------------*/
        private void WriteErrorFile(DateTime startTime, int totalFiles,  int errorCount)
        {
            //Only write file if there are Errors
            if (errorCount > 0 )
            {
                using (TextWriter tw = new StreamWriter(od.ErrorFileName))
                {
                    //Write Header to error file
                    tw.WriteLine("HEADER----StartTime:" + startTime.ToString("yyyyMMddHHmmss") + ", TotalFilesDuringThisRun: " + totalFiles.ToString() + ", ErrorCount: " + errorCount.ToString());

                    foreach (String s in od.ErrorListFileNames)
                        tw.WriteLine(s);
                }
            }            
        }

    }


}
