namespace BbungBbang
{
    partial class LoginDlg
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
            this.loginCBoxID = new MetroFramework.Controls.MetroComboBox();
            this.loginLblID = new MetroFramework.Controls.MetroLabel();
            this.loginLblPW = new MetroFramework.Controls.MetroLabel();
            this.loginEditPW = new MetroFramework.Controls.MetroTextBox();
            this.loginBtnLogin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // loginCBoxID
            // 
            this.loginCBoxID.FormattingEnabled = true;
            this.loginCBoxID.ItemHeight = 23;
            this.loginCBoxID.Location = new System.Drawing.Point(138, 128);
            this.loginCBoxID.Name = "loginCBoxID";
            this.loginCBoxID.Size = new System.Drawing.Size(173, 29);
            this.loginCBoxID.TabIndex = 0;
            this.loginCBoxID.UseSelectable = true;
            // 
            // loginLblID
            // 
            this.loginLblID.AutoSize = true;
            this.loginLblID.Location = new System.Drawing.Point(57, 133);
            this.loginLblID.Name = "loginLblID";
            this.loginLblID.Size = new System.Drawing.Size(37, 19);
            this.loginLblID.TabIndex = 1;
            this.loginLblID.Text = "계정";
            // 
            // loginLblPW
            // 
            this.loginLblPW.AutoSize = true;
            this.loginLblPW.Location = new System.Drawing.Point(57, 176);
            this.loginLblPW.Name = "loginLblPW";
            this.loginLblPW.Size = new System.Drawing.Size(65, 19);
            this.loginLblPW.TabIndex = 2;
            this.loginLblPW.Text = "비밀번호";
            // 
            // loginEditPW
            // 
            // 
            // 
            // 
            this.loginEditPW.CustomButton.Image = null;
            this.loginEditPW.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.loginEditPW.CustomButton.Name = "";
            this.loginEditPW.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.loginEditPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginEditPW.CustomButton.TabIndex = 1;
            this.loginEditPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginEditPW.CustomButton.UseSelectable = true;
            this.loginEditPW.CustomButton.Visible = false;
            this.loginEditPW.Lines = new string[0];
            this.loginEditPW.Location = new System.Drawing.Point(138, 172);
            this.loginEditPW.MaxLength = 32767;
            this.loginEditPW.Name = "loginEditPW";
            this.loginEditPW.PasswordChar = '*';
            this.loginEditPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginEditPW.SelectedText = "";
            this.loginEditPW.SelectionLength = 0;
            this.loginEditPW.SelectionStart = 0;
            this.loginEditPW.ShortcutsEnabled = true;
            this.loginEditPW.Size = new System.Drawing.Size(173, 29);
            this.loginEditPW.TabIndex = 3;
            this.loginEditPW.UseSelectable = true;
            this.loginEditPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginEditPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginBtnLogin
            // 
            this.loginBtnLogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.loginBtnLogin.Location = new System.Drawing.Point(57, 254);
            this.loginBtnLogin.Name = "loginBtnLogin";
            this.loginBtnLogin.Size = new System.Drawing.Size(254, 41);
            this.loginBtnLogin.TabIndex = 4;
            this.loginBtnLogin.Text = "로그인";
            this.loginBtnLogin.UseSelectable = true;
            this.loginBtnLogin.Click += new System.EventHandler(this.loginBtnLogin_Click);
            // 
            // LoginDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 392);
            this.Controls.Add(this.loginBtnLogin);
            this.Controls.Add(this.loginEditPW);
            this.Controls.Add(this.loginLblPW);
            this.Controls.Add(this.loginLblID);
            this.Controls.Add(this.loginCBoxID);
            this.MaximizeBox = false;
            this.Name = "LoginDlg";
            this.Resizable = false;
            this.Text = "로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginDlg_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox loginCBoxID;
        private MetroFramework.Controls.MetroLabel loginLblID;
        private MetroFramework.Controls.MetroLabel loginLblPW;
        private MetroFramework.Controls.MetroTextBox loginEditPW;
        private MetroFramework.Controls.MetroButton loginBtnLogin;
    }
}