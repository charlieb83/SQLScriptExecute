using System;
using System.Windows.Forms;

namespace SQLScriptExecute
{
    public partial class UserControlOptions : UserControl
    {
        public UserControlOptions()
        {
            InitializeComponent();

            //Binds WinForms Objects to Class Properties
            checkBoxIncludeSubfolders.DataBindings.Add("Checked", OptionData.Instance, "IncludeSubFolders", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxWarnBeforeExecuting.DataBindings.Add("Checked", OptionData.Instance, "WarnBeforeRunning", true, DataSourceUpdateMode.OnPropertyChanged);
            radioButtonKeepExecutingUntilFinished.DataBindings.Add("Checked", OptionData.Instance, "ExecuteScriptsUntilFinished", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxErrorReceivedCount.DataBindings.Add("Text", OptionData.Instance, "StopAfterErrorCount", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxConsecutiveErrors.DataBindings.Add("Checked", OptionData.Instance, "ConsecutiveErrors", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        /*-----------------------------------------------------
        Control Load
        -----------------------------------------------------*/
        private void UserControlOptions_Load(object sender, EventArgs e)
        {
            SetupRadioButtons();
        }


        /*-----------------------------------------------------
        Button Retore Defaults Clicked
        -----------------------------------------------------*/
        private void buttonRestoreDefaults_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("You are about to restore all settings to their default values." + Environment.NewLine + "Do you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                OptionData.Instance.ResetDefaultValues();
            }
        }

        /*-----------------------------------------------------
        Radio Button Keep Executing Until Finished Clicked
        -----------------------------------------------------*/
        private void radioButtonKeepExecutingUntilFinished_Click(object sender, EventArgs e)
        {
            if (radioButtonKeepExecutingUntilFinished.Checked)
            {
                comboBoxErrorReceivedCount.Enabled = false;
                checkBoxConsecutiveErrors.Enabled = false;
            }
        }

        /*-----------------------------------------------------
        Radio Button Stop After Error Clicked
        -----------------------------------------------------*/
        private void radioButtonStopAfterError_Click(object sender, EventArgs e)
        {
            if (radioButtonStopAfterError.Checked)
            {
                comboBoxErrorReceivedCount.Enabled = true;
                checkBoxConsecutiveErrors.Enabled = true;
            }
        }

        private void SetupRadioButtons()
        {
            if(radioButtonKeepExecutingUntilFinished.Checked)
            {
                comboBoxErrorReceivedCount.Enabled = false;
                checkBoxConsecutiveErrors.Enabled = false;
            }
            else
            {
                radioButtonStopAfterError.Checked = true;
                comboBoxErrorReceivedCount.Enabled = true;
                checkBoxConsecutiveErrors.Enabled = true;
            }
        }
        
    }
}
