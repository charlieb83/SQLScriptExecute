using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


//https://www.wolfsys.net/exec-tsql-scripts-containing-go-statements-with-csharp/
//Need to goto Nuget Console (Tools, Nuget, Nuget Console)
//Install-Package Microsoft.SqlServer.Scripting

//Need to add this to the App.config <startup> tag
//useLegacyV2RuntimeActivationPolicy="true"
//Will look like this <startup useLegacyV2RuntimeActivationPolicy="true"> 


namespace SQLScriptExecute
{
    public partial class UserControlHome : UserControl
    {
        Helper hp = new Helper();

        public UserControlHome()
        {            
            InitializeComponent();

            //Binds WinForms Objects to Class Properties
            comboBoxServer.DataBindings.Add("Text", OptionData.Instance, "SelectedServer", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxScriptPath.DataBindings.Add("Text", OptionData.Instance, "ScriptsToExecutePath", true, DataSourceUpdateMode.OnPropertyChanged);
            labelUseWindowsAuthentication.DataBindings.Add("Text", OptionData.Instance, "WindowsAuthentication", true, DataSourceUpdateMode.OnPropertyChanged);
            labelIncludeSubfolders.DataBindings.Add("Text", OptionData.Instance, "IncludeSubFolders", true, DataSourceUpdateMode.OnPropertyChanged);
            labelExecuteUntilFinished.DataBindings.Add("Text", OptionData.Instance, "ExecuteScriptsUntilFinished", true, DataSourceUpdateMode.OnPropertyChanged);
            labelCreateExcelLog.DataBindings.Add("Text", OptionData.Instance, "CreateExcelLog", true, DataSourceUpdateMode.OnPropertyChanged);
            labelLogErrorsOnly.DataBindings.Add("Text", OptionData.Instance, "LogErrorsOnly", true, DataSourceUpdateMode.OnPropertyChanged);
            labelStopAfterErrorCount.DataBindings.Add("Text", OptionData.Instance, "StopAfterErrorCount", true, DataSourceUpdateMode.OnPropertyChanged);
            labelScriptsInQueueCount.DataBindings.Add("Text", OptionData.Instance, "FileTotalCount", true, DataSourceUpdateMode.OnPropertyChanged);
            labelScriptsUpdatedCount.DataBindings.Add("Text", OptionData.Instance, "FileSuccessfullUpdateCount", true, DataSourceUpdateMode.OnPropertyChanged);
            labelScriptErrorCount.DataBindings.Add("Text", OptionData.Instance, "FilesErrorCount", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxStatus.DataBindings.Add("Text", OptionData.Instance, "TextBoxStatusLog", true, DataSourceUpdateMode.OnPropertyChanged);            
            buttonRun.DataBindings.Add("Enabled", OptionData.Instance, "RunButtonEnabled", true, DataSourceUpdateMode.OnPropertyChanged);
            buttonCancel.DataBindings.Add("Enabled", OptionData.Instance, "CancelButtonEnabled", true, DataSourceUpdateMode.OnPropertyChanged);
            buttonBrowse.DataBindings.Add("Enabled", OptionData.Instance, "RunButtonEnabled", true, DataSourceUpdateMode.OnPropertyChanged);
            buttonTest.DataBindings.Add("Enabled", OptionData.Instance, "RunButtonEnabled", true, DataSourceUpdateMode.OnPropertyChanged);
            //progressBar1.DataBindings.Add("Value", OptionData.Instance, "ProgressBarValue", true, DataSourceUpdateMode.OnPropertyChanged);
            //labelProgressPercent.DataBindings.Add("Text", OptionData.Instance, "ProgressPercentText", true, DataSourceUpdateMode.OnPropertyChanged);
        }


        /*-----------------------------------------------------
        Run Clicked
        -----------------------------------------------------*/
        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (OptionData.Instance.WarnBeforeRunning == true)
            {
                DialogResult result = MessageBox.Show("You are about to execute SQL Scripts." + Environment.NewLine + "You can Cancel while running but it will NOT rollback scripts that already executed." + Environment.NewLine + "Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {
                    textBoxStatus.AppendText("User Chickened Out....." + "\r\n");
                    return;
                }
            }

            hp.ExecuteScripts();
        }

        /*-----------------------------------------------------
        Test Server Connection Clicked
        -----------------------------------------------------*/
        private void buttonTest_Click(object sender, EventArgs e)
        {
            string retValue = "";

            retValue = hp.TestServerConnection(OptionData.Instance.ConnectionString);
            if (retValue != "")
            {
                MessageBox.Show(retValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        /*-----------------------------------------------------
        Browse Clicked
        -----------------------------------------------------*/
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.SelectedPath = OptionData.Instance.ScriptsToExecutePath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxScriptPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /*-----------------------------------------------------
        Cancel Clicked
        -----------------------------------------------------*/
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            hp.CancelProcess();
        }

        /*-----------------------------------------------------
        Open Log Path Label Clicked
        -----------------------------------------------------*/
        private void labelClickOpenLogPath_Click(object sender, EventArgs e)
        {
            hp.OpenLogLocation();
        }        
    }
}
