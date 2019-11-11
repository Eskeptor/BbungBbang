namespace BbungBbangAssist
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("테스트1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("테스트2");
            this.mainList = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainLblList = new MetroFramework.Controls.MetroLabel();
            this.mainLblID = new MetroFramework.Controls.MetroLabel();
            this.mainEditID = new MetroFramework.Controls.MetroTextBox();
            this.mainEditPasswd = new MetroFramework.Controls.MetroTextBox();
            this.mainLblPasswd = new MetroFramework.Controls.MetroLabel();
            this.mainLblInfo = new MetroFramework.Controls.MetroLabel();
            this.mainBtnCreate = new MetroFramework.Controls.MetroButton();
            this.mainBtnDelete = new MetroFramework.Controls.MetroButton();
            this.mainBtnEdit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mainList
            // 
            this.mainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.mainList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainList.FullRowSelect = true;
            this.mainList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.mainList.Location = new System.Drawing.Point(23, 118);
            this.mainList.MultiSelect = false;
            this.mainList.Name = "mainList";
            this.mainList.OwnerDraw = true;
            this.mainList.Size = new System.Drawing.Size(307, 212);
            this.mainList.TabIndex = 0;
            this.mainList.UseCompatibleStateImageBehavior = false;
            this.mainList.UseSelectable = true;
            this.mainList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "계정명";
            this.columnHeader1.Width = 303;
            // 
            // mainLblList
            // 
            this.mainLblList.AutoSize = true;
            this.mainLblList.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainLblList.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mainLblList.Location = new System.Drawing.Point(23, 76);
            this.mainLblList.Name = "mainLblList";
            this.mainLblList.Size = new System.Drawing.Size(89, 25);
            this.mainLblList.TabIndex = 1;
            this.mainLblList.Text = "계정 목록";
            // 
            // mainLblID
            // 
            this.mainLblID.AutoSize = true;
            this.mainLblID.Location = new System.Drawing.Point(351, 119);
            this.mainLblID.Name = "mainLblID";
            this.mainLblID.Size = new System.Drawing.Size(51, 19);
            this.mainLblID.TabIndex = 2;
            this.mainLblID.Text = "계정명";
            // 
            // mainEditID
            // 
            // 
            // 
            // 
            this.mainEditID.CustomButton.Image = null;
            this.mainEditID.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.mainEditID.CustomButton.Name = "";
            this.mainEditID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mainEditID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mainEditID.CustomButton.TabIndex = 1;
            this.mainEditID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mainEditID.CustomButton.UseSelectable = true;
            this.mainEditID.CustomButton.Visible = false;
            this.mainEditID.Lines = new string[0];
            this.mainEditID.Location = new System.Drawing.Point(440, 119);
            this.mainEditID.MaxLength = 32767;
            this.mainEditID.Name = "mainEditID";
            this.mainEditID.PasswordChar = '\0';
            this.mainEditID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mainEditID.SelectedText = "";
            this.mainEditID.SelectionLength = 0;
            this.mainEditID.SelectionStart = 0;
            this.mainEditID.ShortcutsEnabled = true;
            this.mainEditID.Size = new System.Drawing.Size(152, 23);
            this.mainEditID.TabIndex = 3;
            this.mainEditID.UseSelectable = true;
            this.mainEditID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mainEditID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mainEditPasswd
            // 
            // 
            // 
            // 
            this.mainEditPasswd.CustomButton.Image = null;
            this.mainEditPasswd.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.mainEditPasswd.CustomButton.Name = "";
            this.mainEditPasswd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mainEditPasswd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mainEditPasswd.CustomButton.TabIndex = 1;
            this.mainEditPasswd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mainEditPasswd.CustomButton.UseSelectable = true;
            this.mainEditPasswd.CustomButton.Visible = false;
            this.mainEditPasswd.Lines = new string[0];
            this.mainEditPasswd.Location = new System.Drawing.Point(440, 156);
            this.mainEditPasswd.MaxLength = 32767;
            this.mainEditPasswd.Name = "mainEditPasswd";
            this.mainEditPasswd.PasswordChar = '\0';
            this.mainEditPasswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mainEditPasswd.SelectedText = "";
            this.mainEditPasswd.SelectionLength = 0;
            this.mainEditPasswd.SelectionStart = 0;
            this.mainEditPasswd.ShortcutsEnabled = true;
            this.mainEditPasswd.Size = new System.Drawing.Size(152, 23);
            this.mainEditPasswd.TabIndex = 4;
            this.mainEditPasswd.UseSelectable = true;
            this.mainEditPasswd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mainEditPasswd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mainLblPasswd
            // 
            this.mainLblPasswd.AutoSize = true;
            this.mainLblPasswd.Location = new System.Drawing.Point(351, 156);
            this.mainLblPasswd.Name = "mainLblPasswd";
            this.mainLblPasswd.Size = new System.Drawing.Size(65, 19);
            this.mainLblPasswd.TabIndex = 5;
            this.mainLblPasswd.Text = "비밀번호";
            // 
            // mainLblInfo
            // 
            this.mainLblInfo.AutoSize = true;
            this.mainLblInfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainLblInfo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mainLblInfo.Location = new System.Drawing.Point(352, 76);
            this.mainLblInfo.Name = "mainLblInfo";
            this.mainLblInfo.Size = new System.Drawing.Size(89, 25);
            this.mainLblInfo.TabIndex = 6;
            this.mainLblInfo.Text = "계정 정보";
            // 
            // mainBtnCreate
            // 
            this.mainBtnCreate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mainBtnCreate.Location = new System.Drawing.Point(352, 213);
            this.mainBtnCreate.Name = "mainBtnCreate";
            this.mainBtnCreate.Size = new System.Drawing.Size(241, 35);
            this.mainBtnCreate.TabIndex = 7;
            this.mainBtnCreate.Text = "생성";
            this.mainBtnCreate.UseSelectable = true;
            this.mainBtnCreate.Click += new System.EventHandler(this.mainBtnCreate_Click);
            // 
            // mainBtnDelete
            // 
            this.mainBtnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mainBtnDelete.Location = new System.Drawing.Point(352, 295);
            this.mainBtnDelete.Name = "mainBtnDelete";
            this.mainBtnDelete.Size = new System.Drawing.Size(241, 35);
            this.mainBtnDelete.TabIndex = 8;
            this.mainBtnDelete.Text = "삭제";
            this.mainBtnDelete.UseSelectable = true;
            // 
            // mainBtnEdit
            // 
            this.mainBtnEdit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mainBtnEdit.Location = new System.Drawing.Point(352, 254);
            this.mainBtnEdit.Name = "mainBtnEdit";
            this.mainBtnEdit.Size = new System.Drawing.Size(241, 35);
            this.mainBtnEdit.TabIndex = 9;
            this.mainBtnEdit.Text = "수정";
            this.mainBtnEdit.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 356);
            this.Controls.Add(this.mainBtnEdit);
            this.Controls.Add(this.mainBtnDelete);
            this.Controls.Add(this.mainBtnCreate);
            this.Controls.Add(this.mainLblInfo);
            this.Controls.Add(this.mainLblPasswd);
            this.Controls.Add(this.mainEditPasswd);
            this.Controls.Add(this.mainEditID);
            this.Controls.Add(this.mainLblID);
            this.Controls.Add(this.mainLblList);
            this.Controls.Add(this.mainList);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "계정 관리";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView mainList;
        private MetroFramework.Controls.MetroLabel mainLblList;
        private MetroFramework.Controls.MetroLabel mainLblID;
        private MetroFramework.Controls.MetroTextBox mainEditID;
        private MetroFramework.Controls.MetroTextBox mainEditPasswd;
        private MetroFramework.Controls.MetroLabel mainLblPasswd;
        private MetroFramework.Controls.MetroLabel mainLblInfo;
        private MetroFramework.Controls.MetroButton mainBtnCreate;
        private MetroFramework.Controls.MetroButton mainBtnDelete;
        private MetroFramework.Controls.MetroButton mainBtnEdit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

