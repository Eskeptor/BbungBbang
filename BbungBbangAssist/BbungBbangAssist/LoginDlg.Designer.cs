namespace BbungBbangAssist
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
            this.loginLblPasswd = new MetroFramework.Controls.MetroLabel();
            this.loginTxtPass = new MetroFramework.Controls.MetroTextBox();
            this.loginBtnLogin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // loginLblPasswd
            // 
            this.loginLblPasswd.AutoSize = true;
            this.loginLblPasswd.Location = new System.Drawing.Point(57, 176);
            this.loginLblPasswd.Name = "loginLblPasswd";
            this.loginLblPasswd.Size = new System.Drawing.Size(65, 19);
            this.loginLblPasswd.TabIndex = 2;
            this.loginLblPasswd.Text = "비밀번호";
            // 
            // loginTxtPass
            // 
            // 
            // 
            // 
            this.loginTxtPass.CustomButton.Image = null;
            this.loginTxtPass.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.loginTxtPass.CustomButton.Name = "";
            this.loginTxtPass.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.loginTxtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginTxtPass.CustomButton.TabIndex = 1;
            this.loginTxtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginTxtPass.CustomButton.UseSelectable = true;
            this.loginTxtPass.CustomButton.Visible = false;
            this.loginTxtPass.Lines = new string[0];
            this.loginTxtPass.Location = new System.Drawing.Point(138, 172);
            this.loginTxtPass.MaxLength = 32767;
            this.loginTxtPass.Name = "loginTxtPass";
            this.loginTxtPass.PasswordChar = '*';
            this.loginTxtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginTxtPass.SelectedText = "";
            this.loginTxtPass.SelectionLength = 0;
            this.loginTxtPass.SelectionStart = 0;
            this.loginTxtPass.ShortcutsEnabled = true;
            this.loginTxtPass.Size = new System.Drawing.Size(173, 29);
            this.loginTxtPass.TabIndex = 3;
            this.loginTxtPass.UseSelectable = true;
            this.loginTxtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginTxtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.loginBtnLogin.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LoginDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 392);
            this.Controls.Add(this.loginBtnLogin);
            this.Controls.Add(this.loginTxtPass);
            this.Controls.Add(this.loginLblPasswd);
            this.MaximizeBox = false;
            this.Name = "LoginDlg";
            this.Resizable = false;
            this.Text = "관리자 로그인";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel loginLblPasswd;
        private MetroFramework.Controls.MetroTextBox loginTxtPass;
        private MetroFramework.Controls.MetroButton loginBtnLogin;
    }
}