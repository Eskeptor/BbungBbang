using BbungBbangXml;
using BbungBbangLog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BbungBbangCrypt;

namespace BbungBbang
{
    public partial class LoginDlg : MetroFramework.Forms.MetroForm
    {
        private List<string> m_listAccount = null;  // 계정 리스트
        private Form1 m_dlgParent = null;           // 부모 다이얼로그 (계정관리 메인 다이얼로그)
        private bool m_bIsLogin = false;            // 로그인이 되었는지 여부

        public LoginDlg()
        {
            InitializeComponent();

            InitControls();
        }

        /// <summary>
        /// 로그인 폼이 생성될 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인폼 생성");
        }

        /// <summary>
        /// 컨트롤 초기화 메소드
        /// </summary>
        private void InitControls()
        {
            this.Text = Properties.Resources.String_Login_Title;
            loginLblID.Text = Properties.Resources.String_Login_ID;
            loginLblPW.Text = Properties.Resources.String_Login_PW;
            loginBtnLogin.Text = Properties.Resources.String_Login_Btn_Login;

            if (CheckUserList())
            {
                ResetComboList();
            }
        }

        /// <summary>
        /// 로그인 User 리스트 체크 (로그인용 계정 XML 파일을 읽어옴)
        /// </summary>
        /// <returns>로그인 User 파일을 읽어온 유무</returns>
        private bool CheckUserList()
        {
            bool bResult = false;

            m_listAccount = new List<string>();
            int nResult = XmlMgr.LoadAccount(ref m_listAccount);
            if (nResult == (int)XmlMgr.LoadResult.Success)
                bResult = true;

            return bResult;
        }

        /// <summary>
        /// 로그인 User 리스트 콤보박스 초기화
        /// </summary>
        private void ResetComboList()
        {
            int nSize = m_listAccount.Count / 2;

            for (int i = 0; i < nSize; i++)
            {
                loginCBoxID.Items.Add(m_listAccount[i * 2]);
            }

            loginCBoxID.SelectedIndex = 0;
        }

        public void SetParent(Form1 dlgParent)
        {
            m_dlgParent = dlgParent;
        }

        /// <summary>
        /// 로그인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtnLogin_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인(버튼 클릭)");

            try
            {
                int nSelect = loginCBoxID.SelectedIndex;

                if (string.IsNullOrEmpty(loginEditPW.Text))
                {
                    MessageBox.Show(Properties.Resources.String_Login_Msg_Err_NonePW, Properties.Resources.String_Login_Msg_Warning);
                    return;
                }

                string strEncrypt = Crypto.Encrypt(loginEditPW.Text);
                if (m_listAccount[nSelect * 2 + 1].CompareTo(strEncrypt) == 0)
                {
                    if (m_dlgParent != null)
                    {
                        LogMgr.WriteLog(LogMgr.LogType.EXE, string.Format("로그인 - 로그인 성공({0})", loginCBoxID.Text));
                        m_dlgParent.Show();
                        m_bIsLogin = true;
                        Close();
                    }
                }
                else
                {
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "로그인 - 로그인 실패");
                    MessageBox.Show(Properties.Resources.String_Login_Msg_Err_IncorrectPW, Properties.Resources.String_Login_Msg_Warning);
                }
            }
            catch
            {

            }

        }

        private void LoginDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_bIsLogin == false)
            {
                LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인폼 종료(프로그램 종료)");
                Application.Exit();
            }
            else
                LogMgr.WriteLog(LogMgr.LogType.GUI, "로그인 - 로그인폼 종료(폼 종료)");
        }
    }
}
