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
using BbungBbangCrypt;

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
                ResetList();
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
        /// 폼 종료시 수행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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

            using (ConfirmDlg confirmDlg = new ConfirmDlg())
            {
                confirmDlg.SetConfirmDlgType(ConfirmDlg.ConfirmDlgType.Create);
                confirmDlg.SetConfirmPassword(mainEditPasswd.Text);

                DialogResult dialogResult = confirmDlg.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string strCryptPW = Crypto.Encrypt(mainEditPasswd.Text);
                    m_listAccount.Add(mainEditID.Text);
                    m_listAccount.Add(strCryptPW);
                    XmlMgr.SaveAccount(m_listAccount);

                    mainEditID.Clear();
                    mainEditPasswd.Clear();

                    ResetList();
                }
            }
        }

        private void mainList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
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

        private void mainBtnDelete_Click(object sender, EventArgs e)
        {
            using (ConfirmDlg confirmDlg = new ConfirmDlg())
            {
                confirmDlg.SetConfirmDlgType(ConfirmDlg.ConfirmDlgType.Delete);

                DialogResult dialogResult = confirmDlg.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    int nCurSelIdx = mainList.SelectedItems[0].Index;

                    m_listAccount.RemoveRange(nCurSelIdx, 2);
                    XmlMgr.SaveAccount(m_listAccount); 
                    ResetList();
                }
            }
        }
    }
}
