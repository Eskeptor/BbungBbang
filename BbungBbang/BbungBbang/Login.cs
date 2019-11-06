using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BbungBbang
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (CheckUserFolder())
            {
                
            }
        }

        private bool CheckUserFolder()
        {
            bool bResult = false;
            string strPath = Application.StartupPath + Path.DirectorySeparatorChar + Global.PATH_USER_FOLDER;
            DirectoryInfo directoryInfo = new DirectoryInfo(strPath);

            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
                bResult = true;
            }

            return bResult;
        }
    }
}
