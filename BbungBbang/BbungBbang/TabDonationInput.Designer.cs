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
            this.listUser = new MetroFramework.Controls.MetroListView();
            this.lblUserTitle = new MetroFramework.Controls.MetroLabel();
            this.btnUserSel = new MetroFramework.Controls.MetroButton();
            this.btnUserAdd = new MetroFramework.Controls.MetroButton();
            this.lblNewTitle = new MetroFramework.Controls.MetroLabel();
            this.lblNewName = new MetroFramework.Controls.MetroLabel();
            this.dateTimeNew = new MetroFramework.Controls.MetroDateTime();
            this.cboxNewType = new MetroFramework.Controls.MetroComboBox();
            this.btnUserDel = new MetroFramework.Controls.MetroButton();
            this.lblNewDate = new MetroFramework.Controls.MetroLabel();
            this.lblNewDonType = new MetroFramework.Controls.MetroLabel();
            this.editNewDon = new MetroFramework.Controls.MetroTextBox();
            this.lblNewDon = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.editNewName = new MetroFramework.Controls.MetroTextBox();
            this.btnNewAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnUserMod = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnHistoryDel = new MetroFramework.Controls.MetroButton();
            this.btnHistoryMod = new MetroFramework.Controls.MetroButton();
            this.lblHistoryTitle = new MetroFramework.Controls.MetroLabel();
            this.editHistoryDon = new MetroFramework.Controls.MetroTextBox();
            this.lblHistoryDon = new MetroFramework.Controls.MetroLabel();
            this.lblHistoryDonType = new MetroFramework.Controls.MetroLabel();
            this.cboxHistoryType = new MetroFramework.Controls.MetroComboBox();
            this.lblHistoryName = new MetroFramework.Controls.MetroLabel();
            this.editHistoryName = new MetroFramework.Controls.MetroTextBox();
            this.calendarHistory = new System.Windows.Forms.MonthCalendar();
            this.listHistory = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.editTodayLog = new MetroFramework.Controls.MetroTextBox();
            this.lblHourMinute = new System.Windows.Forms.Label();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPMAM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAllSave = new MetroFramework.Controls.MetroButton();
            this.donTimerCurTime = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // listUser
            // 
            this.listUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listUser.FullRowSelect = true;
            this.listUser.Location = new System.Drawing.Point(3, 26);
            this.listUser.MultiSelect = false;
            this.listUser.Name = "listUser";
            this.listUser.OwnerDraw = true;
            this.listUser.Size = new System.Drawing.Size(365, 411);
            this.listUser.TabIndex = 0;
            this.listUser.UseCompatibleStateImageBehavior = false;
            this.listUser.UseSelectable = true;
            this.listUser.UseStyleColors = true;
            this.listUser.View = System.Windows.Forms.View.List;
            this.listUser.SelectedIndexChanged += new System.EventHandler(this.donListUsers_SelectedIndexChanged);
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lblUserTitle.ForeColor = System.Drawing.Color.White;
            this.lblUserTitle.Location = new System.Drawing.Point(3, 0);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(365, 27);
            this.lblUserTitle.TabIndex = 1;
            this.lblUserTitle.Text = "유저 목록";
            this.lblUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserTitle.UseCustomBackColor = true;
            this.lblUserTitle.UseCustomForeColor = true;
            // 
            // btnUserSel
            // 
            this.btnUserSel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUserSel.Location = new System.Drawing.Point(3, 443);
            this.btnUserSel.Name = "btnUserSel";
            this.btnUserSel.Size = new System.Drawing.Size(86, 44);
            this.btnUserSel.TabIndex = 2;
            this.btnUserSel.Text = "선택";
            this.btnUserSel.UseSelectable = true;
            this.btnUserSel.Click += new System.EventHandler(this.donBtnUserSel_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUserAdd.Location = new System.Drawing.Point(96, 443);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(86, 44);
            this.btnUserAdd.TabIndex = 3;
            this.btnUserAdd.Text = "추가";
            this.btnUserAdd.UseSelectable = true;
            this.btnUserAdd.Click += new System.EventHandler(this.donBtnUserAdd_Click);
            // 
            // lblNewTitle
            // 
            this.lblNewTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lblNewTitle.ForeColor = System.Drawing.Color.White;
            this.lblNewTitle.Location = new System.Drawing.Point(3, 0);
            this.lblNewTitle.Name = "lblNewTitle";
            this.lblNewTitle.Size = new System.Drawing.Size(365, 27);
            this.lblNewTitle.TabIndex = 4;
            this.lblNewTitle.Text = "헌금 추가";
            this.lblNewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNewTitle.UseCustomBackColor = true;
            this.lblNewTitle.UseCustomForeColor = true;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(7, 41);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(37, 19);
            this.lblNewName.TabIndex = 5;
            this.lblNewName.Text = "이름";
            // 
            // dateTimeNew
            // 
            this.dateTimeNew.Location = new System.Drawing.Point(103, 75);
            this.dateTimeNew.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeNew.Name = "dateTimeNew";
            this.dateTimeNew.Size = new System.Drawing.Size(257, 29);
            this.dateTimeNew.TabIndex = 7;
            // 
            // cboxNewType
            // 
            this.cboxNewType.FormattingEnabled = true;
            this.cboxNewType.ItemHeight = 23;
            this.cboxNewType.Location = new System.Drawing.Point(103, 115);
            this.cboxNewType.Name = "cboxNewType";
            this.cboxNewType.Size = new System.Drawing.Size(257, 29);
            this.cboxNewType.TabIndex = 8;
            this.cboxNewType.UseSelectable = true;
            // 
            // btnUserDel
            // 
            this.btnUserDel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUserDel.Location = new System.Drawing.Point(282, 443);
            this.btnUserDel.Name = "btnUserDel";
            this.btnUserDel.Size = new System.Drawing.Size(86, 44);
            this.btnUserDel.TabIndex = 9;
            this.btnUserDel.Text = "삭제";
            this.btnUserDel.UseSelectable = true;
            this.btnUserDel.Click += new System.EventHandler(this.donBtnUserDel_Click);
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.Location = new System.Drawing.Point(7, 81);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(37, 19);
            this.lblNewDate.TabIndex = 10;
            this.lblNewDate.Text = "날짜";
            // 
            // lblNewDonType
            // 
            this.lblNewDonType.AutoSize = true;
            this.lblNewDonType.Location = new System.Drawing.Point(7, 121);
            this.lblNewDonType.Name = "lblNewDonType";
            this.lblNewDonType.Size = new System.Drawing.Size(69, 19);
            this.lblNewDonType.TabIndex = 11;
            this.lblNewDonType.Text = "헌금 종류";
            // 
            // editNewDon
            // 
            // 
            // 
            // 
            this.editNewDon.CustomButton.Image = null;
            this.editNewDon.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.editNewDon.CustomButton.Name = "";
            this.editNewDon.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.editNewDon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editNewDon.CustomButton.TabIndex = 1;
            this.editNewDon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editNewDon.CustomButton.UseSelectable = true;
            this.editNewDon.CustomButton.Visible = false;
            this.editNewDon.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.editNewDon.Lines = new string[0];
            this.editNewDon.Location = new System.Drawing.Point(103, 155);
            this.editNewDon.MaxLength = 32767;
            this.editNewDon.Name = "editNewDon";
            this.editNewDon.PasswordChar = '\0';
            this.editNewDon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editNewDon.SelectedText = "";
            this.editNewDon.SelectionLength = 0;
            this.editNewDon.SelectionStart = 0;
            this.editNewDon.ShortcutsEnabled = true;
            this.editNewDon.Size = new System.Drawing.Size(258, 29);
            this.editNewDon.TabIndex = 12;
            this.editNewDon.UseSelectable = true;
            this.editNewDon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editNewDon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNewDon
            // 
            this.lblNewDon.AutoSize = true;
            this.lblNewDon.Location = new System.Drawing.Point(7, 160);
            this.lblNewDon.Name = "lblNewDon";
            this.lblNewDon.Size = new System.Drawing.Size(37, 19);
            this.lblNewDon.TabIndex = 13;
            this.lblNewDon.Text = "금액";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.editNewName);
            this.metroPanel1.Controls.Add(this.lblNewTitle);
            this.metroPanel1.Controls.Add(this.btnNewAdd);
            this.metroPanel1.Controls.Add(this.editNewDon);
            this.metroPanel1.Controls.Add(this.lblNewDon);
            this.metroPanel1.Controls.Add(this.lblNewDonType);
            this.metroPanel1.Controls.Add(this.lblNewName);
            this.metroPanel1.Controls.Add(this.lblNewDate);
            this.metroPanel1.Controls.Add(this.dateTimeNew);
            this.metroPanel1.Controls.Add(this.cboxNewType);
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
            // editNewName
            // 
            // 
            // 
            // 
            this.editNewName.CustomButton.Image = null;
            this.editNewName.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.editNewName.CustomButton.Name = "";
            this.editNewName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.editNewName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editNewName.CustomButton.TabIndex = 1;
            this.editNewName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editNewName.CustomButton.UseSelectable = true;
            this.editNewName.CustomButton.Visible = false;
            this.editNewName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.editNewName.Lines = new string[0];
            this.editNewName.Location = new System.Drawing.Point(103, 36);
            this.editNewName.MaxLength = 32767;
            this.editNewName.Name = "editNewName";
            this.editNewName.PasswordChar = '\0';
            this.editNewName.ReadOnly = true;
            this.editNewName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editNewName.SelectedText = "";
            this.editNewName.SelectionLength = 0;
            this.editNewName.SelectionStart = 0;
            this.editNewName.ShortcutsEnabled = true;
            this.editNewName.Size = new System.Drawing.Size(258, 29);
            this.editNewName.TabIndex = 21;
            this.editNewName.UseSelectable = true;
            this.editNewName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editNewName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnNewAdd
            // 
            this.btnNewAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNewAdd.Location = new System.Drawing.Point(257, 197);
            this.btnNewAdd.Name = "btnNewAdd";
            this.btnNewAdd.Size = new System.Drawing.Size(103, 38);
            this.btnNewAdd.TabIndex = 14;
            this.btnNewAdd.Text = "추가";
            this.btnNewAdd.UseSelectable = true;
            this.btnNewAdd.Click += new System.EventHandler(this.donBtnNewAdd_Click);
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
            this.metroPanel2.Controls.Add(this.btnUserMod);
            this.metroPanel2.Controls.Add(this.lblUserTitle);
            this.metroPanel2.Controls.Add(this.btnUserDel);
            this.metroPanel2.Controls.Add(this.btnUserAdd);
            this.metroPanel2.Controls.Add(this.listUser);
            this.metroPanel2.Controls.Add(this.btnUserSel);
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
            // btnUserMod
            // 
            this.btnUserMod.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUserMod.Location = new System.Drawing.Point(189, 443);
            this.btnUserMod.Name = "btnUserMod";
            this.btnUserMod.Size = new System.Drawing.Size(86, 44);
            this.btnUserMod.TabIndex = 10;
            this.btnUserMod.Text = "수정";
            this.btnUserMod.UseSelectable = true;
            this.btnUserMod.Click += new System.EventHandler(this.donBtnUserMod_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.btnHistoryDel);
            this.metroPanel3.Controls.Add(this.btnHistoryMod);
            this.metroPanel3.Controls.Add(this.lblHistoryTitle);
            this.metroPanel3.Controls.Add(this.editHistoryDon);
            this.metroPanel3.Controls.Add(this.lblHistoryDon);
            this.metroPanel3.Controls.Add(this.lblHistoryDonType);
            this.metroPanel3.Controls.Add(this.cboxHistoryType);
            this.metroPanel3.Controls.Add(this.lblHistoryName);
            this.metroPanel3.Controls.Add(this.editHistoryName);
            this.metroPanel3.Controls.Add(this.calendarHistory);
            this.metroPanel3.Controls.Add(this.listHistory);
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
            // btnHistoryDel
            // 
            this.btnHistoryDel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHistoryDel.Location = new System.Drawing.Point(102, 443);
            this.btnHistoryDel.Name = "btnHistoryDel";
            this.btnHistoryDel.Size = new System.Drawing.Size(86, 44);
            this.btnHistoryDel.TabIndex = 22;
            this.btnHistoryDel.Text = "삭제";
            this.btnHistoryDel.UseSelectable = true;
            this.btnHistoryDel.Click += new System.EventHandler(this.donBtnUserHistoryDel_Click);
            // 
            // btnHistoryMod
            // 
            this.btnHistoryMod.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHistoryMod.Location = new System.Drawing.Point(10, 443);
            this.btnHistoryMod.Name = "btnHistoryMod";
            this.btnHistoryMod.Size = new System.Drawing.Size(86, 44);
            this.btnHistoryMod.TabIndex = 21;
            this.btnHistoryMod.Text = "수정";
            this.btnHistoryMod.UseSelectable = true;
            this.btnHistoryMod.Click += new System.EventHandler(this.donBtnUserHistoryMod_Click);
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.White;
            this.lblHistoryTitle.Location = new System.Drawing.Point(3, 0);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(605, 27);
            this.lblHistoryTitle.TabIndex = 2;
            this.lblHistoryTitle.Text = "유저 히스토리";
            this.lblHistoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHistoryTitle.UseCustomBackColor = true;
            this.lblHistoryTitle.UseCustomForeColor = true;
            // 
            // editHistoryDon
            // 
            // 
            // 
            // 
            this.editHistoryDon.CustomButton.Image = null;
            this.editHistoryDon.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.editHistoryDon.CustomButton.Name = "";
            this.editHistoryDon.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.editHistoryDon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editHistoryDon.CustomButton.TabIndex = 1;
            this.editHistoryDon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editHistoryDon.CustomButton.UseSelectable = true;
            this.editHistoryDon.CustomButton.Visible = false;
            this.editHistoryDon.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.editHistoryDon.Lines = new string[0];
            this.editHistoryDon.Location = new System.Drawing.Point(115, 387);
            this.editHistoryDon.MaxLength = 32767;
            this.editHistoryDon.Name = "editHistoryDon";
            this.editHistoryDon.PasswordChar = '\0';
            this.editHistoryDon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editHistoryDon.SelectedText = "";
            this.editHistoryDon.SelectionLength = 0;
            this.editHistoryDon.SelectionStart = 0;
            this.editHistoryDon.ShortcutsEnabled = true;
            this.editHistoryDon.Size = new System.Drawing.Size(263, 29);
            this.editHistoryDon.TabIndex = 16;
            this.editHistoryDon.UseSelectable = true;
            this.editHistoryDon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editHistoryDon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblHistoryDon
            // 
            this.lblHistoryDon.AutoSize = true;
            this.lblHistoryDon.Location = new System.Drawing.Point(13, 392);
            this.lblHistoryDon.Name = "lblHistoryDon";
            this.lblHistoryDon.Size = new System.Drawing.Size(37, 19);
            this.lblHistoryDon.TabIndex = 17;
            this.lblHistoryDon.Text = "금액";
            // 
            // lblHistoryDonType
            // 
            this.lblHistoryDonType.AutoSize = true;
            this.lblHistoryDonType.Location = new System.Drawing.Point(13, 352);
            this.lblHistoryDonType.Name = "lblHistoryDonType";
            this.lblHistoryDonType.Size = new System.Drawing.Size(69, 19);
            this.lblHistoryDonType.TabIndex = 15;
            this.lblHistoryDonType.Text = "헌금 종류";
            // 
            // cboxHistoryType
            // 
            this.cboxHistoryType.FormattingEnabled = true;
            this.cboxHistoryType.ItemHeight = 23;
            this.cboxHistoryType.Location = new System.Drawing.Point(115, 347);
            this.cboxHistoryType.Name = "cboxHistoryType";
            this.cboxHistoryType.Size = new System.Drawing.Size(263, 29);
            this.cboxHistoryType.TabIndex = 14;
            this.cboxHistoryType.UseSelectable = true;
            // 
            // lblHistoryName
            // 
            this.lblHistoryName.AutoSize = true;
            this.lblHistoryName.Location = new System.Drawing.Point(13, 311);
            this.lblHistoryName.Name = "lblHistoryName";
            this.lblHistoryName.Size = new System.Drawing.Size(37, 19);
            this.lblHistoryName.TabIndex = 7;
            this.lblHistoryName.Text = "이름";
            // 
            // editHistoryName
            // 
            // 
            // 
            // 
            this.editHistoryName.CustomButton.Image = null;
            this.editHistoryName.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.editHistoryName.CustomButton.Name = "";
            this.editHistoryName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.editHistoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editHistoryName.CustomButton.TabIndex = 1;
            this.editHistoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editHistoryName.CustomButton.UseSelectable = true;
            this.editHistoryName.CustomButton.Visible = false;
            this.editHistoryName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.editHistoryName.Lines = new string[0];
            this.editHistoryName.Location = new System.Drawing.Point(115, 307);
            this.editHistoryName.MaxLength = 32767;
            this.editHistoryName.Name = "editHistoryName";
            this.editHistoryName.PasswordChar = '\0';
            this.editHistoryName.ReadOnly = true;
            this.editHistoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editHistoryName.SelectedText = "";
            this.editHistoryName.SelectionLength = 0;
            this.editHistoryName.SelectionStart = 0;
            this.editHistoryName.ShortcutsEnabled = true;
            this.editHistoryName.Size = new System.Drawing.Size(263, 29);
            this.editHistoryName.TabIndex = 8;
            this.editHistoryName.UseSelectable = true;
            this.editHistoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editHistoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // calendarHistory
            // 
            this.calendarHistory.Location = new System.Drawing.Point(389, 27);
            this.calendarHistory.Name = "calendarHistory";
            this.calendarHistory.TabIndex = 4;
            // 
            // listHistory
            // 
            this.listHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listHistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listHistory.FullRowSelect = true;
            this.listHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listHistory.Location = new System.Drawing.Point(3, 27);
            this.listHistory.MultiSelect = false;
            this.listHistory.Name = "listHistory";
            this.listHistory.OwnerDraw = true;
            this.listHistory.Size = new System.Drawing.Size(375, 263);
            this.listHistory.TabIndex = 3;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.UseSelectable = true;
            this.listHistory.UseStyleColors = true;
            this.listHistory.View = System.Windows.Forms.View.Details;
            this.listHistory.SelectedIndexChanged += new System.EventHandler(this.donListUserHistory_SelectedIndexChanged);
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
            this.metroLabel12.Size = new System.Drawing.Size(605, 468);
            this.metroLabel12.TabIndex = 20;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroLabel8);
            this.metroPanel4.Controls.Add(this.editTodayLog);
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
            // editTodayLog
            // 
            // 
            // 
            // 
            this.editTodayLog.CustomButton.Image = null;
            this.editTodayLog.CustomButton.Location = new System.Drawing.Point(389, 2);
            this.editTodayLog.CustomButton.Name = "";
            this.editTodayLog.CustomButton.Size = new System.Drawing.Size(213, 213);
            this.editTodayLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editTodayLog.CustomButton.TabIndex = 1;
            this.editTodayLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTodayLog.CustomButton.UseSelectable = true;
            this.editTodayLog.CustomButton.Visible = false;
            this.editTodayLog.Lines = new string[0];
            this.editTodayLog.Location = new System.Drawing.Point(3, 26);
            this.editTodayLog.MaxLength = 32767;
            this.editTodayLog.Multiline = true;
            this.editTodayLog.Name = "editTodayLog";
            this.editTodayLog.PasswordChar = '\0';
            this.editTodayLog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editTodayLog.SelectedText = "";
            this.editTodayLog.SelectionLength = 0;
            this.editTodayLog.SelectionStart = 0;
            this.editTodayLog.ShortcutsEnabled = true;
            this.editTodayLog.Size = new System.Drawing.Size(605, 218);
            this.editTodayLog.TabIndex = 6;
            this.editTodayLog.UseSelectable = true;
            this.editTodayLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editTodayLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblHourMinute
            // 
            this.lblHourMinute.BackColor = System.Drawing.Color.Transparent;
            this.lblHourMinute.Font = new System.Drawing.Font("Arial", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lblHourMinute.Location = new System.Drawing.Point(76, 6);
            this.lblHourMinute.Name = "lblHourMinute";
            this.lblHourMinute.Size = new System.Drawing.Size(183, 69);
            this.lblHourMinute.TabIndex = 18;
            this.lblHourMinute.Text = "99:99";
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
            this.metroPanel5.Controls.Add(this.lblDate);
            this.metroPanel5.Controls.Add(this.lblPMAM);
            this.metroPanel5.Controls.Add(this.lblHourMinute);
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lblDate.Location = new System.Drawing.Point(17, 76);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(231, 34);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "2020년 12월 22일";
            // 
            // lblPMAM
            // 
            this.lblPMAM.AutoSize = true;
            this.lblPMAM.BackColor = System.Drawing.Color.Transparent;
            this.lblPMAM.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lblPMAM.Location = new System.Drawing.Point(3, 24);
            this.lblPMAM.Name = "lblPMAM";
            this.lblPMAM.Size = new System.Drawing.Size(86, 46);
            this.lblPMAM.TabIndex = 21;
            this.lblPMAM.Text = "오후";
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
            // btnAllSave
            // 
            this.btnAllSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnAllSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAllSave.ForeColor = System.Drawing.Color.White;
            this.btnAllSave.Location = new System.Drawing.Point(1010, 145);
            this.btnAllSave.Name = "btnAllSave";
            this.btnAllSave.Size = new System.Drawing.Size(258, 56);
            this.btnAllSave.TabIndex = 22;
            this.btnAllSave.Text = "저장";
            this.btnAllSave.UseCustomBackColor = true;
            this.btnAllSave.UseCustomForeColor = true;
            this.btnAllSave.UseSelectable = true;
            this.btnAllSave.Click += new System.EventHandler(this.donBtnAllSave_Click);
            // 
            // donTimerCurTime
            // 
            this.donTimerCurTime.Tick += new System.EventHandler(this.donTimerCurTime_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel1.Location = new System.Drawing.Point(-13, -16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(1295, 953);
            this.metroLabel1.TabIndex = 23;
            // 
            // TabDonationInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1280, 935);
            this.ControlBox = false;
            this.Controls.Add(this.btnAllSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listUser;
        private MetroFramework.Controls.MetroLabel lblUserTitle;
        private MetroFramework.Controls.MetroButton btnUserSel;
        private MetroFramework.Controls.MetroButton btnUserAdd;
        private MetroFramework.Controls.MetroLabel lblNewTitle;
        private MetroFramework.Controls.MetroLabel lblNewName;
        private MetroFramework.Controls.MetroDateTime dateTimeNew;
        private MetroFramework.Controls.MetroComboBox cboxNewType;
        private MetroFramework.Controls.MetroButton btnUserDel;
        private MetroFramework.Controls.MetroLabel lblNewDate;
        private MetroFramework.Controls.MetroLabel lblNewDonType;
        private MetroFramework.Controls.MetroTextBox editNewDon;
        private MetroFramework.Controls.MetroLabel lblNewDon;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnNewAdd;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroListView listHistory;
        private MetroFramework.Controls.MetroLabel lblHistoryTitle;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTextBox editTodayLog;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox editHistoryDon;
        private MetroFramework.Controls.MetroLabel lblHistoryDon;
        private MetroFramework.Controls.MetroLabel lblHistoryDonType;
        private MetroFramework.Controls.MetroComboBox cboxHistoryType;
        private MetroFramework.Controls.MetroLabel lblHistoryName;
        private MetroFramework.Controls.MetroTextBox editHistoryName;
        private System.Windows.Forms.MonthCalendar calendarHistory;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.Label lblHourMinute;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPMAM;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton btnAllSave;
        private System.Windows.Forms.Timer donTimerCurTime;
        private MetroFramework.Controls.MetroButton btnUserMod;
        private MetroFramework.Controls.MetroTextBox editNewName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroButton btnHistoryDel;
        private MetroFramework.Controls.MetroButton btnHistoryMod;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}