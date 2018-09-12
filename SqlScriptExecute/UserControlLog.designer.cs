namespace SQLScriptExecute
{
    partial class UserControlLog
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxLogErrorsOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxLogCreateExcel = new System.Windows.Forms.CheckBox();
            this.checkBoxUseDefaultLogPath = new System.Windows.Forms.CheckBox();
            this.labelLogFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLogBrowse = new System.Windows.Forms.Button();
            this.textBoxLogPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxLogErrorsOnly);
            this.groupBox2.Controls.Add(this.checkBoxLogCreateExcel);
            this.groupBox2.Controls.Add(this.checkBoxUseDefaultLogPath);
            this.groupBox2.Controls.Add(this.labelLogFileName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonLogBrowse);
            this.groupBox2.Controls.Add(this.textBoxLogPath);
            this.groupBox2.Location = new System.Drawing.Point(188, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(533, 242);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxLogErrorsOnly
            // 
            this.checkBoxLogErrorsOnly.AutoSize = true;
            this.checkBoxLogErrorsOnly.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLogErrorsOnly.Location = new System.Drawing.Point(15, 178);
            this.checkBoxLogErrorsOnly.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLogErrorsOnly.Name = "checkBoxLogErrorsOnly";
            this.checkBoxLogErrorsOnly.Size = new System.Drawing.Size(129, 24);
            this.checkBoxLogErrorsOnly.TabIndex = 5;
            this.checkBoxLogErrorsOnly.Text = "Log Errors Only";
            this.checkBoxLogErrorsOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogCreateExcel
            // 
            this.checkBoxLogCreateExcel.AutoSize = true;
            this.checkBoxLogCreateExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLogCreateExcel.Location = new System.Drawing.Point(15, 128);
            this.checkBoxLogCreateExcel.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLogCreateExcel.Name = "checkBoxLogCreateExcel";
            this.checkBoxLogCreateExcel.Size = new System.Drawing.Size(443, 24);
            this.checkBoxLogCreateExcel.TabIndex = 4;
            this.checkBoxLogCreateExcel.Text = "Create Excel File Log (Seperate text log will always be created)";
            this.checkBoxLogCreateExcel.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseDefaultLogPath
            // 
            this.checkBoxUseDefaultLogPath.AutoSize = true;
            this.checkBoxUseDefaultLogPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseDefaultLogPath.Location = new System.Drawing.Point(15, 18);
            this.checkBoxUseDefaultLogPath.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUseDefaultLogPath.Name = "checkBoxUseDefaultLogPath";
            this.checkBoxUseDefaultLogPath.Size = new System.Drawing.Size(353, 24);
            this.checkBoxUseDefaultLogPath.TabIndex = 3;
            this.checkBoxUseDefaultLogPath.Text = "Default Log Path (Current scripts to execute path)";
            this.checkBoxUseDefaultLogPath.UseVisualStyleBackColor = true;
            // 
            // labelLogFileName
            // 
            this.labelLogFileName.AutoSize = true;
            this.labelLogFileName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogFileName.Location = new System.Drawing.Point(123, 79);
            this.labelLogFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogFileName.Name = "labelLogFileName";
            this.labelLogFileName.Size = new System.Drawing.Size(97, 20);
            this.labelLogFileName.TabIndex = 2;
            this.labelLogFileName.Text = "LogFileName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log FileName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Path:";
            // 
            // buttonLogBrowse
            // 
            this.buttonLogBrowse.AutoSize = true;
            this.buttonLogBrowse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogBrowse.Location = new System.Drawing.Point(392, 47);
            this.buttonLogBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogBrowse.Name = "buttonLogBrowse";
            this.buttonLogBrowse.Size = new System.Drawing.Size(92, 30);
            this.buttonLogBrowse.TabIndex = 1;
            this.buttonLogBrowse.Text = "Browse";
            this.buttonLogBrowse.UseVisualStyleBackColor = true;
            this.buttonLogBrowse.Click += new System.EventHandler(this.buttonLogBrowse_Click);
            // 
            // textBoxLogPath
            // 
            this.textBoxLogPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogPath.Location = new System.Drawing.Point(58, 47);
            this.textBoxLogPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogPath.Name = "textBoxLogPath";
            this.textBoxLogPath.Size = new System.Drawing.Size(324, 27);
            this.textBoxLogPath.TabIndex = 0;
            // 
            // UserControlLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlLog";
            this.Size = new System.Drawing.Size(924, 640);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxLogErrorsOnly;
        private System.Windows.Forms.CheckBox checkBoxLogCreateExcel;
        private System.Windows.Forms.CheckBox checkBoxUseDefaultLogPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLogBrowse;
        private System.Windows.Forms.TextBox textBoxLogPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelLogFileName;
        private System.Windows.Forms.Label label1;
    }
}
