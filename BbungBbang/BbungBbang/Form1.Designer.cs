namespace BbungBbang
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTab = new MetroFramework.Controls.MetroTabControl();
            this.mainTabMain = new MetroFramework.Controls.MetroTabPage();
            this.mainTabInput = new MetroFramework.Controls.MetroTabPage();
            this.mainTabReview = new MetroFramework.Controls.MetroTabPage();
            this.mainTabSettings = new MetroFramework.Controls.MetroTabPage();
            this.mainBtnBack = new MetroFramework.Controls.MetroTile();
            this.mainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTab.Controls.Add(this.mainTabMain);
            this.mainTab.Controls.Add(this.mainTabInput);
            this.mainTab.Controls.Add(this.mainTabReview);
            this.mainTab.Controls.Add(this.mainTabSettings);
            this.mainTab.ItemSize = new System.Drawing.Size(2000, 1);
            this.mainTab.Location = new System.Drawing.Point(0, 63);
            this.mainTab.Multiline = true;
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(1280, 935);
            this.mainTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTab.Style = MetroFramework.MetroColorStyle.White;
            this.mainTab.TabIndex = 0;
            this.mainTab.UseSelectable = true;
            // 
            // mainTabMain
            // 
            this.mainTabMain.HorizontalScrollbarBarColor = true;
            this.mainTabMain.HorizontalScrollbarHighlightOnWheel = false;
            this.mainTabMain.HorizontalScrollbarSize = 10;
            this.mainTabMain.Location = new System.Drawing.Point(4, 8);
            this.mainTabMain.Name = "mainTabMain";
            this.mainTabMain.Size = new System.Drawing.Size(1272, 923);
            this.mainTabMain.TabIndex = 3;
            this.mainTabMain.Text = "mainTabMain";
            this.mainTabMain.VerticalScrollbarBarColor = true;
            this.mainTabMain.VerticalScrollbarHighlightOnWheel = false;
            this.mainTabMain.VerticalScrollbarSize = 10;
            // 
            // mainTabInput
            // 
            this.mainTabInput.HorizontalScrollbarBarColor = true;
            this.mainTabInput.HorizontalScrollbarHighlightOnWheel = false;
            this.mainTabInput.HorizontalScrollbarSize = 10;
            this.mainTabInput.Location = new System.Drawing.Point(4, 8);
            this.mainTabInput.Name = "mainTabInput";
            this.mainTabInput.Size = new System.Drawing.Size(1272, 923);
            this.mainTabInput.TabIndex = 0;
            this.mainTabInput.Text = "mainTabInput";
            this.mainTabInput.VerticalScrollbarBarColor = true;
            this.mainTabInput.VerticalScrollbarHighlightOnWheel = false;
            this.mainTabInput.VerticalScrollbarSize = 10;
            // 
            // mainTabReview
            // 
            this.mainTabReview.HorizontalScrollbarBarColor = true;
            this.mainTabReview.HorizontalScrollbarHighlightOnWheel = false;
            this.mainTabReview.HorizontalScrollbarSize = 10;
            this.mainTabReview.Location = new System.Drawing.Point(4, 8);
            this.mainTabReview.Name = "mainTabReview";
            this.mainTabReview.Size = new System.Drawing.Size(1272, 923);
            this.mainTabReview.TabIndex = 1;
            this.mainTabReview.Text = "mainTabReview";
            this.mainTabReview.VerticalScrollbarBarColor = true;
            this.mainTabReview.VerticalScrollbarHighlightOnWheel = false;
            this.mainTabReview.VerticalScrollbarSize = 10;
            // 
            // mainTabSettings
            // 
            this.mainTabSettings.HorizontalScrollbarBarColor = true;
            this.mainTabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.mainTabSettings.HorizontalScrollbarSize = 10;
            this.mainTabSettings.Location = new System.Drawing.Point(4, 8);
            this.mainTabSettings.Name = "mainTabSettings";
            this.mainTabSettings.Size = new System.Drawing.Size(1272, 923);
            this.mainTabSettings.TabIndex = 2;
            this.mainTabSettings.Text = "mainTabSettings";
            this.mainTabSettings.VerticalScrollbarBarColor = true;
            this.mainTabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.mainTabSettings.VerticalScrollbarSize = 10;
            // 
            // mainBtnBack
            // 
            this.mainBtnBack.ActiveControl = null;
            this.mainBtnBack.Location = new System.Drawing.Point(222, 22);
            this.mainBtnBack.Name = "mainBtnBack";
            this.mainBtnBack.Size = new System.Drawing.Size(34, 35);
            this.mainBtnBack.TabIndex = 1;
            this.mainBtnBack.TileImage = ((System.Drawing.Image)(resources.GetObject("mainBtnBack.TileImage")));
            this.mainBtnBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainBtnBack.UseSelectable = true;
            this.mainBtnBack.UseTileImage = true;
            this.mainBtnBack.Click += new System.EventHandler(this.mainBtnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.mainBtnBack);
            this.Controls.Add(this.mainTab);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mainTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mainTab;
        private MetroFramework.Controls.MetroTabPage mainTabInput;
        private MetroFramework.Controls.MetroTabPage mainTabReview;
        private MetroFramework.Controls.MetroTabPage mainTabSettings;
        private MetroFramework.Controls.MetroTabPage mainTabMain;
        private MetroFramework.Controls.MetroTile mainBtnBack;
    }
}

