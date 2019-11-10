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
    public partial class LoginDlg : MetroFramework.Forms.MetroForm
    {
        Form1 m_dlgParent = null;       // 부모 다이얼로그 (계정관리 메인 다이얼로그)
        bool m_bIsLogin = false;        // 로그인이 되었는지 여부

        public LoginDlg()
        {
            InitializeComponent();
            //SetDefaultPass();
            InitControls();
        }

        /// <summary>
        /// 컨트롤 초기화
        /// </summary>
        private void InitControls()
        {
            this.Text = Properties.Resources.String_Login_Title;
            loginLblPasswd.Text = Properties.Resources.String_Login_Password;
            loginBtnLogin.Text = Properties.Resources.String_Login_Btn;
        }

        /// <summary>
        /// 부모 다이얼로그 설정
        /// </summary>
        /// <param name="dlgParent">부모 다이얼로그</param>
        public void SetParent(Form1 dlgParent)
        {
            m_dlgParent = dlgParent;
        }

        /// <summary>
        /// 테스트용 메소드 (기본 패스워드 설정)
        /// </summary>
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
