namespace BbungBbangAssist
{
    partial class Login
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.loginTxtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(57, 176);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "비밀번호";
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
            this.loginTxtPass.Lines = new string[] {
        "metroTextBox1"};
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
            this.loginTxtPass.Text = "metroTextBox1";
            this.loginTxtPass.UseSelectable = true;
            this.loginTxtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginTxtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(57, 254);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(254, 41);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "로그인";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 392);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.loginTxtPass);
            this.Controls.Add(this.metroLabel2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "관리자 로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox loginTxtPass;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}