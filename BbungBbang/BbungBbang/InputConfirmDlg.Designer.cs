namespace BbungBbang
{
    partial class InputConfirmDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputConfirmLblName = new MetroFramework.Controls.MetroLabel();
            this.inputConfirmLblDate = new MetroFramework.Controls.MetroLabel();
            this.inputConfirmLblDonType = new MetroFramework.Controls.MetroLabel();
            this.inputConfirmLblDon = new MetroFramework.Controls.MetroLabel();
            this.inputConfirmBtnOk = new MetroFramework.Controls.MetroButton();
            this.inputConfirmBtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // inputConfirmLblName
            // 
            this.inputConfirmLblName.AutoSize = true;
            this.inputConfirmLblName.Location = new System.Drawing.Point(24, 74);
            this.inputConfirmLblName.Name = "inputConfirmLblName";
            this.inputConfirmLblName.Size = new System.Drawing.Size(90, 19);
            this.inputConfirmLblName.TabIndex = 0;
            this.inputConfirmLblName.Text = "이름 : 홍길동";
            // 
            // inputConfirmLblDate
            // 
            this.inputConfirmLblDate.AutoSize = true;
            this.inputConfirmLblDate.Location = new System.Drawing.Point(24, 108);
            this.inputConfirmLblDate.Name = "inputConfirmLblDate";
            this.inputConfirmLblDate.Size = new System.Drawing.Size(162, 19);
            this.inputConfirmLblDate.TabIndex = 1;
            this.inputConfirmLblDate.Text = "날짜 : XXXX년 XX월 XX일";
            // 
            // inputConfirmLblDonType
            // 
            this.inputConfirmLblDonType.AutoSize = true;
            this.inputConfirmLblDonType.Location = new System.Drawing.Point(24, 142);
            this.inputConfirmLblDonType.Name = "inputConfirmLblDonType";
            this.inputConfirmLblDonType.Size = new System.Drawing.Size(112, 19);
            this.inputConfirmLblDonType.TabIndex = 2;
            this.inputConfirmLblDonType.Text = "헌금 종류 : XXXX";
            // 
            // inputConfirmLblDon
            // 
            this.inputConfirmLblDon.AutoSize = true;
            this.inputConfirmLblDon.Location = new System.Drawing.Point(24, 176);
            this.inputConfirmLblDon.Name = "inputConfirmLblDon";
            this.inputConfirmLblDon.Size = new System.Drawing.Size(144, 19);
            this.inputConfirmLblDon.TabIndex = 3;
            this.inputConfirmLblDon.Text = "금액 : XXXXXXXXXXXX";
            // 
            // inputConfirmBtnOk
            // 
            this.inputConfirmBtnOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.inputConfirmBtnOk.Location = new System.Drawing.Point(23, 218);
            this.inputConfirmBtnOk.Name = "inputConfirmBtnOk";
            this.inputConfirmBtnOk.Size = new System.Drawing.Size(78, 49);
            this.inputConfirmBtnOk.TabIndex = 4;
            this.inputConfirmBtnOk.Text = "확인";
            this.inputConfirmBtnOk.UseSelectable = true;
            this.inputConfirmBtnOk.Click += new System.EventHandler(this.inputConfirmBtnOk_Click);
            // 
            // inputConfirmBtnCancel
            // 
            this.inputConfirmBtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.inputConfirmBtnCancel.Location = new System.Drawing.Point(120, 218);
            this.inputConfirmBtnCancel.Name = "inputConfirmBtnCancel";
            this.inputConfirmBtnCancel.Size = new System.Drawing.Size(78, 49);
            this.inputConfirmBtnCancel.TabIndex = 5;
            this.inputConfirmBtnCancel.Text = "취소";
            this.inputConfirmBtnCancel.UseSelectable = true;
            this.inputConfirmBtnCancel.Click += new System.EventHandler(this.inputConfirmBtnCancel_Click);
            // 
            // InputConfirmDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 289);
            this.Controls.Add(this.inputConfirmBtnCancel);
            this.Controls.Add(this.inputConfirmBtnOk);
            this.Controls.Add(this.inputConfirmLblDon);
            this.Controls.Add(this.inputConfirmLblDonType);
            this.Controls.Add(this.inputConfirmLblDate);
            this.Controls.Add(this.inputConfirmLblName);
            this.Name = "InputConfirmDlg";
            this.Resizable = false;
            this.Text = "InputConfirmDlg";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel inputConfirmLblName;
        private MetroFramework.Controls.MetroLabel inputConfirmLblDate;
        private MetroFramework.Controls.MetroLabel inputConfirmLblDonType;
        private MetroFramework.Controls.MetroLabel inputConfirmLblDon;
        private MetroFramework.Controls.MetroButton inputConfirmBtnOk;
        private MetroFramework.Controls.MetroButton inputConfirmBtnCancel;
    }
}