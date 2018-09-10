namespace SQLScriptExecute
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelIndicator = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonConnections = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.labelProgressPercent = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.userControlHome1 = new SQLScriptExecute.UserControlHome();
            this.userControlConnections1 = new SQLScriptExecute.UserControlConnections();
            this.userControlOptions1 = new SQLScriptExecute.UserControlOptions();
            this.userControlLog1 = new SQLScriptExecute.UserControlLog();
            this.userControlInfo1 = new SQLScriptExecute.UserControlInfo();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelIndicator);
            this.panel1.Controls.Add(this.buttonInfo);
            this.panel1.Controls.Add(this.buttonLog);
            this.panel1.Controls.Add(this.buttonOptions);
            this.panel1.Controls.Add(this.buttonConnections);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 1090);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 932);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "SQL Script";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 975);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Execute";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 819);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelIndicator
            // 
            this.panelIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panelIndicator.Location = new System.Drawing.Point(0, 125);
            this.panelIndicator.Name = "panelIndicator";
            this.panelIndicator.Size = new System.Drawing.Size(20, 121);
            this.panelIndicator.TabIndex = 2;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.Location = new System.Drawing.Point(26, 617);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(337, 121);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "     Info";
            this.buttonInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.Color.White;
            this.buttonLog.Image = ((System.Drawing.Image)(resources.GetObject("buttonLog.Image")));
            this.buttonLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLog.Location = new System.Drawing.Point(26, 494);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(337, 121);
            this.buttonLog.TabIndex = 0;
            this.buttonLog.Text = "     Log";
            this.buttonLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptions.ForeColor = System.Drawing.Color.White;
            this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
            this.buttonOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOptions.Location = new System.Drawing.Point(26, 371);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(337, 121);
            this.buttonOptions.TabIndex = 0;
            this.buttonOptions.Text = "     Options";
            this.buttonOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonConnections
            // 
            this.buttonConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonConnections.FlatAppearance.BorderSize = 0;
            this.buttonConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnections.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnections.ForeColor = System.Drawing.Color.White;
            this.buttonConnections.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnections.Image")));
            this.buttonConnections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConnections.Location = new System.Drawing.Point(26, 248);
            this.buttonConnections.Name = "buttonConnections";
            this.buttonConnections.Size = new System.Drawing.Size(337, 121);
            this.buttonConnections.TabIndex = 0;
            this.buttonConnections.Text = "     Connections";
            this.buttonConnections.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConnections.UseVisualStyleBackColor = false;
            this.buttonConnections.Click += new System.EventHandler(this.buttonConnections_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(26, 125);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(337, 121);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "     Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(111)))));
            this.panelTitleBar.Controls.Add(this.button7);
            this.panelTitleBar.Controls.Add(this.buttonCloseForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(363, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1553, 31);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1474, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 27);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseForm.Image")));
            this.buttonCloseForm.Location = new System.Drawing.Point(1517, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(28, 27);
            this.buttonCloseForm.TabIndex = 2;
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // labelProgressPercent
            // 
            this.labelProgressPercent.AutoSize = true;
            this.labelProgressPercent.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressPercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressPercent.Location = new System.Drawing.Point(370, 1056);
            this.labelProgressPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgressPercent.Name = "labelProgressPercent";
            this.labelProgressPercent.Size = new System.Drawing.Size(265, 25);
            this.labelProgressPercent.TabIndex = 41;
            this.labelProgressPercent.Text = "99999 scripts of 99999 (100%)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(643, 1050);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1270, 35);
            this.progressBar1.TabIndex = 40;
            // 
            // userControlHome1
            // 
            this.userControlHome1.Location = new System.Drawing.Point(363, 33);
            this.userControlHome1.Name = "userControlHome1";
            this.userControlHome1.Size = new System.Drawing.Size(1553, 1013);
            this.userControlHome1.TabIndex = 7;
            // 
            // userControlConnections1
            // 
            this.userControlConnections1.Location = new System.Drawing.Point(363, 33);
            this.userControlConnections1.Name = "userControlConnections1";
            this.userControlConnections1.Size = new System.Drawing.Size(1553, 1013);
            this.userControlConnections1.TabIndex = 6;
            // 
            // userControlOptions1
            // 
            this.userControlOptions1.Location = new System.Drawing.Point(363, 33);
            this.userControlOptions1.Name = "userControlOptions1";
            this.userControlOptions1.Size = new System.Drawing.Size(1553, 1013);
            this.userControlOptions1.TabIndex = 5;
            // 
            // userControlLog1
            // 
            this.userControlLog1.Location = new System.Drawing.Point(363, 33);
            this.userControlLog1.Name = "userControlLog1";
            this.userControlLog1.Size = new System.Drawing.Size(1553, 1013);
            this.userControlLog1.TabIndex = 4;
            // 
            // userControlInfo1
            // 
            this.userControlInfo1.Location = new System.Drawing.Point(363, 33);
            this.userControlInfo1.Name = "userControlInfo1";
            this.userControlInfo1.Size = new System.Drawing.Size(1553, 1013);
            this.userControlInfo1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1090);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelProgressPercent);
            this.Controls.Add(this.userControlHome1);
            this.Controls.Add(this.userControlConnections1);
            this.Controls.Add(this.userControlOptions1);
            this.Controls.Add(this.userControlLog1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonConnections;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Panel panelIndicator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControlInfo userControlInfo1;
        private UserControlLog userControlLog1;
        private UserControlOptions userControlOptions1;
        private UserControlConnections userControlConnections1;
        private UserControlHome userControlHome1;
        private System.Windows.Forms.Label labelProgressPercent;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

