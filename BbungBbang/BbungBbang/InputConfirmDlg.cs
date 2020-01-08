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
    public partial class InputConfirmDlg : MetroFramework.Forms.MetroForm
    {
        public InputConfirmDlg()
        {
            InitializeComponent();

            InitControls();
        }

        private void InitControls()
        {
            inputConfirmBtnOk.Text = StringResource.String_Popup_Ok;
            inputConfirmBtnCancel.Text = StringResource.String_Popup_Cancel;
        }

        public void SetTitle(Global.InputConfirmType eType)
        {
            switch (eType)
            {
                case Global.InputConfirmType.Modify:
                    Text = StringResource.String_InputConfirm_Modify_Title;
                    break;
                case Global.InputConfirmType.Add:
                    Text = StringResource.String_InputConfirm_Add_Title;
                    break;
            }
        }

        public void SetData(string strName, DateTime dateTime, Global.DonationType eDonationType, string strDon)
        {
            inputConfirmLblName.Text = StringResource.String_InputConfirm_Name + strName;
            inputConfirmLblDate.Text = StringResource.String_InputConfirm_Date + dateTime.ToString("yyyy년 MM월 dd일");
            inputConfirmLblDonType.Text = StringResource.String_InputConfirm_DonType + eDonationType.ToString();
            inputConfirmLblDon.Text = StringResource.String_InputConfirm_Don + strDon;
        }

        public void SetData(string strName, DateTime dateTime, int nDonationType, string strDon)
        {
            inputConfirmLblName.Text = StringResource.String_InputConfirm_Name + strName;
            inputConfirmLblDate.Text = StringResource.String_InputConfirm_Date + dateTime.ToString("yyyy년 MM월 dd일");
            inputConfirmLblDon.Text = StringResource.String_InputConfirm_Don + strDon;

            // Global.DonationType 과 매칭함
            switch (nDonationType)
            {
                case 0:     // 십일조
                    inputConfirmLblDonType.Text = StringResource.String_InputConfirm_DonType + "십일조";
                    break;
                case 1:     // 주정 헌금
                    inputConfirmLblDonType.Text = StringResource.String_InputConfirm_DonType + "주정 헌금";
                    break;
                case 2:     // 감사 헌금
                    inputConfirmLblDonType.Text = StringResource.String_InputConfirm_DonType + "감사 헌금";
                    break;
                case 3:     // 선교 헌금
                    inputConfirmLblDonType.Text = StringResource.String_InputConfirm_DonType + "선교 헌금";
                    break;
                case 4:     // 건축 헌금
                    inputConfirmLblDonType.Text = StringResource.String_InputConfirm_DonType + "건축 헌금";
                    break;
                case 5:     // 기타 헌금
                    inputConfirmLblDonType.Text = StringResource.String_InputConfirm_DonType + "기타 헌금";
                    break;
                case 6:     // 절기 헌금
                    inputConfirmLblDonType.Text = StringResource.String_InputConfirm_DonType + "절기 헌금";
                    break;
            }
        }

        /// <summary>
        /// 확인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputConfirmBtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// 취소 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputConfirmBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
