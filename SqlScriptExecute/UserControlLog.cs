using System;
using System.Windows.Forms;

namespace SQLScriptExecute
{
    public partial class UserControlLog : UserControl
    {
        

        public UserControlLog()
        {
            InitializeComponent();

            OptionData od = OptionData.Instance;

            //Binds WinForms Objects to Class Properties
            checkBoxUseDefaultLogPath.DataBindings.Add("Checked", od, "UseDefaultLogPath", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxLogPath.DataBindings.Add("Text", od, "LogPath", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxLogCreateExcel.DataBindings.Add("Checked", od, "CreateExcelLog", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxLogErrorsOnly.DataBindings.Add("Checked", od, "LogErrorsOnly", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        /*-----------------------------------------------------
        Control Load
        -----------------------------------------------------*/
        private void UserControlLog_Load(object sender, EventArgs e)
        {
            checkBoxUseDefaultLogPath_Click(sender, e);
        }

        /*-----------------------------------------------------
        Log Browse Clicked
        -----------------------------------------------------*/
        private void buttonLogBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxLogPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /*-----------------------------------------------------
        checkBoxUseDefaultLogPath Clicked
        -----------------------------------------------------*/
        private void checkBoxUseDefaultLogPath_Click(object sender, EventArgs e)
        {
            if (checkBoxUseDefaultLogPath.Checked)
            {
                textBoxLogPath.Enabled = false;
                buttonLogBrowse.Enabled = false;
            }
            else
            {
                textBoxLogPath.Enabled = true;
                buttonLogBrowse.Enabled = true;
            }
        }
        
    }
}
