using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SQLScriptExecute
{
    public partial class UserControlInfo : UserControl
    {
        public UserControlInfo()
        {
            InitializeComponent();
        }

        private void UserControlInfo_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            labelApplicationName.Text = fvi.ProductName;
            labelVersion.Text = fvi.FileVersion;
            labelCopyright.Text = fvi.LegalCopyright;
            textBoxDescription.Text = fvi.Comments;
            labelCompany.Text = fvi.CompanyName;
        }
    }
}
