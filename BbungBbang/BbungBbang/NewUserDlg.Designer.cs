namespace BbungBbang
{
    partial class NewUserDlg
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
            this.newUserLblName = new MetroFramework.Controls.MetroLabel();
            this.newUserEditName = new MetroFramework.Controls.MetroTextBox();
            this.newUserBtnOk = new MetroFramework.Controls.MetroButton();
            this.newUserBtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // newUserLblName
            // 
            this.newUserLblName.AutoSize = true;
            this.newUserLblName.Location = new System.Drawing.Point(24, 64);
            this.newUserLblName.Name = "newUserLblName";
            this.newUserLblName.Size = new System.Drawing.Size(37, 19);
            this.newUserLblName.TabIndex = 0;
            this.newUserLblName.Text = "이름";
            // 
            // newUserEditName
            // 
            // 
            // 
            // 
            this.newUserEditName.CustomButton.Image = null;
            this.newUserEditName.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.newUserEditName.CustomButton.Name = "";
            this.newUserEditName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newUserEditName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newUserEditName.CustomButton.TabIndex = 1;
            this.newUserEditName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newUserEditName.CustomButton.UseSelectable = true;
            this.newUserEditName.CustomButton.Visible = false;
            this.newUserEditName.Lines = new string[] {
        "metroTextBox1"};
            this.newUserEditName.Location = new System.Drawing.Point(85, 63);
            this.newUserEditName.MaxLength = 32767;
            this.newUserEditName.Name = "newUserEditName";
            this.newUserEditName.PasswordChar = '\0';
            this.newUserEditName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newUserEditName.SelectedText = "";
            this.newUserEditName.SelectionLength = 0;
            this.newUserEditName.SelectionStart = 0;
            this.newUserEditName.ShortcutsEnabled = true;
            this.newUserEditName.Size = new System.Drawing.Size(275, 23);
            this.newUserEditName.TabIndex = 1;
            this.newUserEditName.Text = "metroTextBox1";
            this.newUserEditName.UseSelectable = true;
            this.newUserEditName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newUserEditName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newUserBtnOk
            // 
            this.newUserBtnOk.Location = new System.Drawing.Point(141, 106);
            this.newUserBtnOk.Name = "newUserBtnOk";
            this.newUserBtnOk.Size = new System.Drawing.Size(106, 34);
            this.newUserBtnOk.TabIndex = 2;
            this.newUserBtnOk.Text = "확인";
            this.newUserBtnOk.UseSelectable = true;
            this.newUserBtnOk.Click += new System.EventHandler(this.newUserBtnOk_Click);
            // 
            // newUserBtnCancel
            // 
            this.newUserBtnCancel.Location = new System.Drawing.Point(253, 106);
            this.newUserBtnCancel.Name = "newUserBtnCancel";
            this.newUserBtnCancel.Size = new System.Drawing.Size(106, 34);
            this.newUserBtnCancel.TabIndex = 3;
            this.newUserBtnCancel.Text = "취소";
            this.newUserBtnCancel.UseSelectable = true;
            this.newUserBtnCancel.Click += new System.EventHandler(this.newUserBtnCancel_Click);
            // 
            // NewUserDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 157);
            this.Controls.Add(this.newUserBtnCancel);
            this.Controls.Add(this.newUserBtnOk);
            this.Controls.Add(this.newUserEditName);
            this.Controls.Add(this.newUserLblName);
            this.Name = "NewUserDlg";
            this.Resizable = false;
            this.Text = "유저 추가";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel newUserLblName;
        private MetroFramework.Controls.MetroTextBox newUserEditName;
        private MetroFramework.Controls.MetroButton newUserBtnOk;
        private MetroFramework.Controls.MetroButton newUserBtnCancel;
    }
}