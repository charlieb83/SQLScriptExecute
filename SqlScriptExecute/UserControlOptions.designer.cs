namespace SQLScriptExecute
{
    partial class UserControlOptions
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxConsecutiveErrors = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxErrorReceivedCount = new System.Windows.Forms.ComboBox();
            this.radioButtonStopAfterError = new System.Windows.Forms.RadioButton();
            this.radioButtonKeepExecutingUntilFinished = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxWarnBeforeExecuting = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeSubfolders = new System.Windows.Forms.CheckBox();
            this.buttonRestoreDefaults = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.checkBoxConsecutiveErrors);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.comboBoxErrorReceivedCount);
            this.groupBox4.Controls.Add(this.radioButtonStopAfterError);
            this.groupBox4.Controls.Add(this.radioButtonKeepExecutingUntilFinished);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(233, 250);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(438, 131);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Errors";
            // 
            // checkBoxConsecutiveErrors
            // 
            this.checkBoxConsecutiveErrors.AutoSize = true;
            this.checkBoxConsecutiveErrors.Location = new System.Drawing.Point(293, 76);
            this.checkBoxConsecutiveErrors.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxConsecutiveErrors.Name = "checkBoxConsecutiveErrors";
            this.checkBoxConsecutiveErrors.Size = new System.Drawing.Size(107, 24);
            this.checkBoxConsecutiveErrors.TabIndex = 4;
            this.checkBoxConsecutiveErrors.Text = "Consecutive";
            this.checkBoxConsecutiveErrors.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Errors Received";
            // 
            // comboBoxErrorReceivedCount
            // 
            this.comboBoxErrorReceivedCount.FormattingEnabled = true;
            this.comboBoxErrorReceivedCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.comboBoxErrorReceivedCount.Location = new System.Drawing.Point(124, 72);
            this.comboBoxErrorReceivedCount.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxErrorReceivedCount.Name = "comboBoxErrorReceivedCount";
            this.comboBoxErrorReceivedCount.Size = new System.Drawing.Size(52, 28);
            this.comboBoxErrorReceivedCount.TabIndex = 2;
            // 
            // radioButtonStopAfterError
            // 
            this.radioButtonStopAfterError.AutoSize = true;
            this.radioButtonStopAfterError.Location = new System.Drawing.Point(30, 76);
            this.radioButtonStopAfterError.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonStopAfterError.Name = "radioButtonStopAfterError";
            this.radioButtonStopAfterError.Size = new System.Drawing.Size(95, 24);
            this.radioButtonStopAfterError.TabIndex = 1;
            this.radioButtonStopAfterError.TabStop = true;
            this.radioButtonStopAfterError.Text = "Stop After";
            this.radioButtonStopAfterError.UseVisualStyleBackColor = true;
            this.radioButtonStopAfterError.Click += new System.EventHandler(this.radioButtonStopAfterError_Click);
            // 
            // radioButtonKeepExecutingUntilFinished
            // 
            this.radioButtonKeepExecutingUntilFinished.AutoSize = true;
            this.radioButtonKeepExecutingUntilFinished.Location = new System.Drawing.Point(30, 24);
            this.radioButtonKeepExecutingUntilFinished.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKeepExecutingUntilFinished.Name = "radioButtonKeepExecutingUntilFinished";
            this.radioButtonKeepExecutingUntilFinished.Size = new System.Drawing.Size(270, 24);
            this.radioButtonKeepExecutingUntilFinished.TabIndex = 0;
            this.radioButtonKeepExecutingUntilFinished.TabStop = true;
            this.radioButtonKeepExecutingUntilFinished.Text = "Keep Executing Scripts Until Finished";
            this.radioButtonKeepExecutingUntilFinished.UseVisualStyleBackColor = true;
            this.radioButtonKeepExecutingUntilFinished.Click += new System.EventHandler(this.radioButtonKeepExecutingUntilFinished_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.checkBoxWarnBeforeExecuting);
            this.groupBox3.Controls.Add(this.checkBoxIncludeSubfolders);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(233, 118);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(438, 115);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execution";
            // 
            // checkBoxWarnBeforeExecuting
            // 
            this.checkBoxWarnBeforeExecuting.AutoSize = true;
            this.checkBoxWarnBeforeExecuting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWarnBeforeExecuting.Location = new System.Drawing.Point(30, 67);
            this.checkBoxWarnBeforeExecuting.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxWarnBeforeExecuting.Name = "checkBoxWarnBeforeExecuting";
            this.checkBoxWarnBeforeExecuting.Size = new System.Drawing.Size(178, 24);
            this.checkBoxWarnBeforeExecuting.TabIndex = 3;
            this.checkBoxWarnBeforeExecuting.Text = "Warn before executing";
            this.checkBoxWarnBeforeExecuting.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeSubfolders
            // 
            this.checkBoxIncludeSubfolders.AutoSize = true;
            this.checkBoxIncludeSubfolders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIncludeSubfolders.Location = new System.Drawing.Point(30, 28);
            this.checkBoxIncludeSubfolders.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxIncludeSubfolders.Name = "checkBoxIncludeSubfolders";
            this.checkBoxIncludeSubfolders.Size = new System.Drawing.Size(151, 24);
            this.checkBoxIncludeSubfolders.TabIndex = 0;
            this.checkBoxIncludeSubfolders.Text = "Include Subfolders";
            this.checkBoxIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreDefaults
            // 
            this.buttonRestoreDefaults.AutoSize = true;
            this.buttonRestoreDefaults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreDefaults.Location = new System.Drawing.Point(350, 432);
            this.buttonRestoreDefaults.Name = "buttonRestoreDefaults";
            this.buttonRestoreDefaults.Size = new System.Drawing.Size(165, 42);
            this.buttonRestoreDefaults.TabIndex = 21;
            this.buttonRestoreDefaults.Text = "Restore Defaults";
            this.buttonRestoreDefaults.UseVisualStyleBackColor = true;
            this.buttonRestoreDefaults.Click += new System.EventHandler(this.buttonRestoreDefaults_Click);
            // 
            // UserControlOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRestoreDefaults);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlOptions";
            this.Size = new System.Drawing.Size(924, 640);
            this.Load += new System.EventHandler(this.UserControlOptions_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxConsecutiveErrors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxErrorReceivedCount;
        private System.Windows.Forms.RadioButton radioButtonStopAfterError;
        private System.Windows.Forms.RadioButton radioButtonKeepExecutingUntilFinished;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxWarnBeforeExecuting;
        private System.Windows.Forms.CheckBox checkBoxIncludeSubfolders;
        private System.Windows.Forms.Button buttonRestoreDefaults;
    }
}
