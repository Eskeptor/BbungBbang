﻿using BbungBbangLog;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using StringResource = BbungBbang.Properties.Resources;

namespace BbungBbang
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private LoginDlg m_dlgLogin = null;                     // 로그인 다이얼로그
        private TabMain m_tabMain = null;                       // 메인 화면 탭
        private TabDonationInput m_tabDonationInput = null;     // 헌금 입력 탭
        private TabDonationView m_tabDonationView = null;       // 헌금 현황 탭
        private TabSettings m_tabSettings = null;               // 설정 탭
        private Global.Page m_eCurPage = Global.Page.Main;      // 현재 페이지 인덱스

        public Form1()
        {
            InitializeComponent();

            InitFolders();
            InitControls();
        }

        /// <summary>
        /// 컨트롤 초기화
        /// </summary>
        private void InitControls()
        {
            // 다이얼로그 명 설정
            Text = CheckFormName();

            // 탭 구성요소 초기화
            InitTab();

            // ==================================================================
            // 로그인 다이얼로그
            m_dlgLogin = new LoginDlg();
            m_dlgLogin.SetParent(this);
            m_dlgLogin.ShowDialog();
            Hide();
            // ==================================================================

        }

        /// <summary>
        /// 초기 폴더 확인 및 생성
        /// </summary>
        private void InitFolders()
        {
            // ==================================================================
            // Data 폴더 확인
            try
            {
                string strFolderPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Global.PATH_DATA_FOLDER;
                DirectoryInfo directoryInfo = new DirectoryInfo(strFolderPath);

                if (directoryInfo.Exists == false)
                {
                    directoryInfo.Create();
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "Data 폴더 생성");
                }
                else
                {
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "Data 폴더 체크 완료");
                }
            }
            catch
            {
                MessageBox.Show("로그 폴더를 생성할 수 없습니다.");
                LogMgr.WriteLog(LogMgr.LogType.EXE, "Data 폴더 생성 실패");
            }
            // ==================================================================
        }

        /// <summary>
        /// Form의 이름을 AppConfig에서 체크하는 메소드
        /// </summary>
        /// <returns>Form의 이름(비어있을 경우 BbungBbang)</returns>
        private string CheckFormName()
        {
            string strFormName = AppConfigMgr.GetAppConfig(Global.APP_KEY_FORM_NAME);

            if (string.IsNullOrEmpty(strFormName))
            {
                AppConfigMgr.SetAppConfig(Global.APP_KEY_FORM_NAME, "BbungBbang");
                strFormName = "BbungBbang";
            }

            return strFormName;
        }

        /// <summary>
        /// 메인 탭 초기화
        /// </summary>
        private void InitTab()
        {
            m_tabMain = new TabMain();
            m_tabMain.DelegatePage += new TabMain.DelegateChangePage(ChangeTabPage);
            m_tabMain.DelegateTerminate += new TabMain.DelegateTerminateProgram(TerminateProgram);
            m_tabMain.TopLevel = false;
            m_tabMain.TopMost = true;
            m_tabMain.Location = new Point(0, 0);
            mainTabMain.Controls.Clear();
            mainTabMain.Controls.Add(m_tabMain);
            m_tabMain.Show();

            m_tabDonationInput = new TabDonationInput();
            m_tabDonationInput.TopLevel = false;
            m_tabDonationInput.TopMost = true;
            m_tabDonationInput.Location = new Point(0, 0);
            mainTabInput.Controls.Clear();
            mainTabInput.Controls.Add(m_tabDonationInput);
            m_tabDonationInput.Show();

            m_tabDonationView = new TabDonationView();
            m_tabDonationView.TopLevel = false;
            m_tabDonationView.TopMost = true;
            m_tabDonationView.Location = new Point(0, 0);
            mainTabReview.Controls.Clear();
            mainTabReview.Controls.Add(m_tabDonationView);
            m_tabDonationView.Show();

            m_tabSettings = new TabSettings();
            m_tabSettings.TopLevel = false;
            m_tabSettings.TopMost = true;
            m_tabSettings.Location = new Point(0, 0);
            mainTabSettings.Controls.Clear();
            mainTabSettings.Controls.Add(m_tabSettings);
            m_tabSettings.Show();

            mainTab.SelectedTab = mainTabMain;
        }

        /// <summary>
        /// 탭 페이지를 변경하는 메소드(딜리게이트에 연결해서 사용)
        /// </summary>
        /// <param name="nPage">변경할 페이지</param>
        public void ChangeTabPage(Global.Page nPage)
        {
            switch (nPage)
            {
                case Global.Page.Main:
                    m_eCurPage = nPage;
                    mainTab.SelectedTab = mainTabMain;
                    mainBtnBack.Hide();
                    break;
                case Global.Page.Input:
                    m_eCurPage = nPage;
                    mainTab.SelectedTab = mainTabInput;
                    m_tabDonationInput.LoadDonationFile();
                    mainBtnBack.Show();
                    break;
                case Global.Page.Review:
                    m_eCurPage = nPage;
                    mainTab.SelectedTab = mainTabReview;
                    mainBtnBack.Show();
                    break;
                case Global.Page.Settings:
                    m_eCurPage = nPage;
                    mainTab.SelectedTab = mainTabSettings;
                    mainBtnBack.Show();
                    break;
            }
        }

        public void TerminateProgram()
        {
            if (m_tabMain != null)
                m_tabMain.Dispose();

            if (m_dlgLogin != null)
                m_dlgLogin.Dispose();

            if (m_tabDonationInput != null)
                m_tabDonationInput.Dispose();

            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_tabMain != null)
                m_tabMain.Dispose();

            if (m_dlgLogin != null)
                m_dlgLogin.Dispose();
        }

        /// <summary>
        /// 뒤로가기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainBtnBack_Click(object sender, System.EventArgs e)
        {
            if (m_eCurPage == Global.Page.Input)
            {
                if (m_tabDonationInput.GetUserDataChanged())
                {
                    DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, StringResource.String_DonInput_Msg_UserData_Changed,
                        StringResource.String_Login_Msg_Warning, MessageBoxButtons.YesNoCancel);

                    if (dialogResult == DialogResult.Yes)
                    {
                        m_tabDonationInput.SaveDonationFile(Global.ListType.None);
                        m_tabDonationInput.SetUserDataChanged(false);
                        ChangeTabPage(Global.Page.Main);
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {

                    }
                    else
                    {
                        m_tabDonationInput.LoadDonationFile();
                        m_tabDonationInput.RefreshList(Global.ListType.UserHistory);
                        m_tabDonationInput.RefreshList(Global.ListType.UserList);
                        m_tabDonationInput.SetUserDataChanged(false);
                        ChangeTabPage(Global.Page.Main);
                    }
                }
                else
                {
                    ChangeTabPage(Global.Page.Main);
                }
            }
            else if (m_eCurPage == Global.Page.Review)
            {
                ChangeTabPage(Global.Page.Main);
            }
            else if (m_eCurPage == Global.Page.Settings)
            {
                ChangeTabPage(Global.Page.Main);
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
