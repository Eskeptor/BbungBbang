using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using BbungBbangXml;

namespace BbungBbangAssist
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        LoginDlg m_dlgLogin = null;
        List<string> m_listAccount = null;

        public Form1()
        {
            InitializeComponent();

            InitControls();

            
        }

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

            }
            // ==================================================================


            // ==================================================================
            m_dlgLogin = new LoginDlg();
            m_dlgLogin.SetParent(this);
            m_dlgLogin.ShowDialog();
            Hide();
            // ==================================================================
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_dlgLogin != null)
                m_dlgLogin.Dispose();
        }

        private void mainBtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mainEditID.Text))
            {
                MessageBox.Show(Properties.Resources.String_Main_Msg_NoneID, Properties.Resources.String_Main_Msg_Warning);
                return;
            }

            if (string.IsNullOrEmpty(mainEditPasswd.Text))
            {
                MessageBox.Show(Properties.Resources.String_Main_Msg_NonePW, Properties.Resources.String_Main_Msg_Warning);
                return;
            }
        }
    }
}
