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
            this.buttonMinimize = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 688);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 606);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "SQL Script";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(23, 634);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Execute";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 532);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelIndicator
            // 
            this.panelIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panelIndicator.Location = new System.Drawing.Point(0, 84);
            this.panelIndicator.Margin = new System.Windows.Forms.Padding(2);
            this.panelIndicator.Name = "panelIndicator";
            this.panelIndicator.Size = new System.Drawing.Size(13, 63);
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
            this.buttonInfo.Location = new System.Drawing.Point(17, 364);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(212, 63);
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
            this.buttonLog.Location = new System.Drawing.Point(17, 294);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(212, 63);
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
            this.buttonOptions.Location = new System.Drawing.Point(17, 224);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(212, 63);
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
            this.buttonConnections.Location = new System.Drawing.Point(17, 154);
            this.buttonConnections.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnections.Name = "buttonConnections";
            this.buttonConnections.Size = new System.Drawing.Size(212, 63);
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
            this.buttonHome.Location = new System.Drawing.Point(17, 84);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(212, 63);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "     Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonCloseForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(229, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(924, 20);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(873, 0);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(19, 18);
            this.buttonMinimize.TabIndex = 3;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseForm.Image")));
            this.buttonCloseForm.Location = new System.Drawing.Point(900, 0);
            this.buttonCloseForm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(19, 18);
            this.buttonCloseForm.TabIndex = 2;
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // labelProgressPercent
            // 
            this.labelProgressPercent.AutoSize = true;
            this.labelProgressPercent.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressPercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressPercent.Location = new System.Drawing.Point(1112, 666);
            this.labelProgressPercent.Name = "labelProgressPercent";
            this.labelProgressPercent.Size = new System.Drawing.Size(38, 15);
            this.labelProgressPercent.TabIndex = 41;
            this.labelProgressPercent.Text = "100%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(229, 662);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(876, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 40;
            // 
            // userControlHome1
            // 
            this.userControlHome1.Location = new System.Drawing.Point(229, 21);
            this.userControlHome1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlHome1.Name = "userControlHome1";
            this.userControlHome1.Size = new System.Drawing.Size(924, 640);
            this.userControlHome1.TabIndex = 46;
            // 
            // userControlConnections1
            // 
            this.userControlConnections1.Location = new System.Drawing.Point(229, 21);
            this.userControlConnections1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlConnections1.Name = "userControlConnections1";
            this.userControlConnections1.Size = new System.Drawing.Size(924, 640);
            this.userControlConnections1.TabIndex = 45;
            // 
            // userControlOptions1
            // 
            this.userControlOptions1.Location = new System.Drawing.Point(229, 21);
            this.userControlOptions1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlOptions1.Name = "userControlOptions1";
            this.userControlOptions1.Size = new System.Drawing.Size(924, 640);
            this.userControlOptions1.TabIndex = 44;
            // 
            // userControlLog1
            // 
            this.userControlLog1.Location = new System.Drawing.Point(229, 21);
            this.userControlLog1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlLog1.Name = "userControlLog1";
            this.userControlLog1.Size = new System.Drawing.Size(924, 640);
            this.userControlLog1.TabIndex = 43;
            // 
            // userControlInfo1
            // 
            this.userControlInfo1.Location = new System.Drawing.Point(229, 21);
            this.userControlInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlInfo1.Name = "userControlInfo1";
            this.userControlInfo1.Size = new System.Drawing.Size(924, 640);
            this.userControlInfo1.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 688);
            this.Controls.Add(this.userControlHome1);
            this.Controls.Add(this.userControlConnections1);
            this.Controls.Add(this.userControlOptions1);
            this.Controls.Add(this.userControlLog1);
            this.Controls.Add(this.userControlInfo1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelProgressPercent);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Panel panelIndicator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProgressPercent;
        private System.Windows.Forms.ProgressBar progressBar1;
        private UserControlInfo userControlInfo1;
        private UserControlLog userControlLog1;
        private UserControlOptions userControlOptions1;
        private UserControlConnections userControlConnections1;
        private UserControlHome userControlHome1;
    }
}

