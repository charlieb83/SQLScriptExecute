using System;
using System.Windows.Forms;

namespace SQLScriptExecute
{
    public partial class UserControlLog : UserControl
    {
        

        public UserControlLog()
        {
            InitializeComponent();

            //OptionData od = OptionData.Instance;

            //Binds WinForms Objects to Class Properties
            checkBoxUseDefaultLogPath.DataBindings.Add("Checked", OptionData.Instance, "UseDefaultLogPath", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxLogPath.DataBindings.Add("Text", OptionData.Instance, "LogPath", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxLogCreateExcel.DataBindings.Add("Checked", OptionData.Instance, "CreateExcelLog", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxLogErrorsOnly.DataBindings.Add("Checked", OptionData.Instance, "LogErrorsOnly", true, DataSourceUpdateMode.OnPropertyChanged);
            labelLogFileName.DataBindings.Add("Text", OptionData.Instance, "LogFileName", true, DataSourceUpdateMode.OnPropertyChanged);

            //Manual bind to allow CheckBox checkBoxUseDefaultLogPath to control LogPath TextBox and Button Browse Enabled
            Binding bind = new Binding("Enabled", OptionData.Instance, "UseDefaultLogPath");
            Binding bind2 = new Binding("Enabled", OptionData.Instance, "UseDefaultLogPath");
            bind.Format += SwitchBool;
            bind.Parse += SwitchBool;
            bind2.Format += SwitchBool;
            bind2.Parse += SwitchBool;

            textBoxLogPath.DataBindings.Add(bind);
            buttonLogBrowse.DataBindings.Add(bind2);
        }

        /*-----------------------------------------------------
        Switch Boolean Value
        -----------------------------------------------------*/
        private void SwitchBool(object sender, ConvertEventArgs e)
        {
            e.Value = !((bool)e.Value);
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
        
    }
}
