using BbungBbangCrypt;
using BbungBbangLog;
using System;
using System.Windows.Forms;

namespace BbungBbangAssist
{
    public partial class ModifyDlg : MetroFramework.Forms.MetroForm
    {
        private string m_strTargetID = string.Empty;
        private string m_strTargetPW = string.Empty;
        private int m_nTargetIndex = 0;
        private Form1 m_frmMain = null;

        public ModifyDlg()
        {
            InitializeComponent();

            InitControls();
        }

        /// <summary>
        /// 컨트롤 초기화 메소드
        /// </summary>
        private void InitControls()
        {
            modifyLblID.Text = Properties.Resources.String_Modify_ID;
            modifyLblPrevPW.Text = Properties.Resources.String_Modify_Prev_PW;
            modifyLblPW.Text = Properties.Resources.String_Modify_PW;
            modifyLblPW2.Text = Properties.Resources.String_Modify_PW_Re;
            modifyBtnOK.Text = Properties.Resources.String_Modify_Btn_OK;
            modifyBtnCancel.Text = Properties.Resources.String_Modify_Btn_Cancel;

            modifyEditID.Text = m_strTargetID;

            modifyEditPrevPW.Focus();
        }

        /// <summary>
        /// 선택한 계정의 정보를 설정하는 메소드
        /// </summary>
        /// <param name="strID">계정명</param>
        /// <param name="nIdx">현 계정의 리스트의 인덱스</param>
        /// <param name="strPW">비밀번호</param>
        public void SetTargetInfo(string strID, int nIdx, string strPW)
        {
            m_strTargetID = strID;
            m_nTargetIndex = nIdx;
            m_strTargetPW = strPW;

            InitControls();
        }

        /// <summary>
        /// 메인 폼과 연결하는 메소드
        /// </summary>
        /// <param name="frmMain">메인폼</param>
        public void SetMainForm(Form1 frmMain)
        {
            m_frmMain = frmMain;
        }

        /// <summary>
        /// 확인(수정) 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyBtnOK_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "수정 - 수정(버튼 클릭)");

            // 계정명이 비어있는지 확인
            // 별다른 오류가 없으면 비어있지 않음
            if (string.IsNullOrEmpty(modifyEditID.Text))
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "수정 - 수정 실패(빈 계정명)");

                MessageBox.Show(Properties.Resources.String_Modify_Msg_NoneID, Properties.Resources.String_Main_Msg_Warning);
                modifyLblID.Focus();
                return;
            }

            // 이전 비밀번호가 비어있는지 확인
            if (string.IsNullOrEmpty(modifyEditPrevPW.Text))
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "수정 - 수정 실패(빈 비밀번호)");

                MessageBox.Show(Properties.Resources.String_Modify_Msg_IncorrectPrevPW, Properties.Resources.String_Main_Msg_Warning);
                modifyEditPrevPW.Focus();
                return;
            }

            // 이전 비밀번호가 올바른 비밀번호인지 확인
            string strEncrypt = Crypto.Encrypt(modifyEditPrevPW.Text);
            if (m_strTargetPW.CompareTo(strEncrypt) != 0)
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "수정 - 수정 실패(올바르지 않는 원본 비밀번호)");

                MessageBox.Show(Properties.Resources.String_Modify_Msg_IncorrectPrevPW, Properties.Resources.String_Main_Msg_Warning);
                modifyEditPrevPW.Focus();
                return;
            }

            // 새로운 비밀번호가 비어있는지 확인
            if (string.IsNullOrEmpty(modifyEditPW.Text))
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "수정 - 수정 실패(빈 새 비밀번호)");

                MessageBox.Show(Properties.Resources.String_Modify_Msg_NonePW, Properties.Resources.String_Main_Msg_Warning);
                modifyEditPW.Focus();
                return;
            }

            // 비밀번호 확인이 비어있는지 확인
            if (string.IsNullOrEmpty(modifyEditPW2.Text))
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "수정 - 수정 실패(새 비밀번호 확인 실패)");

                MessageBox.Show(Properties.Resources.String_Modify_PW_Re, Properties.Resources.String_Main_Msg_Warning);
                modifyEditPW2.Focus();
                return;
            }

            if (m_frmMain != null)
            {
                // 데이터를 보내는 방식
                // "해당 데이터의 리스트 상의 인덱스","변경 대상의 계정명","변경된 비밀번호"
                string strNewData = string.Format("{0},{1},{2}", m_nTargetIndex, m_strTargetID, Crypto.Encrypt(modifyEditPW.Text));
                m_frmMain.SetReceiveData(strNewData);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void modifyBtnCancel_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "수정 - 취소(버튼 클릭)");

            Close();
        }
    }
}
