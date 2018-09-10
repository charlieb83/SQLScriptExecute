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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonLogBrowse);
            this.groupBox2.Controls.Add(this.textBoxLogPath);
            this.groupBox2.Location = new System.Drawing.Point(355, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 328);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxLogErrorsOnly
            // 
            this.checkBoxLogErrorsOnly.AutoSize = true;
            this.checkBoxLogErrorsOnly.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLogErrorsOnly.Location = new System.Drawing.Point(22, 219);
            this.checkBoxLogErrorsOnly.Name = "checkBoxLogErrorsOnly";
            this.checkBoxLogErrorsOnly.Size = new System.Drawing.Size(189, 34);
            this.checkBoxLogErrorsOnly.TabIndex = 5;
            this.checkBoxLogErrorsOnly.Text = "Log Errors Only";
            this.checkBoxLogErrorsOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogCreateExcel
            // 
            this.checkBoxLogCreateExcel.AutoSize = true;
            this.checkBoxLogCreateExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLogCreateExcel.Location = new System.Drawing.Point(22, 146);
            this.checkBoxLogCreateExcel.Name = "checkBoxLogCreateExcel";
            this.checkBoxLogCreateExcel.Size = new System.Drawing.Size(640, 34);
            this.checkBoxLogCreateExcel.TabIndex = 4;
            this.checkBoxLogCreateExcel.Text = "Create Excel File Log (Seperate text log will always be created)";
            this.checkBoxLogCreateExcel.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseDefaultLogPath
            // 
            this.checkBoxUseDefaultLogPath.AutoSize = true;
            this.checkBoxUseDefaultLogPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseDefaultLogPath.Location = new System.Drawing.Point(22, 28);
            this.checkBoxUseDefaultLogPath.Name = "checkBoxUseDefaultLogPath";
            this.checkBoxUseDefaultLogPath.Size = new System.Drawing.Size(513, 34);
            this.checkBoxUseDefaultLogPath.TabIndex = 3;
            this.checkBoxUseDefaultLogPath.Text = "Default Log Path (Current scripts to execute path)";
            this.checkBoxUseDefaultLogPath.UseVisualStyleBackColor = true;
            this.checkBoxUseDefaultLogPath.Click += new System.EventHandler(this.checkBoxUseDefaultLogPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Path:";
            // 
            // buttonLogBrowse
            // 
            this.buttonLogBrowse.AutoSize = true;
            this.buttonLogBrowse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogBrowse.Location = new System.Drawing.Point(588, 72);
            this.buttonLogBrowse.Name = "buttonLogBrowse";
            this.buttonLogBrowse.Size = new System.Drawing.Size(138, 40);
            this.buttonLogBrowse.TabIndex = 1;
            this.buttonLogBrowse.Text = "Browse";
            this.buttonLogBrowse.UseVisualStyleBackColor = true;
            this.buttonLogBrowse.Click += new System.EventHandler(this.buttonLogBrowse_Click);
            // 
            // textBoxLogPath
            // 
            this.textBoxLogPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogPath.Location = new System.Drawing.Point(87, 73);
            this.textBoxLogPath.Name = "textBoxLogPath";
            this.textBoxLogPath.Size = new System.Drawing.Size(484, 37);
            this.textBoxLogPath.TabIndex = 0;
            // 
            // UserControlLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "UserControlLog";
            this.Size = new System.Drawing.Size(1553, 1013);
            this.Load += new System.EventHandler(this.UserControlLog_Load);
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
    }
}
