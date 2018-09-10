namespace SQLScriptExecute
{
    partial class UserControlHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHome));
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxScriptPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelStopAfterErrorCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelExecuteUntilFinished = new System.Windows.Forms.Label();
            this.labelIncludeSubfolders = new System.Windows.Forms.Label();
            this.labelLogErrorsOnly = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCreateExcelLog = new System.Windows.Forms.Label();
            this.labelUseWindowsAuthentication = new System.Windows.Forms.Label();
            this.labelScriptErrorCount = new System.Windows.Forms.Label();
            this.labelScriptsInQueueCount = new System.Windows.Forms.Label();
            this.labelScriptsUpdatedCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelClickOpenLogPath = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxProcessErrorFile = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.White;
            this.textBoxStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(0, 188);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxStatus.Size = new System.Drawing.Size(1037, 470);
            this.textBoxStatus.TabIndex = 15;
            this.textBoxStatus.WordWrap = false;
            // 
            // buttonRun
            // 
            this.buttonRun.AutoSize = true;
            this.buttonRun.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Image = ((System.Drawing.Image)(resources.GetObject("buttonRun.Image")));
            this.buttonRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRun.Location = new System.Drawing.Point(269, 93);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(124, 41);
            this.buttonRun.TabIndex = 14;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Script Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Server:";
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(111, 21);
            this.comboBoxServer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(585, 28);
            this.comboBoxServer.TabIndex = 11;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(706, 55);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(101, 27);
            this.buttonBrowse.TabIndex = 10;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxScriptPath
            // 
            this.textBoxScriptPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScriptPath.Location = new System.Drawing.Point(111, 56);
            this.textBoxScriptPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxScriptPath.Name = "textBoxScriptPath";
            this.textBoxScriptPath.Size = new System.Drawing.Size(585, 27);
            this.textBoxScriptPath.TabIndex = 9;
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.Location = new System.Drawing.Point(706, 22);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(101, 26);
            this.buttonTest.TabIndex = 16;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(440, 93);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 41);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Stop After Error Count:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Execute Until Finished:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Include Subfolders:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Log Errors Only:";
            // 
            // labelStopAfterErrorCount
            // 
            this.labelStopAfterErrorCount.AutoSize = true;
            this.labelStopAfterErrorCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopAfterErrorCount.Location = new System.Drawing.Point(155, 142);
            this.labelStopAfterErrorCount.Name = "labelStopAfterErrorCount";
            this.labelStopAfterErrorCount.Size = new System.Drawing.Size(22, 15);
            this.labelStopAfterErrorCount.TabIndex = 22;
            this.labelStopAfterErrorCount.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Create Excel Log:";
            // 
            // labelExecuteUntilFinished
            // 
            this.labelExecuteUntilFinished.AutoSize = true;
            this.labelExecuteUntilFinished.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecuteUntilFinished.Location = new System.Drawing.Point(150, 71);
            this.labelExecuteUntilFinished.Name = "labelExecuteUntilFinished";
            this.labelExecuteUntilFinished.Size = new System.Drawing.Size(34, 15);
            this.labelExecuteUntilFinished.TabIndex = 24;
            this.labelExecuteUntilFinished.Text = "False";
            // 
            // labelIncludeSubfolders
            // 
            this.labelIncludeSubfolders.AutoSize = true;
            this.labelIncludeSubfolders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncludeSubfolders.Location = new System.Drawing.Point(150, 48);
            this.labelIncludeSubfolders.Name = "labelIncludeSubfolders";
            this.labelIncludeSubfolders.Size = new System.Drawing.Size(34, 15);
            this.labelIncludeSubfolders.TabIndex = 25;
            this.labelIncludeSubfolders.Text = "False";
            // 
            // labelLogErrorsOnly
            // 
            this.labelLogErrorsOnly.AutoSize = true;
            this.labelLogErrorsOnly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogErrorsOnly.Location = new System.Drawing.Point(150, 118);
            this.labelLogErrorsOnly.Name = "labelLogErrorsOnly";
            this.labelLogErrorsOnly.Size = new System.Drawing.Size(34, 15);
            this.labelLogErrorsOnly.TabIndex = 26;
            this.labelLogErrorsOnly.Text = "False";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Use Windows Auth:";
            // 
            // labelCreateExcelLog
            // 
            this.labelCreateExcelLog.AutoSize = true;
            this.labelCreateExcelLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateExcelLog.Location = new System.Drawing.Point(150, 95);
            this.labelCreateExcelLog.Name = "labelCreateExcelLog";
            this.labelCreateExcelLog.Size = new System.Drawing.Size(34, 15);
            this.labelCreateExcelLog.TabIndex = 28;
            this.labelCreateExcelLog.Text = "False";
            // 
            // labelUseWindowsAuthentication
            // 
            this.labelUseWindowsAuthentication.AutoSize = true;
            this.labelUseWindowsAuthentication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUseWindowsAuthentication.Location = new System.Drawing.Point(150, 25);
            this.labelUseWindowsAuthentication.Name = "labelUseWindowsAuthentication";
            this.labelUseWindowsAuthentication.Size = new System.Drawing.Size(34, 15);
            this.labelUseWindowsAuthentication.TabIndex = 29;
            this.labelUseWindowsAuthentication.Text = "False";
            // 
            // labelScriptErrorCount
            // 
            this.labelScriptErrorCount.AutoSize = true;
            this.labelScriptErrorCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScriptErrorCount.ForeColor = System.Drawing.Color.Red;
            this.labelScriptErrorCount.Location = new System.Drawing.Point(523, 12);
            this.labelScriptErrorCount.Name = "labelScriptErrorCount";
            this.labelScriptErrorCount.Size = new System.Drawing.Size(36, 20);
            this.labelScriptErrorCount.TabIndex = 33;
            this.labelScriptErrorCount.Text = "999";
            // 
            // labelScriptsInQueueCount
            // 
            this.labelScriptsInQueueCount.AutoSize = true;
            this.labelScriptsInQueueCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScriptsInQueueCount.Location = new System.Drawing.Point(115, 12);
            this.labelScriptsInQueueCount.Name = "labelScriptsInQueueCount";
            this.labelScriptsInQueueCount.Size = new System.Drawing.Size(36, 20);
            this.labelScriptsInQueueCount.TabIndex = 34;
            this.labelScriptsInQueueCount.Text = "999";
            // 
            // labelScriptsUpdatedCount
            // 
            this.labelScriptsUpdatedCount.AutoSize = true;
            this.labelScriptsUpdatedCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScriptsUpdatedCount.Location = new System.Drawing.Point(317, 12);
            this.labelScriptsUpdatedCount.Name = "labelScriptsUpdatedCount";
            this.labelScriptsUpdatedCount.Size = new System.Drawing.Size(36, 20);
            this.labelScriptsUpdatedCount.TabIndex = 35;
            this.labelScriptsUpdatedCount.Text = "999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Script Errors:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total Scripts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Scripts Updated:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelUseWindowsAuthentication);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelIncludeSubfolders);
            this.groupBox1.Controls.Add(this.labelExecuteUntilFinished);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.labelCreateExcelLog);
            this.groupBox1.Controls.Add(this.labelLogErrorsOnly);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.labelStopAfterErrorCount);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(823, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 179);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Runtime Options";
            // 
            // labelClickOpenLogPath
            // 
            this.labelClickOpenLogPath.AutoSize = true;
            this.labelClickOpenLogPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClickOpenLogPath.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickOpenLogPath.Location = new System.Drawing.Point(632, 15);
            this.labelClickOpenLogPath.Name = "labelClickOpenLogPath";
            this.labelClickOpenLogPath.Size = new System.Drawing.Size(143, 15);
            this.labelClickOpenLogPath.TabIndex = 30;
            this.labelClickOpenLogPath.Text = "Click To Open Log Folder";
            this.labelClickOpenLogPath.Click += new System.EventHandler(this.labelClickOpenLogPath_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelClickOpenLogPath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelScriptsInQueueCount);
            this.groupBox2.Controls.Add(this.labelScriptErrorCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelScriptsUpdatedCount);
            this.groupBox2.Location = new System.Drawing.Point(7, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 38);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxProcessErrorFile
            // 
            this.checkBoxProcessErrorFile.AutoSize = true;
            this.checkBoxProcessErrorFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProcessErrorFile.Location = new System.Drawing.Point(667, 101);
            this.checkBoxProcessErrorFile.Name = "checkBoxProcessErrorFile";
            this.checkBoxProcessErrorFile.Size = new System.Drawing.Size(140, 24);
            this.checkBoxProcessErrorFile.TabIndex = 38;
            this.checkBoxProcessErrorFile.Text = "Process Error File";
            this.checkBoxProcessErrorFile.UseVisualStyleBackColor = true;
            this.checkBoxProcessErrorFile.Click += new System.EventHandler(this.checkBoxProcessErrorFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxProcessErrorFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxServer);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxScriptPath);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(1035, 658);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxScriptPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelStopAfterErrorCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelExecuteUntilFinished;
        private System.Windows.Forms.Label labelIncludeSubfolders;
        private System.Windows.Forms.Label labelLogErrorsOnly;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCreateExcelLog;
        private System.Windows.Forms.Label labelUseWindowsAuthentication;
        private System.Windows.Forms.Label labelScriptErrorCount;
        private System.Windows.Forms.Label labelScriptsInQueueCount;
        private System.Windows.Forms.Label labelScriptsUpdatedCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelClickOpenLogPath;
        private System.Windows.Forms.CheckBox checkBoxProcessErrorFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
