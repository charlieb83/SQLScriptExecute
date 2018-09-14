using System;
using System.Drawing;
using System.Windows.Forms;

namespace SQLScriptExecute
{
    public partial class Form1 : Form
    {
        //Needed to allow form to move with mouse
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public Form1()
        {
            InitializeComponent();

            //Start form on Home
            changeButtonBackcolor(buttonHome);
            //userControlHome1.BringToFront();

            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            //Binds WinForms Objects to Class Properties
            progressBar1.DataBindings.Add("Value", OptionData.Instance, "ProgressBarValue", true, DataSourceUpdateMode.OnPropertyChanged);
            progressBar1.DataBindings.Add("Maximum", OptionData.Instance, "FileTotalCount", true, DataSourceUpdateMode.OnPropertyChanged);
            labelProgressPercent.DataBindings.Add("Text", OptionData.Instance, "ProgressPercentText", true, DataSourceUpdateMode.OnPropertyChanged);

            buttonHome.DataBindings.Add("Enabled", OptionData.Instance, "DisableWhenRunning", true, DataSourceUpdateMode.OnPropertyChanged);
            buttonConnections.DataBindings.Add("Enabled", OptionData.Instance, "DisableWhenRunning", true, DataSourceUpdateMode.OnPropertyChanged);
            buttonOptions.DataBindings.Add("Enabled", OptionData.Instance, "DisableWhenRunning", true, DataSourceUpdateMode.OnPropertyChanged);
            buttonLog.DataBindings.Add("Enabled", OptionData.Instance, "DisableWhenRunning", true, DataSourceUpdateMode.OnPropertyChanged);
            buttonInfo.DataBindings.Add("Enabled", OptionData.Instance, "DisableWhenRunning", true, DataSourceUpdateMode.OnPropertyChanged);
        }        

        /*-----------------------------------------------------
        Title Bar (Panel) Click and move form
        -----------------------------------------------------*/
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //To move form with mouse
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /*-----------------------------------------------------
        Change Button Backcolor
        -----------------------------------------------------*/
        private void changeButtonBackcolor(Button b)
        {
            buttonHome.BackColor = default(Color);
            buttonConnections.BackColor = default(Color);
            buttonOptions.BackColor = default(Color);
            buttonLog.BackColor = default(Color);
            buttonInfo.BackColor = default(Color);
            b.BackColor = Color.Gray;
            panelIndicator.Height = b.Height;
            panelIndicator.Top = b.Top;
        }

        /*-----------------------------------------------------
        Button Home Clicked
        -----------------------------------------------------*/
        private void buttonHome_Click(object sender, EventArgs e)
        {
            userControlHome1.BringToFront();
            changeButtonBackcolor((Button)sender);
        }

        /*-----------------------------------------------------
        Button Connections Clicked
        -----------------------------------------------------*/
        private void buttonConnections_Click(object sender, EventArgs e)
        {
            userControlConnections1.BringToFront();
            changeButtonBackcolor((Button)sender);
        }

        /*-----------------------------------------------------
        Button Options Clicked
        -----------------------------------------------------*/
        private void buttonOptions_Click(object sender, EventArgs e)
        {
            userControlOptions1.BringToFront();
            changeButtonBackcolor((Button)sender);
        }

        /*-----------------------------------------------------
        Button Log Clicked
        -----------------------------------------------------*/
        private void buttonLog_Click(object sender, EventArgs e)
        {
            userControlLog1.BringToFront();
            changeButtonBackcolor((Button)sender);
        }

        /*-----------------------------------------------------
        Button Info Clicked
        -----------------------------------------------------*/
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            userControlInfo1.BringToFront();
            changeButtonBackcolor((Button)sender);
        }

        /*-----------------------------------------------------
        Button Minimize Clicked
        -----------------------------------------------------*/
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*-----------------------------------------------------
        Button Close Clicked
        -----------------------------------------------------*/
        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            if (OptionData.Instance.WorkerIsBusy == true)
            {
                MessageBox.Show("Process is currently running. Please cancel before exiting.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Application.Exit();
        }
    }
}
