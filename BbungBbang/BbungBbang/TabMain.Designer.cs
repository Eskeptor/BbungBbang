namespace BbungBbang
{
    partial class TabMain
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
            this.mainBtnInput = new MetroFramework.Controls.MetroTile();
            this.mainBtnReview = new MetroFramework.Controls.MetroTile();
            this.mainBtnSettings = new MetroFramework.Controls.MetroTile();
            this.mainBtnExit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mainBtnInput
            // 
            this.mainBtnInput.ActiveControl = null;
            this.mainBtnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.mainBtnInput.Location = new System.Drawing.Point(178, 302);
            this.mainBtnInput.Name = "mainBtnInput";
            this.mainBtnInput.Size = new System.Drawing.Size(424, 308);
            this.mainBtnInput.TabIndex = 0;
            this.mainBtnInput.Text = "헌금 기입";
            this.mainBtnInput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mainBtnInput.UseCustomBackColor = true;
            this.mainBtnInput.UseSelectable = true;
            // 
            // mainBtnReview
            // 
            this.mainBtnReview.ActiveControl = null;
            this.mainBtnReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.mainBtnReview.Location = new System.Drawing.Point(608, 302);
            this.mainBtnReview.Name = "mainBtnReview";
            this.mainBtnReview.Size = new System.Drawing.Size(428, 148);
            this.mainBtnReview.TabIndex = 1;
            this.mainBtnReview.Text = "헌금 현황";
            this.mainBtnReview.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mainBtnReview.UseCustomBackColor = true;
            this.mainBtnReview.UseSelectable = true;
            // 
            // mainBtnSettings
            // 
            this.mainBtnSettings.ActiveControl = null;
            this.mainBtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.mainBtnSettings.Location = new System.Drawing.Point(608, 456);
            this.mainBtnSettings.Name = "mainBtnSettings";
            this.mainBtnSettings.Size = new System.Drawing.Size(211, 154);
            this.mainBtnSettings.TabIndex = 2;
            this.mainBtnSettings.Text = "설정";
            this.mainBtnSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mainBtnSettings.UseCustomBackColor = true;
            this.mainBtnSettings.UseSelectable = true;
            // 
            // mainBtnExit
            // 
            this.mainBtnExit.ActiveControl = null;
            this.mainBtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.mainBtnExit.Location = new System.Drawing.Point(825, 456);
            this.mainBtnExit.Name = "mainBtnExit";
            this.mainBtnExit.Size = new System.Drawing.Size(211, 154);
            this.mainBtnExit.TabIndex = 3;
            this.mainBtnExit.Text = "종료";
            this.mainBtnExit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mainBtnExit.UseCustomBackColor = true;
            this.mainBtnExit.UseSelectable = true;
            this.mainBtnExit.Click += new System.EventHandler(this.mainBtnExit_Click);
            // 
            // TabMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 935);
            this.Controls.Add(this.mainBtnExit);
            this.Controls.Add(this.mainBtnSettings);
            this.Controls.Add(this.mainBtnReview);
            this.Controls.Add(this.mainBtnInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabMain";
            this.Text = "TabMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TabMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mainBtnInput;
        private MetroFramework.Controls.MetroTile mainBtnReview;
        private MetroFramework.Controls.MetroTile mainBtnSettings;
        private MetroFramework.Controls.MetroTile mainBtnExit;
    }
}