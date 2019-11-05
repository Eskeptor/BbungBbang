using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BbungBbang
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        TabMain mTabMain = null;

        public Form1()
        {
            InitializeComponent();

            // 다이얼로그 명 설정
            Text = CheckFormName();

            // 탭 구성요소 초기화
            InitTab();
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
            mTabMain = new TabMain();
            mTabMain.DelegatePage += new TabMain.DelegateChangePage(ChangeTabPage);
            mTabMain.TopLevel = false;
            mTabMain.TopMost = true;
            mTabMain.Location = new Point(0, 0);
            mainTabMain.Controls.Clear();
            mainTabMain.Controls.Add(mTabMain);
            mTabMain.Show();

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mTabMain.Dispose();
        }
    }
}
