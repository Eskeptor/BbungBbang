namespace BbungBbang
{
    partial class TabDonationInput
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
            this.components = new System.ComponentModel.Container();
            this.donListUsers = new MetroFramework.Controls.MetroListView();
            this.donLblUserTitle = new MetroFramework.Controls.MetroLabel();
            this.donBtnUserSel = new MetroFramework.Controls.MetroButton();
            this.donBtnUserAdd = new MetroFramework.Controls.MetroButton();
            this.donLblNewTitle = new MetroFramework.Controls.MetroLabel();
            this.donLblNewName = new MetroFramework.Controls.MetroLabel();
            this.donDateNew = new MetroFramework.Controls.MetroDateTime();
            this.donCBoxNewType = new MetroFramework.Controls.MetroComboBox();
            this.donBtnUserDel = new MetroFramework.Controls.MetroButton();
            this.donLblNewDate = new MetroFramework.Controls.MetroLabel();
            this.donLblNewDonType = new MetroFramework.Controls.MetroLabel();
            this.donEditNewDon = new MetroFramework.Controls.MetroTextBox();
            this.donLblNewDon = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.donEditNewName = new MetroFramework.Controls.MetroTextBox();
            this.donBtnNewAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.donBtnUserMod = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.donLblUserHistoryTitle = new MetroFramework.Controls.MetroLabel();
            this.donEditUserHistoryDon = new MetroFramework.Controls.MetroTextBox();
            this.donLblUserHistoryDon = new MetroFramework.Controls.MetroLabel();
            this.donLblUserHistoryDonType = new MetroFramework.Controls.MetroLabel();
            this.donCBoxUserHistoryType = new MetroFramework.Controls.MetroComboBox();
            this.donLblUserHistoryName = new MetroFramework.Controls.MetroLabel();
            this.donEditUserHistoryName = new MetroFramework.Controls.MetroTextBox();
            this.donCalendar = new System.Windows.Forms.MonthCalendar();
            this.donListUserHistory = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.donLblHourMinute = new System.Windows.Forms.Label();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.donLblDate = new System.Windows.Forms.Label();
            this.donLblPMAM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.donBtnAllSave = new MetroFramework.Controls.MetroButton();
            this.donTimerCurTime = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // donListUsers
            // 
            this.donListUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.donListUsers.FullRowSelect = true;
            this.donListUsers.Location = new System.Drawing.Point(3, 26);
            this.donListUsers.MultiSelect = false;
            this.donListUsers.Name = "donListUsers";
            this.donListUsers.OwnerDraw = true;
            this.donListUsers.Size = new System.Drawing.Size(365, 411);
            this.donListUsers.TabIndex = 0;
            this.donListUsers.UseCompatibleStateImageBehavior = false;
            this.donListUsers.UseSelectable = true;
            this.donListUsers.View = System.Windows.Forms.View.List;
            // 
            // donLblUserTitle
            // 
            this.donLblUserTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.donLblUserTitle.ForeColor = System.Drawing.Color.White;
            this.donLblUserTitle.Location = new System.Drawing.Point(3, 0);
            this.donLblUserTitle.Name = "donLblUserTitle";
            this.donLblUserTitle.Size = new System.Drawing.Size(365, 27);
            this.donLblUserTitle.TabIndex = 1;
            this.donLblUserTitle.Text = "유저 목록";
            this.donLblUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donLblUserTitle.UseCustomBackColor = true;
            this.donLblUserTitle.UseCustomForeColor = true;
            // 
            // donBtnUserSel
            // 
            this.donBtnUserSel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.donBtnUserSel.Location = new System.Drawing.Point(3, 443);
            this.donBtnUserSel.Name = "donBtnUserSel";
            this.donBtnUserSel.Size = new System.Drawing.Size(86, 44);
            this.donBtnUserSel.TabIndex = 2;
            this.donBtnUserSel.Text = "선택";
            this.donBtnUserSel.UseSelectable = true;
            this.donBtnUserSel.Click += new System.EventHandler(this.donBtnUserSel_Click);
            // 
            // donBtnUserAdd
            // 
            this.donBtnUserAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.donBtnUserAdd.Location = new System.Drawing.Point(96, 443);
            this.donBtnUserAdd.Name = "donBtnUserAdd";
            this.donBtnUserAdd.Size = new System.Drawing.Size(86, 44);
            this.donBtnUserAdd.TabIndex = 3;
            this.donBtnUserAdd.Text = "추가";
            this.donBtnUserAdd.UseSelectable = true;
            this.donBtnUserAdd.Click += new System.EventHandler(this.donBtnUserAdd_Click);
            // 
            // donLblNewTitle
            // 
            this.donLblNewTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.donLblNewTitle.ForeColor = System.Drawing.Color.White;
            this.donLblNewTitle.Location = new System.Drawing.Point(3, 0);
            this.donLblNewTitle.Name = "donLblNewTitle";
            this.donLblNewTitle.Size = new System.Drawing.Size(365, 27);
            this.donLblNewTitle.TabIndex = 4;
            this.donLblNewTitle.Text = "헌금 추가";
            this.donLblNewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donLblNewTitle.UseCustomBackColor = true;
            this.donLblNewTitle.UseCustomForeColor = true;
            // 
            // donLblNewName
            // 
            this.donLblNewName.AutoSize = true;
            this.donLblNewName.Location = new System.Drawing.Point(7, 41);
            this.donLblNewName.Name = "donLblNewName";
            this.donLblNewName.Size = new System.Drawing.Size(37, 19);
            this.donLblNewName.TabIndex = 5;
            this.donLblNewName.Text = "이름";
            // 
            // donDateNew
            // 
            this.donDateNew.Location = new System.Drawing.Point(103, 75);
            this.donDateNew.MinimumSize = new System.Drawing.Size(0, 29);
            this.donDateNew.Name = "donDateNew";
            this.donDateNew.Size = new System.Drawing.Size(257, 29);
            this.donDateNew.TabIndex = 7;
            // 
            // donCBoxNewType
            // 
            this.donCBoxNewType.FormattingEnabled = true;
            this.donCBoxNewType.ItemHeight = 23;
            this.donCBoxNewType.Location = new System.Drawing.Point(103, 115);
            this.donCBoxNewType.Name = "donCBoxNewType";
            this.donCBoxNewType.Size = new System.Drawing.Size(257, 29);
            this.donCBoxNewType.TabIndex = 8;
            this.donCBoxNewType.UseSelectable = true;
            // 
            // donBtnUserDel
            // 
            this.donBtnUserDel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.donBtnUserDel.Location = new System.Drawing.Point(282, 443);
            this.donBtnUserDel.Name = "donBtnUserDel";
            this.donBtnUserDel.Size = new System.Drawing.Size(86, 44);
            this.donBtnUserDel.TabIndex = 9;
            this.donBtnUserDel.Text = "삭제";
            this.donBtnUserDel.UseSelectable = true;
            this.donBtnUserDel.Click += new System.EventHandler(this.donBtnUserDel_Click);
            // 
            // donLblNewDate
            // 
            this.donLblNewDate.AutoSize = true;
            this.donLblNewDate.Location = new System.Drawing.Point(7, 81);
            this.donLblNewDate.Name = "donLblNewDate";
            this.donLblNewDate.Size = new System.Drawing.Size(37, 19);
            this.donLblNewDate.TabIndex = 10;
            this.donLblNewDate.Text = "날짜";
            // 
            // donLblNewDonType
            // 
            this.donLblNewDonType.AutoSize = true;
            this.donLblNewDonType.Location = new System.Drawing.Point(7, 121);
            this.donLblNewDonType.Name = "donLblNewDonType";
            this.donLblNewDonType.Size = new System.Drawing.Size(69, 19);
            this.donLblNewDonType.TabIndex = 11;
            this.donLblNewDonType.Text = "헌금 종류";
            // 
            // donEditNewDon
            // 
            // 
            // 
            // 
            this.donEditNewDon.CustomButton.Image = null;
            this.donEditNewDon.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.donEditNewDon.CustomButton.Name = "";
            this.donEditNewDon.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.donEditNewDon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.donEditNewDon.CustomButton.TabIndex = 1;
            this.donEditNewDon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.donEditNewDon.CustomButton.UseSelectable = true;
            this.donEditNewDon.CustomButton.Visible = false;
            this.donEditNewDon.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.donEditNewDon.Lines = new string[0];
            this.donEditNewDon.Location = new System.Drawing.Point(103, 155);
            this.donEditNewDon.MaxLength = 32767;
            this.donEditNewDon.Name = "donEditNewDon";
            this.donEditNewDon.PasswordChar = '\0';
            this.donEditNewDon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.donEditNewDon.SelectedText = "";
            this.donEditNewDon.SelectionLength = 0;
            this.donEditNewDon.SelectionStart = 0;
            this.donEditNewDon.ShortcutsEnabled = true;
            this.donEditNewDon.Size = new System.Drawing.Size(258, 29);
            this.donEditNewDon.TabIndex = 12;
            this.donEditNewDon.UseSelectable = true;
            this.donEditNewDon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.donEditNewDon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // donLblNewDon
            // 
            this.donLblNewDon.AutoSize = true;
            this.donLblNewDon.Location = new System.Drawing.Point(7, 160);
            this.donLblNewDon.Name = "donLblNewDon";
            this.donLblNewDon.Size = new System.Drawing.Size(37, 19);
            this.donLblNewDon.TabIndex = 13;
            this.donLblNewDon.Text = "금액";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.donEditNewName);
            this.metroPanel1.Controls.Add(this.donLblNewTitle);
            this.metroPanel1.Controls.Add(this.donBtnNewAdd);
            this.metroPanel1.Controls.Add(this.donEditNewDon);
            this.metroPanel1.Controls.Add(this.donLblNewDon);
            this.metroPanel1.Controls.Add(this.donLblNewDonType);
            this.metroPanel1.Controls.Add(this.donLblNewName);
            this.metroPanel1.Controls.Add(this.donLblNewDate);
            this.metroPanel1.Controls.Add(this.donDateNew);
            this.metroPanel1.Controls.Add(this.donCBoxNewType);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 526);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(373, 251);
            this.metroPanel1.TabIndex = 14;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // donEditNewName
            // 
            // 
            // 
            // 
            this.donEditNewName.CustomButton.Image = null;
            this.donEditNewName.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.donEditNewName.CustomButton.Name = "";
            this.donEditNewName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.donEditNewName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.donEditNewName.CustomButton.TabIndex = 1;
            this.donEditNewName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.donEditNewName.CustomButton.UseSelectable = true;
            this.donEditNewName.CustomButton.Visible = false;
            this.donEditNewName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.donEditNewName.Lines = new string[0];
            this.donEditNewName.Location = new System.Drawing.Point(103, 36);
            this.donEditNewName.MaxLength = 32767;
            this.donEditNewName.Name = "donEditNewName";
            this.donEditNewName.PasswordChar = '\0';
            this.donEditNewName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.donEditNewName.SelectedText = "";
            this.donEditNewName.SelectionLength = 0;
            this.donEditNewName.SelectionStart = 0;
            this.donEditNewName.ShortcutsEnabled = true;
            this.donEditNewName.Size = new System.Drawing.Size(258, 29);
            this.donEditNewName.TabIndex = 21;
            this.donEditNewName.UseSelectable = true;
            this.donEditNewName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.donEditNewName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // donBtnNewAdd
            // 
            this.donBtnNewAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.donBtnNewAdd.Location = new System.Drawing.Point(257, 197);
            this.donBtnNewAdd.Name = "donBtnNewAdd";
            this.donBtnNewAdd.Size = new System.Drawing.Size(103, 38);
            this.donBtnNewAdd.TabIndex = 14;
            this.donBtnNewAdd.Text = "추가";
            this.donBtnNewAdd.UseSelectable = true;
            this.donBtnNewAdd.Click += new System.EventHandler(this.donBtnNewAdd_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel13.Location = new System.Drawing.Point(3, 26);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(365, 218);
            this.metroLabel13.TabIndex = 20;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.donBtnUserMod);
            this.metroPanel2.Controls.Add(this.donLblUserTitle);
            this.metroPanel2.Controls.Add(this.donBtnUserDel);
            this.metroPanel2.Controls.Add(this.donBtnUserAdd);
            this.metroPanel2.Controls.Add(this.donListUsers);
            this.metroPanel2.Controls.Add(this.donBtnUserSel);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(12, 12);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(373, 494);
            this.metroPanel2.TabIndex = 15;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // donBtnUserMod
            // 
            this.donBtnUserMod.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.donBtnUserMod.Location = new System.Drawing.Point(189, 443);
            this.donBtnUserMod.Name = "donBtnUserMod";
            this.donBtnUserMod.Size = new System.Drawing.Size(86, 44);
            this.donBtnUserMod.TabIndex = 10;
            this.donBtnUserMod.Text = "수정";
            this.donBtnUserMod.UseSelectable = true;
            this.donBtnUserMod.Click += new System.EventHandler(this.donBtnUserMod_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.donLblUserHistoryTitle);
            this.metroPanel3.Controls.Add(this.donEditUserHistoryDon);
            this.metroPanel3.Controls.Add(this.donLblUserHistoryDon);
            this.metroPanel3.Controls.Add(this.donLblUserHistoryDonType);
            this.metroPanel3.Controls.Add(this.donCBoxUserHistoryType);
            this.metroPanel3.Controls.Add(this.donLblUserHistoryName);
            this.metroPanel3.Controls.Add(this.donEditUserHistoryName);
            this.metroPanel3.Controls.Add(this.donCalendar);
            this.metroPanel3.Controls.Add(this.donListUserHistory);
            this.metroPanel3.Controls.Add(this.metroLabel12);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(391, 12);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(613, 494);
            this.metroPanel3.TabIndex = 16;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // donLblUserHistoryTitle
            // 
            this.donLblUserHistoryTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.donLblUserHistoryTitle.ForeColor = System.Drawing.Color.White;
            this.donLblUserHistoryTitle.Location = new System.Drawing.Point(3, 0);
            this.donLblUserHistoryTitle.Name = "donLblUserHistoryTitle";
            this.donLblUserHistoryTitle.Size = new System.Drawing.Size(605, 27);
            this.donLblUserHistoryTitle.TabIndex = 2;
            this.donLblUserHistoryTitle.Text = "유저 히스토리";
            this.donLblUserHistoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donLblUserHistoryTitle.UseCustomBackColor = true;
            this.donLblUserHistoryTitle.UseCustomForeColor = true;
            // 
            // donEditUserHistoryDon
            // 
            // 
            // 
            // 
            this.donEditUserHistoryDon.CustomButton.Image = null;
            this.donEditUserHistoryDon.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.donEditUserHistoryDon.CustomButton.Name = "";
            this.donEditUserHistoryDon.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.donEditUserHistoryDon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.donEditUserHistoryDon.CustomButton.TabIndex = 1;
            this.donEditUserHistoryDon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.donEditUserHistoryDon.CustomButton.UseSelectable = true;
            this.donEditUserHistoryDon.CustomButton.Visible = false;
            this.donEditUserHistoryDon.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.donEditUserHistoryDon.Lines = new string[0];
            this.donEditUserHistoryDon.Location = new System.Drawing.Point(115, 288);
            this.donEditUserHistoryDon.MaxLength = 32767;
            this.donEditUserHistoryDon.Name = "donEditUserHistoryDon";
            this.donEditUserHistoryDon.PasswordChar = '\0';
            this.donEditUserHistoryDon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.donEditUserHistoryDon.SelectedText = "";
            this.donEditUserHistoryDon.SelectionLength = 0;
            this.donEditUserHistoryDon.SelectionStart = 0;
            this.donEditUserHistoryDon.ShortcutsEnabled = true;
            this.donEditUserHistoryDon.Size = new System.Drawing.Size(263, 29);
            this.donEditUserHistoryDon.TabIndex = 16;
            this.donEditUserHistoryDon.UseSelectable = true;
            this.donEditUserHistoryDon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.donEditUserHistoryDon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // donLblUserHistoryDon
            // 
            this.donLblUserHistoryDon.AutoSize = true;
            this.donLblUserHistoryDon.Location = new System.Drawing.Point(13, 293);
            this.donLblUserHistoryDon.Name = "donLblUserHistoryDon";
            this.donLblUserHistoryDon.Size = new System.Drawing.Size(37, 19);
            this.donLblUserHistoryDon.TabIndex = 17;
            this.donLblUserHistoryDon.Text = "금액";
            // 
            // donLblUserHistoryDonType
            // 
            this.donLblUserHistoryDonType.AutoSize = true;
            this.donLblUserHistoryDonType.Location = new System.Drawing.Point(13, 253);
            this.donLblUserHistoryDonType.Name = "donLblUserHistoryDonType";
            this.donLblUserHistoryDonType.Size = new System.Drawing.Size(69, 19);
            this.donLblUserHistoryDonType.TabIndex = 15;
            this.donLblUserHistoryDonType.Text = "헌금 종류";
            // 
            // donCBoxUserHistoryType
            // 
            this.donCBoxUserHistoryType.FormattingEnabled = true;
            this.donCBoxUserHistoryType.ItemHeight = 23;
            this.donCBoxUserHistoryType.Location = new System.Drawing.Point(115, 248);
            this.donCBoxUserHistoryType.Name = "donCBoxUserHistoryType";
            this.donCBoxUserHistoryType.Size = new System.Drawing.Size(263, 29);
            this.donCBoxUserHistoryType.TabIndex = 14;
            this.donCBoxUserHistoryType.UseSelectable = true;
            // 
            // donLblUserHistoryName
            // 
            this.donLblUserHistoryName.AutoSize = true;
            this.donLblUserHistoryName.Location = new System.Drawing.Point(13, 212);
            this.donLblUserHistoryName.Name = "donLblUserHistoryName";
            this.donLblUserHistoryName.Size = new System.Drawing.Size(37, 19);
            this.donLblUserHistoryName.TabIndex = 7;
            this.donLblUserHistoryName.Text = "이름";
            // 
            // donEditUserHistoryName
            // 
            // 
            // 
            // 
            this.donEditUserHistoryName.CustomButton.Image = null;
            this.donEditUserHistoryName.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.donEditUserHistoryName.CustomButton.Name = "";
            this.donEditUserHistoryName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.donEditUserHistoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.donEditUserHistoryName.CustomButton.TabIndex = 1;
            this.donEditUserHistoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.donEditUserHistoryName.CustomButton.UseSelectable = true;
            this.donEditUserHistoryName.CustomButton.Visible = false;
            this.donEditUserHistoryName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.donEditUserHistoryName.Lines = new string[0];
            this.donEditUserHistoryName.Location = new System.Drawing.Point(115, 208);
            this.donEditUserHistoryName.MaxLength = 32767;
            this.donEditUserHistoryName.Name = "donEditUserHistoryName";
            this.donEditUserHistoryName.PasswordChar = '\0';
            this.donEditUserHistoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.donEditUserHistoryName.SelectedText = "";
            this.donEditUserHistoryName.SelectionLength = 0;
            this.donEditUserHistoryName.SelectionStart = 0;
            this.donEditUserHistoryName.ShortcutsEnabled = true;
            this.donEditUserHistoryName.Size = new System.Drawing.Size(263, 29);
            this.donEditUserHistoryName.TabIndex = 8;
            this.donEditUserHistoryName.UseSelectable = true;
            this.donEditUserHistoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.donEditUserHistoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // donCalendar
            // 
            this.donCalendar.Location = new System.Drawing.Point(389, 27);
            this.donCalendar.Name = "donCalendar";
            this.donCalendar.TabIndex = 4;
            // 
            // donListUserHistory
            // 
            this.donListUserHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.donListUserHistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.donListUserHistory.FullRowSelect = true;
            this.donListUserHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.donListUserHistory.Location = new System.Drawing.Point(3, 27);
            this.donListUserHistory.MultiSelect = false;
            this.donListUserHistory.Name = "donListUserHistory";
            this.donListUserHistory.OwnerDraw = true;
            this.donListUserHistory.Size = new System.Drawing.Size(375, 162);
            this.donListUserHistory.TabIndex = 3;
            this.donListUserHistory.UseCompatibleStateImageBehavior = false;
            this.donListUserHistory.UseSelectable = true;
            this.donListUserHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "날짜";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "헌금 종류";
            this.columnHeader2.Width = 150;
            // 
            // metroLabel12
            // 
            this.metroLabel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel12.Location = new System.Drawing.Point(3, 26);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(605, 461);
            this.metroLabel12.TabIndex = 20;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroLabel8);
            this.metroPanel4.Controls.Add(this.metroTextBox3);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(391, 526);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(613, 251);
            this.metroPanel4.TabIndex = 17;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(3, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(604, 27);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "오늘 작업 로그";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(389, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(213, 213);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(3, 26);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Multiline = true;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(605, 218);
            this.metroTextBox3.TabIndex = 6;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // donLblHourMinute
            // 
            this.donLblHourMinute.Font = new System.Drawing.Font("Arial", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donLblHourMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.donLblHourMinute.Location = new System.Drawing.Point(76, 6);
            this.donLblHourMinute.Name = "donLblHourMinute";
            this.donLblHourMinute.Size = new System.Drawing.Size(183, 69);
            this.donLblHourMinute.TabIndex = 18;
            this.donLblHourMinute.Text = "99:99";
            // 
            // metroLabel14
            // 
            this.metroLabel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel14.Location = new System.Drawing.Point(0, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(261, 121);
            this.metroLabel14.TabIndex = 19;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.donLblDate);
            this.metroPanel5.Controls.Add(this.donLblPMAM);
            this.metroPanel5.Controls.Add(this.donLblHourMinute);
            this.metroPanel5.Controls.Add(this.metroLabel14);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(1010, 12);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(264, 127);
            this.metroPanel5.TabIndex = 20;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // donLblDate
            // 
            this.donLblDate.AutoSize = true;
            this.donLblDate.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donLblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.donLblDate.Location = new System.Drawing.Point(17, 76);
            this.donLblDate.Name = "donLblDate";
            this.donLblDate.Size = new System.Drawing.Size(231, 34);
            this.donLblDate.TabIndex = 21;
            this.donLblDate.Text = "2020년 12월 22일";
            // 
            // donLblPMAM
            // 
            this.donLblPMAM.AutoSize = true;
            this.donLblPMAM.BackColor = System.Drawing.Color.Transparent;
            this.donLblPMAM.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donLblPMAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.donLblPMAM.Location = new System.Drawing.Point(3, 24);
            this.donLblPMAM.Name = "donLblPMAM";
            this.donLblPMAM.Size = new System.Drawing.Size(86, 46);
            this.donLblPMAM.TabIndex = 21;
            this.donLblPMAM.Text = "오후";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1201, 734);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "테스트";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // donBtnAllSave
            // 
            this.donBtnAllSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.donBtnAllSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.donBtnAllSave.ForeColor = System.Drawing.Color.White;
            this.donBtnAllSave.Location = new System.Drawing.Point(1010, 145);
            this.donBtnAllSave.Name = "donBtnAllSave";
            this.donBtnAllSave.Size = new System.Drawing.Size(258, 56);
            this.donBtnAllSave.TabIndex = 22;
            this.donBtnAllSave.Text = "저장";
            this.donBtnAllSave.UseCustomBackColor = true;
            this.donBtnAllSave.UseCustomForeColor = true;
            this.donBtnAllSave.UseSelectable = true;
            this.donBtnAllSave.Click += new System.EventHandler(this.donBtnAllSave_Click);
            // 
            // donTimerCurTime
            // 
            this.donTimerCurTime.Tick += new System.EventHandler(this.donTimerCurTime_Tick);
            // 
            // TabDonationInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1280, 935);
            this.ControlBox = false;
            this.Controls.Add(this.donBtnAllSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabDonationInput";
            this.Text = "TabDonationInput";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TabDonationInput_FormClosing);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView donListUsers;
        private MetroFramework.Controls.MetroLabel donLblUserTitle;
        private MetroFramework.Controls.MetroButton donBtnUserSel;
        private MetroFramework.Controls.MetroButton donBtnUserAdd;
        private MetroFramework.Controls.MetroLabel donLblNewTitle;
        private MetroFramework.Controls.MetroLabel donLblNewName;
        private MetroFramework.Controls.MetroDateTime donDateNew;
        private MetroFramework.Controls.MetroComboBox donCBoxNewType;
        private MetroFramework.Controls.MetroButton donBtnUserDel;
        private MetroFramework.Controls.MetroLabel donLblNewDate;
        private MetroFramework.Controls.MetroLabel donLblNewDonType;
        private MetroFramework.Controls.MetroTextBox donEditNewDon;
        private MetroFramework.Controls.MetroLabel donLblNewDon;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton donBtnNewAdd;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroListView donListUserHistory;
        private MetroFramework.Controls.MetroLabel donLblUserHistoryTitle;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox donEditUserHistoryDon;
        private MetroFramework.Controls.MetroLabel donLblUserHistoryDon;
        private MetroFramework.Controls.MetroLabel donLblUserHistoryDonType;
        private MetroFramework.Controls.MetroComboBox donCBoxUserHistoryType;
        private MetroFramework.Controls.MetroLabel donLblUserHistoryName;
        private MetroFramework.Controls.MetroTextBox donEditUserHistoryName;
        private System.Windows.Forms.MonthCalendar donCalendar;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.Label donLblHourMinute;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.Label donLblDate;
        private System.Windows.Forms.Label donLblPMAM;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton donBtnAllSave;
        private System.Windows.Forms.Timer donTimerCurTime;
        private MetroFramework.Controls.MetroButton donBtnUserMod;
        private MetroFramework.Controls.MetroTextBox donEditNewName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}