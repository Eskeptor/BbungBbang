using System.Drawing;
using System.Windows.Forms;

namespace BbungBbang
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private LoginDlg m_dlgLogin = null;
        private TabMain m_tabMain = null;

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

            mainTab.SelectedTab = mainTabMain;
        }

        /// <summary>
        /// 탭 페이지를 변경하는 메소드(딜리게이트에 연결해서 사용)
        /// </summary>
        /// <param name="nPage">변경할 페이지</param>
        public void ChangeTabPage(int nPage)
        {
            switch (nPage)
            {
                case (int)Global.Page.Main:
                    break;
                case (int)Global.Page.Input:
                    break;
                case (int)Global.Page.Review:
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
    }
}
