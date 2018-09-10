using System;
using System.Windows.Forms;

namespace SQLScriptExecute
{
    public partial class UserControlConnections : UserControl
    {
        public UserControlConnections()
        {
            InitializeComponent();

            //Binds WinForms Objects to Class Properties
            checkBoxWindowsAuthentication.DataBindings.Add("Checked", OptionData.Instance, "WindowsAuthentication", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxUserName.DataBindings.Add("Text", OptionData.Instance, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxPassword.DataBindings.Add("Text", OptionData.Instance, "Password", true, DataSourceUpdateMode.OnPropertyChanged);
            //Safe Connection String does not display UserName or Password
            textBoxConnectionString.DataBindings.Add("Text", OptionData.Instance, "DisplaySafeConnectionString", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        /*-----------------------------------------------------
        Control Load
        -----------------------------------------------------*/
        private void UserControlConnections_Load(object sender, EventArgs e)
        {
            checkBoxWindowsAuthentication_Click(sender, e);
        }
       

        /*-----------------------------------------------------
        Windows Authentication Clicked
        -----------------------------------------------------*/
        private void checkBoxWindowsAuthentication_Click(object sender, EventArgs e)
        {
            if (checkBoxWindowsAuthentication.Checked == true)
            {
                textBoxUserName.Enabled = false;
                textBoxPassword.Enabled = false;
            }
            else
            {
                textBoxUserName.Enabled = true;
                textBoxPassword.Enabled = true;
            }
        }


        /*-----------------------------------------------------
        Add Server Clicked
        -----------------------------------------------------*/
        private void buttonAddServer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon.");
        }

        private void buttonRemoveServer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon.");
        }
    }
}
