using BbungBbangCrypt;
using BbungBbangLog;
using BbungBbangXml;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BbungBbangAssist
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private LoginDlg m_dlgLogin = null;                 // 로그인 다이얼로그
        private List<string> m_listAccount = null;          // 계정 리스트

        private string m_strReceiveData = string.Empty;     // 다른 폼으로부터 받은 데이터

        public Form1()
        {
            InitializeComponent();

            InitControls();
        }

        /// <summary>
        /// 컨트롤 초기화 메소드
        /// </summary>
        private void InitControls()
        {
            // ==================================================================
            // 컨트롤의 Text를 Properties의 String에서 받아옴
            this.Text = Properties.Resources.String_Main_Title;
            mainLblList.Text = Properties.Resources.String_Main_List_Title;
            mainLblInfo.Text = Properties.Resources.String_Main_Info_Title;
            mainLblID.Text = Properties.Resources.String_Main_Info_ID;
            mainLblPasswd.Text = Properties.Resources.String_Main_Info_PW;
            mainBtnCreate.Text = Properties.Resources.String_Main_Btn_Create;
            mainBtnEdit.Text = Properties.Resources.String_Main_Btn_Edit;
            mainBtnDelete.Text = Properties.Resources.String_Main_Btn_Delete;
            // ==================================================================


            // ==================================================================
            // 로그인 목록으로부터 데이터를 불러와 콤보박스에 넣어줌
            m_listAccount = new List<string>();
            int nResult = XmlMgr.LoadAccount(ref m_listAccount);
            if (nResult == (int)XmlMgr.LoadResult.Success)
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "메인 - 유저 정보 불러오기(성공)");
                ResetList();
            }
            else
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "메인 - 유저 정보 불러오기(실패)");
                MessageBox.Show(Properties.Resources.String_Main_Msg_UserLoadFail, Properties.Resources.String_Main_Msg_Warning);
            }
            // ==================================================================


            // ==================================================================
            // 버튼 상태 변경
            mainBtnEdit.Enabled = false;
            mainBtnDelete.Enabled = false;
            // ==================================================================


            // ==================================================================
            m_dlgLogin = new LoginDlg();
            m_dlgLogin.SetParent(this);
            m_dlgLogin.ShowDialog();
            Hide();
            // ==================================================================
        }

        /// <summary>
        /// 메인 리스트를 초기화하는 메소드
        /// m_listAccount의 내용으로 다시 채워넣는다.
        /// </summary>
        private void ResetList()
        {
            int nSize = m_listAccount.Count / 2;

            mainList.Items.Clear();
            mainList.BeginUpdate();
            for (int i = 0; i < nSize; i++)
            {
                ListViewItem listViewItem = new ListViewItem(m_listAccount[i * 2]);
                mainList.Items.Add(listViewItem);
            }
            mainList.EndUpdate();
        }

        /// <summary>
        /// 다른 폼으로터 데이터를 받는 메소드
        /// 받은 데이터는 m_strReceiveData에 저장됨
        /// </summary>
        /// <param name="strData">데이터</param>
        public void SetReceiveData(string strData)
        {
            m_strReceiveData = strData;
        }

        /// <summary>
        /// 폼 종료시 수행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "메인 - 메인폼 종료");

            if (m_dlgLogin != null)
                m_dlgLogin.Dispose();
        }

        /// <summary>
        /// 생성 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainBtnCreate_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "메인 - 생성(버튼 클릭)");

            if (string.IsNullOrEmpty(mainEditID.Text))
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "메인 - 생성 실패(빈 계정명)");

                MessageBox.Show(Properties.Resources.String_Main_Msg_NoneID, Properties.Resources.String_Main_Msg_Warning);
                mainEditID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(mainEditPasswd.Text))
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "메인 - 생성 실패(빈 비밀번호)");

                MessageBox.Show(Properties.Resources.String_Main_Msg_NonePW, Properties.Resources.String_Main_Msg_Warning);
                mainEditPasswd.Focus();
                return;
            }

            foreach (string strID in m_listAccount)
            {
                if (strID.CompareTo(mainEditID.Text) == 0)
                {
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "메인 - 생성 실패(이미 생성된 계정명)");

                    MessageBox.Show(Properties.Resources.String_Main_Msg_SameID, Properties.Resources.String_Main_Msg_Warning);
                    mainEditID.Focus();
                    return;
                }
            }

            using (ConfirmDlg confirmDlg = new ConfirmDlg())
            {
                confirmDlg.SetConfirmDlgType(ConfirmDlg.ConfirmDlgType.Create);
                confirmDlg.SetConfirmPassword(mainEditPasswd.Text);

                DialogResult dialogResult = confirmDlg.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string strLog = string.Format("메인 - 생성 성공(생성된 계정:{0})", mainEditID.Text);
                    LogMgr.WriteLog(LogMgr.LogType.EXE, strLog);

                    string strCryptPW = Crypto.Encrypt(mainEditPasswd.Text);
                    m_listAccount.Add(mainEditID.Text);
                    m_listAccount.Add(strCryptPW);
                    XmlMgr.SaveAccount(m_listAccount);

                    mainEditID.Clear();
                    mainEditPasswd.Clear();

                    ResetList();
                }
                else
                {
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "메인 - 생성 취소");
                }
            }
        }

        /// <summary>
        /// 메인 리스트 - 선택 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "메인 - 리스트 아이템 클릭");

            try
            {
                int nCurSelIdx = mainList.SelectedItems[0].Index;

                mainEditID.Text = m_listAccount[nCurSelIdx * 2];

                mainBtnEdit.Enabled = true;
                mainBtnDelete.Enabled = true;
            }
            catch (Exception)
            {
                mainBtnEdit.Enabled = false;
                mainBtnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainBtnDelete_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "메인 - 삭제(버튼 클릭)");

            using (ConfirmDlg confirmDlg = new ConfirmDlg())
            {
                confirmDlg.SetConfirmDlgType(ConfirmDlg.ConfirmDlgType.Delete);

                DialogResult dialogResult = confirmDlg.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    int nCurSelIdx = mainList.SelectedItems[0].Index;
                    string strDelID = m_listAccount[nCurSelIdx];

                    m_listAccount.RemoveRange(nCurSelIdx, 2);
                    XmlMgr.SaveAccount(m_listAccount);
                    ResetList();

                    string strLog = string.Format("메인 - 삭제 완료(ID: {0}", strDelID);
                    LogMgr.WriteLog(LogMgr.LogType.EXE, strLog);
                }
                else
                {
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "메인 - 삭제 취소");
                }
            }
        }

        /// <summary>
        /// 수정 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainBtnEdit_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "메인 - 수정(버튼 클릭)");

            using (ModifyDlg modifyDlg = new ModifyDlg())
            {
                int nCurSel = mainList.SelectedItems[0].Index * 2;
                modifyDlg.SetMainForm(this);
                modifyDlg.SetTargetInfo(m_listAccount[nCurSel], nCurSel, m_listAccount[nCurSel + 1]);

                DialogResult dialogResult = modifyDlg.ShowDialog();

                if (dialogResult == DialogResult.OK &&
                    string.IsNullOrEmpty(m_strReceiveData) == false)
                {
                    string[] arrStrData = m_strReceiveData.Split(',');
                    if (arrStrData.Length == 3)
                    {
                        int nIdx = int.Parse(arrStrData[0]);
                        m_listAccount[nIdx] = arrStrData[1];
                        m_listAccount[nIdx + 1] = arrStrData[2];
                        m_strReceiveData = string.Empty;

                        XmlMgr.SaveAccount(m_listAccount);
                        ResetList();

                        string strLog = string.Format("메인 - 수정 완료(ID: {0}", arrStrData[1]);
                        LogMgr.WriteLog(LogMgr.LogType.EXE, strLog);
                    }
                }
                else
                {
                    LogMgr.WriteLog(LogMgr.LogType.EXE, "메인 - 수정 취소");
                }
            }
        }

        /// <summary>
        /// 메인 폼이 Show 되었을 시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "메인 - 메인폼 생성");
        }
    }
}
