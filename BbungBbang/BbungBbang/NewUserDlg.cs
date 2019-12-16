using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringResource = BbungBbang.Properties.Resources;

namespace BbungBbang
{
    public partial class NewUserDlg : MetroFramework.Forms.MetroForm
    {
        private TabDonationInput m_parentDlg = null;
        public NewUserDlg()
        {
            InitializeComponent();

            InitControls();
        }

        /// <summary>
        /// 컨트롤 초기화
        /// </summary>
        private void InitControls()
        {
            // ==========================================================================
            // 컨트롤 텍스트 리소스 연결
            this.Text = StringResource.String_NewUser_Title;
            newUserLblName.Text = StringResource.String_NewUser_Name_Title;
            newUserBtnOk.Text = StringResource.String_Popup_Ok;
            newUserBtnCancel.Text = StringResource.String_Popup_Cancel;
            newUserEditName.Text = string.Empty;
            // ==========================================================================
        }

        /// <summary>
        /// 확인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newUserBtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newUserEditName.Text) == false)
            {
                if (m_parentDlg != null)
                {
                    string strData = string.Format("{0}", newUserEditName.Text);
                    m_parentDlg.SetReturnData(strData);
                    this.DialogResult = DialogResult.OK;

                    Close();
                }
            }
            else
                MessageBox.Show(StringResource.String_NewUser_Msg_Err_NoName, StringResource.String_Login_Msg_Warning);
        }

        /// <summary>
        /// 취소 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newUserBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 부모 다이얼로그를 설정
        /// </summary>
        /// <param name="parent"></param>
        public void SetParentDlg(TabDonationInput parent)
        {
            m_parentDlg = parent;
        }
    }
}
