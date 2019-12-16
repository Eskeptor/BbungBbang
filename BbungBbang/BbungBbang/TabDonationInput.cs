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

        private Thread m_thrFileLoad = null;                // 파일 로드용 스레드
        private Thread m_thrFileSave = null;                // 파일 세이브용 스레드
        private LoadingDlg m_dlgLoading = null;             // 로딩 창 다이얼로그
        private List<User> m_listUsers = null;              // 유저 리스트
        private string m_strDlgReturns = string.Empty;      // 다른 다이얼로그로부터 받은 데이터

        private event DelegateThreadSafeUpdateControl DelegateUpdateControl;

        public TabDonationInput()
        {
            InitializeComponent();

            InitControls();

            // 로딩용 다이얼로그 생성
            m_dlgLoading = new LoadingDlg();

            // 딜리게이트 설정
            DelegateUpdateControl += ThreadSafeUpdateControl;

            // 시간용 타이머 생성
            donTimerCurTime.Interval = 1000;
            donTimerCurTime.Start();
        }

        private void InitControls()
        {
            donListUsers.Columns.Add("이름", donListUsers.Size.Width);
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
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "LoadFileThread : Data 폴더 생성");
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
                                    LogMgr.WriteLog(LogMgr.LogType.EXE, "LoadFileThread : 유저 데이터 로드 완료");

                                    BeginInvoke((MethodInvoker)(() => RefreshList(Global.ListType.UserList)));
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
                            m_listUsers = new List<User>();
                            LogMgr.WriteLog(LogMgr.LogType.EXE, "LoadFileThread : Data 파일 없음");
                        }
                    }
                    catch (Exception)
                    {
                        m_listUsers = new List<User>();
                        LogMgr.WriteLog(LogMgr.LogType.EXE, "LoadFileThread : Data 파일 확인 실패");
                    }
                }
            }
            catch
            {
                m_listUsers = new List<User>();
                MessageBox.Show("Data 폴더를 확인할 수 없습니다.");
                LogMgr.WriteLog(LogMgr.LogType.EXE, "LoadFileThread : Data 폴더 생성 실패");
            }

            if (m_dlgLoading.InvokeRequired)
                m_dlgLoading.Invoke(DelegateUpdateControl);
            else
                m_dlgLoading.Hide();

            m_thrFileLoad = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eType"></param>
        private void RefreshList(Global.ListType eType)
        {
            switch (eType)
            {
                case Global.ListType.UserList:
                    {
                        donListUsers.Items.Clear();
                        donListUsers.BeginUpdate();
                        foreach (User user in m_listUsers)
                        {
                            donListUsers.Items.Add(user.Name);
                        }
                        donListUsers.EndUpdate();
                    }
                    break;
                case Global.ListType.UserHistory:
                    break;
            }
        }

        /// <summary>
        /// 파일 세이브 메소드
        /// </summary>
        /// <param name="eType"></param>
        public void SaveDonationFile(Global.ListType eType)
        {
            if (m_thrFileSave == null)
            {
                m_thrFileSave = new Thread(new ParameterizedThreadStart(SaveFileThread));
                if (m_thrFileSave != null)
                {
                    m_thrFileSave.Start(eType);
                    m_dlgLoading.Show();
                }
            }
        }

        /// <summary>
        /// 파일 세이브 메소드(스레드용)
        /// Serialize https://qzqz.tistory.com/254
        /// </summary>
        private void SaveFileThread(object eType)
        {
            Global.ListType eCurType = (Global.ListType)eType;
            try
            {
                string strFolderPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Global.PATH_DATA_FOLDER;
                DirectoryInfo directoryInfo = new DirectoryInfo(strFolderPath);

                if (directoryInfo.Exists == false)
                {
                    directoryInfo.Create();
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "SaveFileThread : Data 폴더 생성");
                }
                else
                {
                    using (Stream stream = new FileStream(Global.PATH_DONATION_DATA, FileMode.Create))
                    {
                        try
                        {
                            BinaryFormatter serializer = new BinaryFormatter();
                            serializer.Serialize(stream, m_listUsers);
                            LogMgr.WriteLog(LogMgr.LogType.EXE, "SaveFileThread : 유저 데이터 저장 완료");

                            if (eCurType != Global.ListType.None)
                                BeginInvoke((MethodInvoker)(() => RefreshList(eCurType)));
                        }
                        catch (Exception e)
                        {
                            string strError = string.Format("SaveFileThread Error : {0}", e.ToString());
                            LogMgr.WriteLog(LogMgr.LogType.EXE, strError);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Data 폴더를 확인할 수 없습니다.");
                LogMgr.WriteLog(LogMgr.LogType.EXE, "SaveFileThread : Data 폴더 생성 실패");
            }

            if (m_dlgLoading.InvokeRequired)
                m_dlgLoading.Invoke(DelegateUpdateControl);
            else
                m_dlgLoading.Hide();

            m_thrFileSave = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LoadingDlg dlg = new LoadingDlg())
            {
                dlg.ShowDialog();
            }
        }

        /// <summary>
        /// 다이얼로그가 종료될때 호출되는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabDonationInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_dlgLoading != null)
                m_dlgLoading.Dispose();

            if (m_thrFileLoad.IsAlive)
                m_thrFileLoad.Interrupt();

            if (m_thrFileSave.IsAlive)
                m_thrFileSave.Interrupt();

            donTimerCurTime.Stop();
        }

        /// <summary>
        /// 타 다이얼로그에서 TabDonationInput에 데이터를 넘겨줄때 사용하는 메소드
        /// </summary>
        /// <param name="strData">넘겨줄 데이터</param>
        public void SetReturnData(string strData)
        {
            m_strDlgReturns = strData;
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

        /// <summary>
        /// 유저 목록 - 추가 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donBtnUserAdd_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 목록 - 추가(버튼 클릭)");

            using (NewUserDlg dlg = new NewUserDlg())
            {
                dlg.SetParentDlg(this);
                DialogResult dialogResult = dlg.ShowDialog();
                bool bIsEqual = false;

                if (dialogResult == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(m_strDlgReturns) == false)
                    {
                        foreach (User user in m_listUsers)
                        {
                            if (user.Name.Equals(m_strDlgReturns))
                            {
                                bIsEqual = true;
                                break;
                            }
                        }

                        if (bIsEqual == false)
                        {
                            User newUser = new User(m_strDlgReturns);
                            m_listUsers.Add(newUser);
                            //SaveDonationFile();
                            RefreshList(Global.ListType.UserList);
                        }
                        m_strDlgReturns = string.Empty;
                    }
                }
            }
        }

        /// <summary>
        /// 전체 수정사항 저장 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donBtnAllSave_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 저장(버튼 클릭)");

            DialogResult dialogResult = MessageBox.Show(StringResource.String_DonInput_Msg_AllSave, StringResource.String_DonInput_Msg_AllSave_Title, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveDonationFile(Global.ListType.None);
            }
        }
    }
}
