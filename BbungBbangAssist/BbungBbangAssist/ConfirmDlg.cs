using BbungBbangLog;
using System;
using System.Windows.Forms;

namespace BbungBbangAssist
{
    public partial class ConfirmDlg : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Confirm 다이얼로그의 타입
        /// </summary>
        public enum ConfirmDlgType
        {
            Create,     // 계정 생성
            Modify,     // 계정 수정 (사용 안함)
            Delete,     // 계정 삭제
        }

        private ConfirmDlgType m_eDlgType = ConfirmDlgType.Create;
        private string m_strConfirmPasswd = string.Empty;

        public ConfirmDlg()
        {
            InitializeComponent();

            InitControls();
        }

        /// <summary>
        /// 컨트롤 초기화 메소드
        /// </summary>
        private void InitControls()
        {
            switch (m_eDlgType)
            {
                case ConfirmDlgType.Create:     // 계정 생성
                    this.Text = Properties.Resources.String_Confirm_Create_Title;
                    confirmLblText.Text = Properties.Resources.String_Confirm_PasswdOneMore;
                    confirmEditPasswd.Visible = true;
                    confirmBtnOK.Text = Properties.Resources.String_Confirm_Btn_OK;
                    confirmBtnCancel.Text = Properties.Resources.String_Confirm_Btn_Cancel;
                    break;
                case ConfirmDlgType.Delete:     // 계정 삭제
                    this.Text = Properties.Resources.String_Confirm_Delete_Title;
                    confirmLblText.Text = Properties.Resources.String_Confirm_DeleteOK;
                    confirmEditPasswd.Visible = false;
                    confirmBtnOK.Text = Properties.Resources.String_Confirm_Btn_Yes;
                    confirmBtnCancel.Text = Properties.Resources.String_Confirm_Btn_No;
                    break;
            }
        }

        /// <summary>
        /// Confirm 다이얼로그의 타입을 설정하는 메소드
        /// </summary>
        /// <param name="dlgType">다이얼로그 타입(enum ConfirmDlgType)</param>
        public void SetConfirmDlgType(ConfirmDlgType dlgType)
        {
            m_eDlgType = dlgType;
            InitControls();
        }

        /// <summary>
        /// m_eDlgType가 ConfirmDlgType.Create, ConfirmDlgType.Modify 일때 비밀번호 비교를 위한 비밀번호 설정
        /// </summary>
        /// <param name="strPasswd">비밀번호</param>
        public void SetConfirmPassword(string strPasswd)
        {
            m_strConfirmPasswd = strPasswd;
        }

        /// <summary>
        /// 확인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmBtnOK_Click(object sender, EventArgs e)
        {
            switch (m_eDlgType)
            {
                case ConfirmDlgType.Create:     // 계정 생성
                    CreateActionOK();
                    break;
                case ConfirmDlgType.Modify:     // 계정 수정 (사용 안함)
                    break;
                case ConfirmDlgType.Delete:     // 계정 삭제
                    DeleteActionOK();
                    break;
            }
        }

        /// <summary>
        /// 취소 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmBtnCancel_Click(object sender, EventArgs e)
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "Confirm 화면 - 취소(버튼 클릭)");
            Close();
        }

        private void CreateActionOK()
        {
            LogMgr.WriteLog(LogMgr.LogType.GUI, "Confirm 화면 - 생성(버튼 클릭)");

            if (string.IsNullOrEmpty(confirmEditPasswd.Text))
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "Confirm 화면 - 생성 실패(확인용 비밀번호 빈칸)");

                MessageBox.Show(Properties.Resources.String_Main_Msg_NonePW, Properties.Resources.String_Main_Msg_Warning);
                return;
            }

            if (string.IsNullOrEmpty(m_strConfirmPasswd))
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "Confirm 화면 - 생성 실패(Send Passwd Null)");

                MessageBox.Show(Properties.Resources.String_Confirm_PasswdOneMore, Properties.Resources.String_Main_Msg_Warning);
                return;
            }

            if (m_strConfirmPasswd.CompareTo(confirmEditPasswd.Text) == 0)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                LogMgr.WriteLog(LogMgr.LogType.EXE, "Confirm 화면 - 생성 실패(비밀번호 일치 실패)");

                MessageBox.Show(Properties.Resources.String_Main_Msg_NonePW, Properties.Resources.String_Main_Msg_Warning);
                return;
            }
        }

        private void DeleteActionOK()
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Confirm 폼이 Show 될때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmDlg_Shown(object sender, EventArgs e)
        {
            string strLog = string.Format("Confirm 화면 - Confirm 폼 생성({0})", m_eDlgType);
            LogMgr.WriteLog(LogMgr.LogType.GUI, strLog);
        }

        /// <summary>
        /// Confirm 폼이 Closing 될때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            string strLog = string.Format("Confirm 화면 - Confirm 폼 종료({0})", m_eDlgType);
            LogMgr.WriteLog(LogMgr.LogType.GUI, strLog);
        }
    }
}
