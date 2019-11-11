using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Modify,     // 계정 수정
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
                case ConfirmDlgType.Create:
                    this.Text = Properties.Resources.String_Confirm_Create_Title;
                    confirmLblText.Text = Properties.Resources.String_Confirm_PasswdOneMore;
                    confirmEditPasswd.Enabled = true;
                    confirmBtnOK.Text = Properties.Resources.String_Confirm_Btn_OK;
                    confirmBtnCancel.Text = Properties.Resources.String_Confirm_Btn_Cancel;
                    break;
                case ConfirmDlgType.Modify:
                    this.Text = Properties.Resources.String_Confirm_Modify_Title;
                    confirmLblText.Text = Properties.Resources.String_Confirm_PasswdOneMore;
                    confirmEditPasswd.Enabled = true;
                    confirmBtnOK.Text = Properties.Resources.String_Confirm_Btn_OK;
                    confirmBtnCancel.Text = Properties.Resources.String_Confirm_Btn_Cancel;
                    break;
                case ConfirmDlgType.Delete:
                    this.Text = Properties.Resources.String_Confirm_Delete_Title;
                    confirmLblText.Text = Properties.Resources.String_Confirm_DeleteOK;
                    confirmEditPasswd.Enabled = false;
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
        }

        /// <summary>
        /// m_eDlgType가 ConfirmDlgType.Create, ConfirmDlgType.Modify 일때 비밀번호 비교를 위한 비밀번호 설정
        /// </summary>
        /// <param name="strPasswd">비밀번호</param>
        public void SetConfirmPassword(string strPasswd)
        {
            m_strConfirmPasswd = strPasswd;
        }
        
        private void confirmBtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirmEditPasswd.Text))
            {
                MessageBox.Show(Properties.Resources.String_Main_Msg_NonePW, Properties.Resources.String_Main_Msg_Warning);
                return;
            }

            // 에러 처리하기
            if (string.IsNullOrEmpty(m_strConfirmPasswd))
            {
                return;
            }

            // Confirm 다이얼로그 띄우기
        }
    }
}
