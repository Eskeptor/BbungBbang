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
using System.Runtime.Serialization.Formatters.Binary;
using BbungBbangLog;
using StringResource = BbungBbang.Properties.Resources;

namespace BbungBbang
{
    public partial class TabDonationInput : Form
    {
        delegate void DelegateThreadSafeUpdateControl();

        private Thread m_thrFileLoad = null;        // 파일 로드용 스레드
        private LoadingDlg m_dlgLoading = null;     // 로딩 창 다이얼로그
        private List<User> m_listUsers = null;
        private event DelegateThreadSafeUpdateControl DelegateUpdateControl;

        public TabDonationInput()
        {
            InitializeComponent();

            // 로딩용 다이얼로그 생성
            m_dlgLoading = new LoadingDlg();
            //m_listUsers = new List<User>();

            // 딜리게이트 설정
            DelegateUpdateControl += ThreadSafeUpdateControl;

            // 시간용 타이머 생성
            donTimerCurTime.Interval = 1000;
            donTimerCurTime.Start();
        }

        private void ThreadSafeUpdateControl()
        {
            m_dlgLoading.Hide();
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
        /// Serialize https://qzqz.tistory.com/254
        /// </summary>
        private void LoadFileThread()
        {
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
                    FileInfo fileInfo = new FileInfo(Global.PATH_DONATION_DATA);

                    try
                    {
                        if (fileInfo.Exists)
                        {
                            using (Stream stream = new FileStream(Global.PATH_DONATION_DATA, FileMode.Open))
                            {
                                try
                                {
                                    BinaryFormatter deserializer = new BinaryFormatter();
                                    m_listUsers = deserializer.Deserialize(stream) as List<User>;
                                }
                                catch (Exception e)
                                {
                                    string strError = string.Format("LoadFileThread Error : {0}", e.ToString());
                                    LogMgr.WriteLog(LogMgr.LogType.EXE, strError);
                                }
                            }
                        }
                        else
                        {
                            LogMgr.WriteLog(LogMgr.LogType.EXE, "Data 파일 없음");
                        }
                    }
                    catch (Exception)
                    {
                        LogMgr.WriteLog(LogMgr.LogType.EXE, "Data 파일 확인 실패");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Data 폴더를 확인할 수 없습니다.");
                LogMgr.WriteLog(LogMgr.LogType.EXE, "Data 폴더 생성 실패");
            }

            if (m_dlgLoading.InvokeRequired)
                m_dlgLoading.Invoke(DelegateUpdateControl);
            else
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

            donTimerCurTime.Stop();
        }

        /// <summary>
        /// 시간 타이머
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donTimerCurTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            if (dateTime.Hour > 12)
            {
                donLblPMAM.Text = StringResource.String_Time_PM;
                donLblHourMinute.Text = string.Format("{0}:{1}", dateTime.Hour - 12, dateTime.Minute);
            }
            else
            {
                donLblPMAM.Text = StringResource.String_Time_AM;
                donLblHourMinute.Text = string.Format("{0}:{1}", dateTime.Hour, dateTime.Minute);
            }

            donLblDate.Text = string.Format("{0}년 {1}월 {2}일", dateTime.Year, dateTime.Month, dateTime.Day);
        }

        private void donBtnUserAdd_Click(object sender, EventArgs e)
        {
            // <-- 추가
        }
    }
}
