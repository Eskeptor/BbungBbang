using System.Drawing;
using System.Windows.Forms;

namespace BbungBbang
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private LoginDlg m_dlgLogin = null;                     // 로그인 다이얼로그
        private TabMain m_tabMain = null;                       // 메인 화면 탭
        private TabDonationInput m_tabDonationInput = null;     // 헌금 입력 탭
        private TabDonationView m_tabDonationView = null;       // 헌금 현황 탭
        private TabSettings m_tabSettings = null;               // 설정 탭

        public Form1()
        {
            InitializeComponent();

            InitControls();
        }

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
                    mainTab.SelectedTab = mainTabMain;
                    mainBtnBack.Hide();
                    break;
                case Global.Page.Input:
                    mainTab.SelectedTab = mainTabInput;
                    m_tabDonationInput.LoadDonationFile();
                    mainBtnBack.Show();
                    break;
                case Global.Page.Review:
                    mainTab.SelectedTab = mainTabReview;
                    mainBtnBack.Show();
                    break;
                case Global.Page.Settings:
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
            ChangeTabPage(Global.Page.Main);
        }
    }
}
