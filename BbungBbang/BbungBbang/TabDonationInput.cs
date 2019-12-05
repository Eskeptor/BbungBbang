using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace BbungBbang
{
    public partial class TabDonationInput : Form
    {
        private Thread m_thrFileLoad = null;        // 파일 로드용 스레드
        private LoadingDlg m_dlgLoading = null;     // 로딩 창 다이얼로그

        public TabDonationInput()
        {
            InitializeComponent();

            m_dlgLoading = new LoadingDlg();
        }

        /// <summary>
        /// 파일 로딩 메소드
        /// </summary>
        public void LoadDonationFile()
        {
            if (m_thrFileLoad == null)
            {
                m_thrFileLoad = new Thread(new ThreadStart(LoadFileThread));
                if (m_thrFileLoad != null)
                {
                    m_thrFileLoad.Start();
                    m_dlgLoading.Show();
                }
            }
        }

        /// <summary>
        /// 파일 로딩 메소드(스레드용)
        /// </summary>
        private void LoadFileThread()
        {
            using (Stream stream = new FileStream(Global.PATH_DONATION_DATA, FileMode.Open))
            {
                // <-- 여기서부터 작성하기
            }
            m_dlgLoading.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LoadingDlg dlg = new LoadingDlg())
            {
                dlg.ShowDialog();
            }
        }

        private void TabDonationInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_dlgLoading != null)
                m_dlgLoading.Dispose();

            if (m_thrFileLoad.IsAlive)
                m_thrFileLoad.Interrupt();
        }
    }
}
