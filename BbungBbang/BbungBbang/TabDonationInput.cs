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
        delegate void DelegateThreadSafeUpdateControl(Global.UserDataThreadType eType, bool bIsSuccessed);

        private Thread m_thrFileLoad = null;                         // 파일 로드용 스레드
        private Thread m_thrFileSave = null;                         // 파일 세이브용 스레드
        private LoadingDlg m_dlgLoading = null;                      // 로딩 창 다이얼로그
        private string m_strDlgReturns = string.Empty;               // 다른 다이얼로그로부터 받은 데이터
        private int m_nCurSelectedUserIdx = Global.USER_IDX_NONE;    // 유저 리스트에서 현재 선택된 유저 인덱스
        private int m_nCurSelectedHistoryIdx = Global.USER_IDX_NONE; // 유저 히스토리에서 현재 선택된 인덱스
        private bool m_bIsInfoChanged = false;                       // 유저 데이터 변경 유무
        public List<User> m_listUsers = null;                        // 유저 리스트

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

        /// <summary>
        /// 컨트롤 초기화
        /// </summary>
        private void InitControls()
        {
            // 유저 리스트
            listUser.Columns.Add("이름", listUser.Size.Width);
            lblUserTitle.Text = StringResource.String_DonInput_Userlist_Title;
            btnUserSel.Text = StringResource.String_DonInput_Userlist_Btn_Select;
            btnUserAdd.Text = StringResource.String_DonInput_Userlist_Btn_Add;
            btnUserMod.Text = StringResource.String_DonInput_Userlist_Btn_Modify;
            btnUserDel.Text = StringResource.String_DonInput_Userlist_Btn_Del;

            // 유저 히스토리
            lblHistoryTitle.Text = StringResource.String_DonInput_History_Title;
            lblHistoryName.Text = StringResource.String_DonInput_History_Name;
            lblHistoryDonType.Text = StringResource.String_DonInput_History_DonType;
            lblHistoryDon.Text = StringResource.String_DonInput_History_Don;

            cboxNewType.Items.AddRange(Global.STR_DONATION_TYPE);
            cboxHistoryType.Items.AddRange(Global.STR_DONATION_TYPE);

            // 버튼 초기화
            btnUserSel.Enabled = false;
            btnUserMod.Enabled = false;
            btnUserDel.Enabled = false;
            btnHistoryMod.Enabled = false;
            btnHistoryDel.Enabled = false;
            btnNewAdd.Enabled = false;
        }

        /// <summary>
        /// Thread Safe한 컨트롤 업데이트 메소드
        ///  - 로딩 다이얼로그 Hide
        ///  - 성공유무에따른 메시지박스 Show
        /// </summary>
        /// <param name="bIsSuccessed"></param>
        private void ThreadSafeUpdateControl(Global.UserDataThreadType eType, bool bIsSuccessed)
        {
            m_dlgLoading.Hide();

            switch (eType)
            {
                case Global.UserDataThreadType.Load:
                    
                    break;
                case Global.UserDataThreadType.Save:
                    {
                        if (bIsSuccessed)
                            MessageBox.Show(new Form { TopMost = true }, StringResource.String_DonInput_Msg_AllSaveComplete, StringResource.String_DonInput_Msg_AllSave_Title);
                        else
                            MessageBox.Show(new Form { TopMost = true }, StringResource.String_DonInput_Msg_AllSaveFailed, StringResource.String_Login_Msg_Warning);
                    }
                    break;
            }
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
            bool bIsSuccessed = false;      // 스레드 동작 성공 유무
            try
            {
                string strFolderPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Global.PATH_DATA_FOLDER;
                DirectoryInfo directoryInfo = new DirectoryInfo(strFolderPath);

                // Data 폴더가 없을 때 폴더를 생성
                if (directoryInfo.Exists == false)
                {
                    directoryInfo.Create();
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "LoadFileThread : Data 폴더 생성");
                }
                // Data 폴더가 있을 때는 유저 데이터 파일 확인
                else
                {
                    FileInfo fileInfo = new FileInfo(Global.PATH_DONATION_DATA);
                    try
                    {
                        // 유저 데이터 파일이 존재할 경우
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
                                    bIsSuccessed = true;
                                }
                                catch (Exception e)
                                {
                                    string strError = string.Format("LoadFileThread Error : {0}", e.ToString());
                                    LogMgr.WriteLog(LogMgr.LogType.EXE, strError);
                                }
                            }
                        }
                        // 유저 데이터 파일이 존재하지 않을 경우
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
                MessageBox.Show(new Form { TopMost = true }, "Data 폴더를 확인할 수 없습니다.");
                LogMgr.WriteLog(LogMgr.LogType.EXE, "LoadFileThread : Data 폴더 생성 실패");
            }

            if (m_dlgLoading.InvokeRequired)
                m_dlgLoading.Invoke(DelegateUpdateControl, Global.UserDataThreadType.Load, bIsSuccessed);
            else
                ThreadSafeUpdateControl(Global.UserDataThreadType.Load, bIsSuccessed);

            m_thrFileLoad = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eType"></param>
        public void RefreshList(Global.ListType eType)
        {
            switch (eType)
            {
                case Global.ListType.UserList:
                    {
                        listUser.Items.Clear();

                        listUser.BeginUpdate();
                        foreach (User user in m_listUsers)
                        {
                            listUser.Items.Add(user.Name);
                        }
                        listUser.EndUpdate();
                    }
                    break;
                case Global.ListType.UserHistory:
                    {
                        listHistory.Items.Clear();

                        listHistory.BeginUpdate();
                        foreach (Donation donation in m_listUsers[m_nCurSelectedUserIdx].Donations)
                        {
                            string[] arrHistory = new string[2] { donation.DonationTime.ToString("yyyy년 MM월 dd일"), Global.STR_DONATION_TYPE[(int)donation.DonationType] };
                            ListViewItem item = new ListViewItem(arrHistory);

                            listHistory.Items.Add(item);
                        }
                        listHistory.EndUpdate();
                    }
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
            bool bIsSuccessed = false;
            try
            {
                string strFolderPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Global.PATH_DATA_FOLDER;
                DirectoryInfo directoryInfo = new DirectoryInfo(strFolderPath);

                // Data 폴더가 없을 때 폴더를 생성
                if (directoryInfo.Exists == false)
                {
                    directoryInfo.Create();
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "SaveFileThread : Data 폴더 생성");
                }

                // 유저 데이터파일 저장
                using (Stream stream = new FileStream(Global.PATH_DONATION_DATA, FileMode.Create))
                {
                    try
                    {
                        BinaryFormatter serializer = new BinaryFormatter();
                        serializer.Serialize(stream, m_listUsers);
                        LogMgr.WriteLog(LogMgr.LogType.EXE, "SaveFileThread : 유저 데이터 저장 완료");

                        if (eCurType != Global.ListType.None)
                            BeginInvoke((MethodInvoker)(() => RefreshList(eCurType)));
                        bIsSuccessed = true;
                    }
                    catch (Exception e)
                    {
                        string strError = string.Format("SaveFileThread Error : {0}", e.ToString());
                        LogMgr.WriteLog(LogMgr.LogType.EXE, strError);
                    }
                }

            }
            catch
            {
                MessageBox.Show(new Form { TopMost = true }, "Data 폴더를 확인할 수 없습니다.");
                LogMgr.WriteLog(LogMgr.LogType.EXE, "SaveFileThread : Data 폴더 생성 실패");
            }

            if (m_dlgLoading.InvokeRequired)
                m_dlgLoading.Invoke(DelegateUpdateControl, Global.UserDataThreadType.Save, bIsSuccessed);
            else
                ThreadSafeUpdateControl(Global.UserDataThreadType.Save, bIsSuccessed);

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
                lblPMAM.Text = StringResource.String_Time_PM;
                lblHourMinute.Text = string.Format("{0}:{1}", dateTime.Hour - 12, dateTime.Minute);
            }
            else
            {
                lblPMAM.Text = StringResource.String_Time_AM;
                lblHourMinute.Text = string.Format("{0}:{1}", dateTime.Hour, dateTime.Minute);
            }

            lblDate.Text = string.Format("{0}년 {1}월 {2}일", dateTime.Year, dateTime.Month, dateTime.Day);
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
                            m_bIsInfoChanged = true;
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

            DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, StringResource.String_DonInput_Msg_AllSave, 
                StringResource.String_DonInput_Msg_AllSave_Title, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveDonationFile(Global.ListType.None);
                m_bIsInfoChanged = false;
            }
        }

        /// <summary>
        /// 유저 목록 - 선택 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donBtnUserSel_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 목록 - 선택(버튼 클릭)");

            int nCurSelectedIdx = listUser.SelectedItems[0].Index;
            
            if (nCurSelectedIdx >= 0)
            {
                m_nCurSelectedUserIdx = nCurSelectedIdx;

                editHistoryName.Text = m_listUsers[m_nCurSelectedUserIdx].Name;
                editNewName.Text = m_listUsers[m_nCurSelectedUserIdx].Name;

                RefreshList(Global.ListType.UserHistory);

                btnUserMod.Enabled = true;
                btnUserDel.Enabled = true;
                btnNewAdd.Enabled = true;

                LogMgr.WriteLog(LogMgr.LogType.EXE, string.Format("선택된 유저 : {0}", editHistoryName.Text));
            }
        }

        /// <summary>
        /// 유저 목록 - 수정 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donBtnUserMod_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 목록 - 수정(버튼 클릭)");

            if (m_nCurSelectedUserIdx != Global.USER_IDX_NONE &&
                listUser.Items.Count > m_nCurSelectedUserIdx)
            {
                m_bIsInfoChanged = true;
            }
            else
            {

            }
        }

        /// <summary>
        /// 유저 목록 - 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donBtnUserDel_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 목록 - 삭제(버튼 클릭)");

            if (m_nCurSelectedUserIdx != Global.USER_IDX_NONE &&
                m_nCurSelectedUserIdx >= 0 &&
                m_nCurSelectedUserIdx < m_listUsers.Count)
            {
                DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, 
                    string.Format(StringResource.String_DonInput_Msg_UserDelete, m_listUsers[m_nCurSelectedUserIdx].Name),
                    StringResource.String_Login_Msg_Warning,
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 목록 - 삭제(삭제 완료)");
                    LogMgr.WriteLog(LogMgr.LogType.EXE, string.Format("삭제된 유저 : {0}", m_listUsers[m_nCurSelectedUserIdx].Name));

                    m_listUsers.RemoveAt(m_nCurSelectedUserIdx);
                    m_nCurSelectedUserIdx = Global.USER_IDX_NONE;
                    m_bIsInfoChanged = true;
                }
                else
                {
                    LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 목록 - 삭제(삭제 취소)");
                }
            }
            
        }

        /// <summary>
        /// 헌금 추가 - 추가 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donBtnNewAdd_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 헌금 추가 - 추가(버튼 클릭)");

            if (m_nCurSelectedUserIdx >= Global.USER_IDX_NONE &&
                listUser.Items.Count > m_nCurSelectedUserIdx)
            {
                using (InputConfirmDlg dlg = new InputConfirmDlg())
                {
                    dlg.SetTitle(Global.InputConfirmType.Add);
                    dlg.SetData(editNewName.Text, dateTimeNew.Value, cboxNewType.SelectedIndex, editNewDon.Text);

                    DialogResult dialogResult = dlg.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        Donation newDonation = new Donation();
                        newDonation.DonationTime = dateTimeNew.Value;
                        newDonation.DonationType = (Global.DonationType)cboxNewType.SelectedIndex;
                        newDonation.Money = int.Parse(editNewDon.Text);
                        m_listUsers[m_nCurSelectedUserIdx].Donations.Add(newDonation);
                        RefreshList(Global.ListType.UserHistory);
                        m_bIsInfoChanged = true;

                        LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 헌금 추가 - 추가(추가 완료)");
                        LogMgr.WriteLog(LogMgr.LogType.EXE, string.Format("추가({0}, {1}, {2})", 
                            dateTimeNew.Value.ToString("yyyy-MM-dd"),
                            editNewDon.Text,
                            cboxNewType.SelectedIndex));
                    }
                    else
                    {
                        LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 헌금 추가 - 추가(추가 취소)");
                    }
                }
            }
        }

        /// <summary>
        /// 유저 히스토리 - 헌금 목록 리스트 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donListUserHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int nCurSelectedIdx = listHistory.SelectedItems[0].Index;

                if (nCurSelectedIdx >= 0)
                {
                    m_nCurSelectedHistoryIdx = nCurSelectedIdx;

                    cboxHistoryType.SelectedIndex = (int)m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].DonationType;
                    editHistoryDon.Text = m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].Money.ToString();
                    calendarHistory.SelectionStart = m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].DonationTime;
                    calendarHistory.SelectionEnd = m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].DonationTime;

                    btnHistoryMod.Enabled = true;
                    btnHistoryDel.Enabled = true;
                }
            }
            catch 
            {
                btnHistoryMod.Enabled = false;
                btnHistoryDel.Enabled = false;
            }
        }

        /// <summary>
        /// 유저 히스토리 - 수정 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donBtnUserHistoryMod_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 히스토리 - 수정(버튼 클릭)");

            if (m_nCurSelectedHistoryIdx > Global.USER_IDX_NONE)
            {
                using (InputConfirmDlg dlg = new InputConfirmDlg())
                {
                    dlg.SetTitle(Global.InputConfirmType.Modify);
                    dlg.SetData(editHistoryName.Text, calendarHistory.SelectionStart.Date, 
                        cboxHistoryType.SelectedIndex, editHistoryDon.Text);

                    DialogResult dialogResult = dlg.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 히스토리 - 수정(수정 완료)");
                        LogMgr.WriteLog(LogMgr.LogType.EXE, string.Format("수정전({0}, {1}, {2}) -> 수정후({3}, {4}, {5})",
                            m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].DonationTime.ToString("yyyy-MM-dd"),
                            m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].Money,
                            (int)m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].DonationType,
                            calendarHistory.SelectionStart.ToString("yyyy-MM-dd"),
                            editHistoryDon.Text,
                            cboxHistoryType.SelectedIndex));


                        m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].DonationType = (Global.DonationType)cboxHistoryType.SelectedIndex;
                        m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].Money = int.Parse(editHistoryDon.Text);
                        m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].DonationTime = calendarHistory.SelectionStart;
                        RefreshList(Global.ListType.UserHistory);
                        m_bIsInfoChanged = true;
                    }
                    else
                    {
                        LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 히스토리 - 수정(수정 취소)");
                    }
                }
            }
        }

        /// <summary>
        /// 유저 히스토리 - 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donBtnUserHistoryDel_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 히스토리 - 삭제(버튼 클릭)");

            if (m_nCurSelectedHistoryIdx > Global.USER_IDX_NONE)
            {
                DialogResult dialogResult = MessageBox.Show(StringResource.String_DonInput_Msg_HistoryDelete,
                    StringResource.String_Login_Msg_Warning, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 히스토리 - 삭제(삭제 완료)");
                    LogMgr.WriteLog(LogMgr.LogType.EXE, string.Format("삭제된 히스토리({0}, {1}, {2})", 
                        m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].DonationTime.ToString("yyyy-MM-dd"),
                        m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].Money,
                        (int)m_listUsers[m_nCurSelectedUserIdx].Donations[m_nCurSelectedHistoryIdx].DonationType));

                    m_listUsers[m_nCurSelectedUserIdx].Donations.RemoveAt(m_nCurSelectedHistoryIdx);
                    m_nCurSelectedHistoryIdx = Global.USER_IDX_NONE;
                    cboxHistoryType.SelectedIndex = 0;
                    editHistoryDon.Text = string.Empty;
                    RefreshList(Global.ListType.UserHistory);
                    m_bIsInfoChanged = true;
                }
                else
                {
                    LogMgr.WriteLog(LogMgr.LogType.GUI, "헌금 기입 - 유저 히스토리 - 삭제(삭제 취소)");
                }
            }
        }


        /// <summary>
        /// 유저 데이터가 변경되었는지 유무를 반환
        /// </summary>
        /// <returns>유저 데이터 변경 유무</returns>
        public bool GetUserDataChanged()
        {
            return m_bIsInfoChanged;
        }

        /// <summary>
        /// 유저 데이터 변경 상태를 변경
        /// </summary>
        /// <param name="bStatus">상태</param>
        public void SetUserDataChanged(bool bStatus)
        {
            m_bIsInfoChanged = bStatus;
        }


        /// <summary>
        /// 유저 목록 - 유저 목록 리스트 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void donListUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int nCurSelectedIdx = listUser.SelectedItems[0].Index;

                if (nCurSelectedIdx >= 0)
                {
                    btnUserSel.Enabled = true;
                }
            }
            catch
            {
                btnUserSel.Enabled = false;
            }
        }
    }
}
