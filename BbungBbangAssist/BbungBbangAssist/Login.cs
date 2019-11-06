using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BbungBbangCrypt;

namespace BbungBbangAssist
{
    // 초기 비번 : 미래123
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Form1 m_dlgParent = null;
        bool m_bIsLogin = false;

        public Login()
        {
            InitializeComponent();
            //SetDefaultPass();
        }

        public void SetParent(Form1 dlgParent)
        {
            m_dlgParent = dlgParent;
        }

        private void SetDefaultPass()
        {
            string strPass = Crypto.Encrypt(Global.DEFAULT_PASS);
            AppConfigMgr.SetAppConfig(Global.APP_KEY_ADMIN_PASS, strPass);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string encrypt = Crypto.Encrypt(loginTxtPass.Text);
            if (encrypt.Equals(AppConfigMgr.GetAppConfig(Global.APP_KEY_ADMIN_PASS)))
            {
                if (m_dlgParent != null)
                {
                    m_dlgParent.Show();
                    m_bIsLogin = true;
                    Hide();
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_bIsLogin == false)
            {
                Application.Exit();
            }
        }
    }
}
