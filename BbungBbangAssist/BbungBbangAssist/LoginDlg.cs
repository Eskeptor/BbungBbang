using BbungBbangCrypt;
using BbungBbangLog;
using System;
using System.Windows.Forms;

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
            SetDefaultPass();
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
            if (string.IsNullOrEmpty(AppConfigMgr.GetAppConfig(Global.APP_KEY_ADMIN_PASS)))
            {
                LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 계정 초기화(계정 정보 사라짐)");

                string strPass = Crypto.Encrypt(Global.DEFAULT_PASS);
                AppConfigMgr.SetAppConfig(Global.APP_KEY_ADMIN_PASS, strPass);
            }
        }

        /// <summary>
        /// 로그인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton1_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인(버튼 클릭)");

            string encrypt = Crypto.Encrypt(loginTxtPass.Text);
            if (encrypt.Equals(AppConfigMgr.GetAppConfig(Global.APP_KEY_ADMIN_PASS)))
            {
                if (m_dlgParent != null)
                {
                    LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인 성공");
                    m_dlgParent.Show();
                    m_bIsLogin = true;
                    Hide();
                }
            }
            else
                LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인 실패");
        }

        /// <summary>
        /// 폼이 종료될 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_bIsLogin == false)
            {
                LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인폼 종료(프로그램 종료)");
                Application.Exit();
            }
            else
                LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인폼 종료(폼 종료)");
        }

        /// <summary>
        /// 로그인폼이 Show 되었을 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginDlg_Shown(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인폼 생성");
        }
    }
}
