namespace BbungBbangAssist
{
    partial class ConfirmDlg
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
            this.confirmLblText = new MetroFramework.Controls.MetroLabel();
            this.confirmEditPasswd = new MetroFramework.Controls.MetroTextBox();
            this.confirmBtnOK = new MetroFramework.Controls.MetroButton();
            this.confirmBtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // confirmLblText
            // 
            this.confirmLblText.AutoSize = true;
            this.confirmLblText.Location = new System.Drawing.Point(24, 64);
            this.confirmLblText.Name = "confirmLblText";
            this.confirmLblText.Size = new System.Drawing.Size(93, 19);
            this.confirmLblText.TabIndex = 0;
            this.confirmLblText.Text = "confirmLblText";
            // 
            // confirmEditPasswd
            // 
            // 
            // 
            // 
            this.confirmEditPasswd.CustomButton.Image = null;
            this.confirmEditPasswd.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.confirmEditPasswd.CustomButton.Name = "";
            this.confirmEditPasswd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirmEditPasswd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmEditPasswd.CustomButton.TabIndex = 1;
            this.confirmEditPasswd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmEditPasswd.CustomButton.UseSelectable = true;
            this.confirmEditPasswd.CustomButton.Visible = false;
            this.confirmEditPasswd.Lines = new string[0];
            this.confirmEditPasswd.Location = new System.Drawing.Point(23, 92);
            this.confirmEditPasswd.MaxLength = 32767;
            this.confirmEditPasswd.Name = "confirmEditPasswd";
            this.confirmEditPasswd.PasswordChar = '\0';
            this.confirmEditPasswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmEditPasswd.SelectedText = "";
            this.confirmEditPasswd.SelectionLength = 0;
            this.confirmEditPasswd.SelectionStart = 0;
            this.confirmEditPasswd.ShortcutsEnabled = true;
            this.confirmEditPasswd.Size = new System.Drawing.Size(293, 23);
            this.confirmEditPasswd.TabIndex = 1;
            this.confirmEditPasswd.UseSelectable = true;
            this.confirmEditPasswd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmEditPasswd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confirmBtnOK
            // 
            this.confirmBtnOK.Location = new System.Drawing.Point(23, 132);
            this.confirmBtnOK.Name = "confirmBtnOK";
            this.confirmBtnOK.Size = new System.Drawing.Size(126, 28);
            this.confirmBtnOK.TabIndex = 2;
            this.confirmBtnOK.Text = "confirmBtnOK";
            this.confirmBtnOK.UseSelectable = true;
            this.confirmBtnOK.Click += new System.EventHandler(this.confirmBtnOK_Click);
            // 
            // confirmBtnCancel
            // 
            this.confirmBtnCancel.Location = new System.Drawing.Point(190, 132);
            this.confirmBtnCancel.Name = "confirmBtnCancel";
            this.confirmBtnCancel.Size = new System.Drawing.Size(126, 28);
            this.confirmBtnCancel.TabIndex = 3;
            this.confirmBtnCancel.Text = "confirmBtnCancel";
            this.confirmBtnCancel.UseSelectable = true;
            this.confirmBtnCancel.Click += new System.EventHandler(this.confirmBtnCancel_Click);
            // 
            // ConfirmDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 181);
            this.Controls.Add(this.confirmBtnCancel);
            this.Controls.Add(this.confirmBtnOK);
            this.Controls.Add(this.confirmEditPasswd);
            this.Controls.Add(this.confirmLblText);
            this.MaximizeBox = false;
            this.Name = "ConfirmDlg";
            this.Resizable = false;
            this.Text = "ConfirmDlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel confirmLblText;
        private MetroFramework.Controls.MetroTextBox confirmEditPasswd;
        private MetroFramework.Controls.MetroButton confirmBtnOK;
        private MetroFramework.Controls.MetroButton confirmBtnCancel;
    }
}