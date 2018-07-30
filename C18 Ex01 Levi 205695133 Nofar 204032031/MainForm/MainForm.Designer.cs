namespace FacebookApp
{
     partial class MainForm
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
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.pictureBoxUserPicture = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.groupBoxFriends = new System.Windows.Forms.GroupBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.groupBoxPhotos = new System.Windows.Forms.GroupBox();
            this.groupBoxIntro = new System.Windows.Forms.GroupBox();
            this.textBoxIntro = new System.Windows.Forms.TextBox();
            this.groupBoxEvents = new System.Windows.Forms.GroupBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.groupBoxCheckins = new System.Windows.Forms.GroupBox();
            this.pictureBoxCheckin = new System.Windows.Forms.PictureBox();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.groupBoxLikedPages = new System.Windows.Forms.GroupBox();
            this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonGetPicturePath = new System.Windows.Forms.Button();
            this.textBoxPicturePath = new System.Windows.Forms.TextBox();
            this.featuresTabs = new System.Windows.Forms.TabControl();
            this.timelineTab = new System.Windows.Forms.TabPage();
            this.matchTab = new System.Windows.Forms.TabPage();
            this.matchBox = new System.Windows.Forms.GroupBox();
            this.matchProgress = new System.Windows.Forms.ProgressBar();
            this.ageLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.matchButton = new System.Windows.Forms.Button();
            this.ageNumeric = new System.Windows.Forms.NumericUpDown();
            this.genderList = new System.Windows.Forms.CheckedListBox();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.commonTab = new System.Windows.Forms.TabPage();
            this.commonIntro = new System.Windows.Forms.GroupBox();
            this.commonPages = new System.Windows.Forms.GroupBox();
            this.commonPhotos = new System.Windows.Forms.GroupBox();
            this.findCommonButton = new System.Windows.Forms.Button();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.feed = new FacebookApp.Feed();
            this.photoPanel = new FacebookApp.PhotoPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.groupBoxFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.groupBoxPhotos.SuspendLayout();
            this.groupBoxIntro.SuspendLayout();
            this.groupBoxEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.groupBoxCheckins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).BeginInit();
            this.groupBoxLikedPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
            this.featuresTabs.SuspendLayout();
            this.timelineTab.SuspendLayout();
            this.matchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).BeginInit();
            this.commonTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(679, 12);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(75, 31);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonLogOut.Enabled = false;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(760, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 31);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // pictureBoxUserPicture
            // 
            this.pictureBoxUserPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserPicture.Location = new System.Drawing.Point(33, 49);
            this.pictureBoxUserPicture.Name = "pictureBoxUserPicture";
            this.pictureBoxUserPicture.Size = new System.Drawing.Size(126, 117);
            this.pictureBoxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserPicture.TabIndex = 2;
            this.pictureBoxUserPicture.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(165, 125);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 31);
            this.labelName.TabIndex = 4;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Enabled = false;
            this.textBoxPost.Location = new System.Drawing.Point(215, 42);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPost.Size = new System.Drawing.Size(399, 74);
            this.textBoxPost.TabIndex = 5;
            this.textBoxPost.Enter += new System.EventHandler(this.textBoxPost_Enter);
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonPost.Enabled = false;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.Location = new System.Drawing.Point(215, 121);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 31);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCover.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(834, 153);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 7;
            this.pictureBoxCover.TabStop = false;
            // 
            // groupBoxFriends
            // 
            this.groupBoxFriends.Controls.Add(this.pictureBoxFriend);
            this.groupBoxFriends.Controls.Add(this.listBoxFriends);
            this.groupBoxFriends.Location = new System.Drawing.Point(3, 346);
            this.groupBoxFriends.Name = "groupBoxFriends";
            this.groupBoxFriends.Size = new System.Drawing.Size(200, 164);
            this.groupBoxFriends.TabIndex = 8;
            this.groupBoxFriends.TabStop = false;
            this.groupBoxFriends.Text = "Friends";
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFriend.Location = new System.Drawing.Point(136, 12);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 21;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(6, 26);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(128, 132);
            this.listBoxFriends.TabIndex = 20;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // groupBoxPhotos
            // 
            this.groupBoxPhotos.Controls.Add(this.photoPanel);
            this.groupBoxPhotos.Location = new System.Drawing.Point(3, 176);
            this.groupBoxPhotos.Name = "groupBoxPhotos";
            this.groupBoxPhotos.Size = new System.Drawing.Size(200, 164);
            this.groupBoxPhotos.TabIndex = 9;
            this.groupBoxPhotos.TabStop = false;
            this.groupBoxPhotos.Text = "Photos";
            // 
            // groupBoxIntro
            // 
            this.groupBoxIntro.Controls.Add(this.textBoxIntro);
            this.groupBoxIntro.Location = new System.Drawing.Point(3, 6);
            this.groupBoxIntro.Name = "groupBoxIntro";
            this.groupBoxIntro.Size = new System.Drawing.Size(200, 164);
            this.groupBoxIntro.TabIndex = 10;
            this.groupBoxIntro.TabStop = false;
            this.groupBoxIntro.Text = "Intro";
            // 
            // textBoxIntro
            // 
            this.textBoxIntro.BackColor = System.Drawing.Color.White;
            this.textBoxIntro.Location = new System.Drawing.Point(7, 22);
            this.textBoxIntro.Multiline = true;
            this.textBoxIntro.Name = "textBoxIntro";
            this.textBoxIntro.ReadOnly = true;
            this.textBoxIntro.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIntro.Size = new System.Drawing.Size(187, 132);
            this.textBoxIntro.TabIndex = 0;
            // 
            // groupBoxEvents
            // 
            this.groupBoxEvents.Controls.Add(this.pictureBoxEvent);
            this.groupBoxEvents.Controls.Add(this.listBoxEvents);
            this.groupBoxEvents.Location = new System.Drawing.Point(628, 6);
            this.groupBoxEvents.Name = "groupBoxEvents";
            this.groupBoxEvents.Size = new System.Drawing.Size(200, 164);
            this.groupBoxEvents.TabIndex = 11;
            this.groupBoxEvents.TabStop = false;
            this.groupBoxEvents.Text = "Events";
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEvent.Location = new System.Drawing.Point(136, 12);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvent.TabIndex = 15;
            this.pictureBoxEvent.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(6, 26);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(128, 132);
            this.listBoxEvents.TabIndex = 14;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // groupBoxCheckins
            // 
            this.groupBoxCheckins.Controls.Add(this.pictureBoxCheckin);
            this.groupBoxCheckins.Controls.Add(this.listBoxCheckins);
            this.groupBoxCheckins.Location = new System.Drawing.Point(626, 176);
            this.groupBoxCheckins.Name = "groupBoxCheckins";
            this.groupBoxCheckins.Size = new System.Drawing.Size(200, 164);
            this.groupBoxCheckins.TabIndex = 12;
            this.groupBoxCheckins.TabStop = false;
            this.groupBoxCheckins.Text = "Checkins";
            // 
            // pictureBoxCheckin
            // 
            this.pictureBoxCheckin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCheckin.Location = new System.Drawing.Point(136, 12);
            this.pictureBoxCheckin.Name = "pictureBoxCheckin";
            this.pictureBoxCheckin.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckin.TabIndex = 17;
            this.pictureBoxCheckin.TabStop = false;
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 16;
            this.listBoxCheckins.Location = new System.Drawing.Point(6, 26);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(128, 132);
            this.listBoxCheckins.TabIndex = 16;
            this.listBoxCheckins.SelectedIndexChanged += new System.EventHandler(this.listBoxCheckins_SelectedIndexChanged);
            // 
            // groupBoxLikedPages
            // 
            this.groupBoxLikedPages.Controls.Add(this.pictureBoxLikedPage);
            this.groupBoxLikedPages.Controls.Add(this.listBoxLikedPages);
            this.groupBoxLikedPages.Location = new System.Drawing.Point(624, 346);
            this.groupBoxLikedPages.Name = "groupBoxLikedPages";
            this.groupBoxLikedPages.Size = new System.Drawing.Size(200, 164);
            this.groupBoxLikedPages.TabIndex = 12;
            this.groupBoxLikedPages.TabStop = false;
            this.groupBoxLikedPages.Text = "Liked Pages";
            // 
            // pictureBoxLikedPage
            // 
            this.pictureBoxLikedPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLikedPage.Location = new System.Drawing.Point(136, 12);
            this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
            this.pictureBoxLikedPage.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLikedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikedPage.TabIndex = 19;
            this.pictureBoxLikedPage.TabStop = false;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(6, 26);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(128, 132);
            this.listBoxLikedPages.TabIndex = 18;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.AutoSize = true;
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRefresh.Enabled = false;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(679, 49);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 27);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonGetPicturePath
            // 
            this.buttonGetPicturePath.AutoSize = true;
            this.buttonGetPicturePath.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonGetPicturePath.Enabled = false;
            this.buttonGetPicturePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetPicturePath.Location = new System.Drawing.Point(296, 122);
            this.buttonGetPicturePath.Name = "buttonGetPicturePath";
            this.buttonGetPicturePath.Size = new System.Drawing.Size(73, 30);
            this.buttonGetPicturePath.TabIndex = 15;
            this.buttonGetPicturePath.Text = "Photo";
            this.buttonGetPicturePath.UseVisualStyleBackColor = false;
            this.buttonGetPicturePath.Click += new System.EventHandler(this.buttonGetPicturePath_Click);
            // 
            // textBoxPicturePath
            // 
            this.textBoxPicturePath.Enabled = false;
            this.textBoxPicturePath.Location = new System.Drawing.Point(215, 14);
            this.textBoxPicturePath.Name = "textBoxPicturePath";
            this.textBoxPicturePath.Size = new System.Drawing.Size(399, 22);
            this.textBoxPicturePath.TabIndex = 16;
            this.textBoxPicturePath.Visible = false;
            // 
            // featuresTabs
            // 
            this.featuresTabs.Controls.Add(this.timelineTab);
            this.featuresTabs.Controls.Add(this.matchTab);
            this.featuresTabs.Controls.Add(this.commonTab);
            this.featuresTabs.Location = new System.Drawing.Point(12, 172);
            this.featuresTabs.Name = "featuresTabs";
            this.featuresTabs.SelectedIndex = 0;
            this.featuresTabs.Size = new System.Drawing.Size(834, 549);
            this.featuresTabs.TabIndex = 18;
            // 
            // timelineTab
            // 
            this.timelineTab.Controls.Add(this.textBoxPicturePath);
            this.timelineTab.Controls.Add(this.feed);
            this.timelineTab.Controls.Add(this.textBoxPost);
            this.timelineTab.Controls.Add(this.buttonGetPicturePath);
            this.timelineTab.Controls.Add(this.groupBoxFriends);
            this.timelineTab.Controls.Add(this.groupBoxLikedPages);
            this.timelineTab.Controls.Add(this.groupBoxEvents);
            this.timelineTab.Controls.Add(this.groupBoxCheckins);
            this.timelineTab.Controls.Add(this.groupBoxPhotos);
            this.timelineTab.Controls.Add(this.groupBoxIntro);
            this.timelineTab.Controls.Add(this.buttonPost);
            this.timelineTab.Location = new System.Drawing.Point(4, 25);
            this.timelineTab.Name = "timelineTab";
            this.timelineTab.Padding = new System.Windows.Forms.Padding(3);
            this.timelineTab.Size = new System.Drawing.Size(826, 520);
            this.timelineTab.TabIndex = 0;
            this.timelineTab.Text = "Timeline";
            this.timelineTab.UseVisualStyleBackColor = true;
            // 
            // matchTab
            // 
            this.matchTab.Controls.Add(this.matchBox);
            this.matchTab.Controls.Add(this.matchProgress);
            this.matchTab.Controls.Add(this.ageLabel);
            this.matchTab.Controls.Add(this.locationLabel);
            this.matchTab.Controls.Add(this.genderLabel);
            this.matchTab.Controls.Add(this.matchButton);
            this.matchTab.Controls.Add(this.ageNumeric);
            this.matchTab.Controls.Add(this.genderList);
            this.matchTab.Controls.Add(this.locationCombo);
            this.matchTab.Location = new System.Drawing.Point(4, 25);
            this.matchTab.Name = "matchTab";
            this.matchTab.Padding = new System.Windows.Forms.Padding(3);
            this.matchTab.Size = new System.Drawing.Size(826, 520);
            this.matchTab.TabIndex = 1;
            this.matchTab.Text = "Match!";
            this.matchTab.UseVisualStyleBackColor = true;
            // 
            // matchBox
            // 
            this.matchBox.Location = new System.Drawing.Point(9, 136);
            this.matchBox.Name = "matchBox";
            this.matchBox.Size = new System.Drawing.Size(750, 386);
            this.matchBox.TabIndex = 17;
            this.matchBox.TabStop = false;
            this.matchBox.Text = "Match Options";
            // 
            // matchProgress
            // 
            this.matchProgress.Location = new System.Drawing.Point(9, 87);
            this.matchProgress.Name = "matchProgress";
            this.matchProgress.Size = new System.Drawing.Size(100, 23);
            this.matchProgress.TabIndex = 16;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(259, 13);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(59, 17);
            this.ageLabel.TabIndex = 15;
            this.ageLabel.Text = "Min Age";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(132, 13);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(62, 17);
            this.locationLabel.TabIndex = 14;
            this.locationLabel.Text = "Location";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(6, 13);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 17);
            this.genderLabel.TabIndex = 13;
            this.genderLabel.Text = "Gender";
            // 
            // matchButton
            // 
            this.matchButton.Location = new System.Drawing.Point(388, 32);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(121, 23);
            this.matchButton.TabIndex = 12;
            this.matchButton.Text = "Find Me A Match";
            this.matchButton.UseVisualStyleBackColor = true;
            // 
            // ageNumeric
            // 
            this.ageNumeric.Location = new System.Drawing.Point(262, 33);
            this.ageNumeric.Name = "ageNumeric";
            this.ageNumeric.Size = new System.Drawing.Size(120, 22);
            this.ageNumeric.TabIndex = 11;
            // 
            // genderList
            // 
            this.genderList.FormattingEnabled = true;
            this.genderList.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderList.Location = new System.Drawing.Point(9, 33);
            this.genderList.Name = "genderList";
            this.genderList.Size = new System.Drawing.Size(120, 38);
            this.genderList.TabIndex = 10;
            // 
            // locationCombo
            // 
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Location = new System.Drawing.Point(135, 33);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(121, 24);
            this.locationCombo.TabIndex = 9;
            // 
            // commonTab
            // 
            this.commonTab.Controls.Add(this.commonIntro);
            this.commonTab.Controls.Add(this.commonPages);
            this.commonTab.Controls.Add(this.commonPhotos);
            this.commonTab.Controls.Add(this.findCommonButton);
            this.commonTab.Controls.Add(this.friendsListBox);
            this.commonTab.Location = new System.Drawing.Point(4, 25);
            this.commonTab.Name = "commonTab";
            this.commonTab.Size = new System.Drawing.Size(826, 520);
            this.commonTab.TabIndex = 2;
            this.commonTab.Text = "Common Finder";
            this.commonTab.UseVisualStyleBackColor = true;
            // 
            // commonIntro
            // 
            this.commonIntro.Location = new System.Drawing.Point(578, 242);
            this.commonIntro.Name = "commonIntro";
            this.commonIntro.Size = new System.Drawing.Size(184, 160);
            this.commonIntro.TabIndex = 23;
            this.commonIntro.TabStop = false;
            this.commonIntro.Text = "Intro In Common";
            // 
            // commonPages
            // 
            this.commonPages.Location = new System.Drawing.Point(377, 242);
            this.commonPages.Name = "commonPages";
            this.commonPages.Size = new System.Drawing.Size(184, 160);
            this.commonPages.TabIndex = 22;
            this.commonPages.TabStop = false;
            this.commonPages.Text = "Pages In Common";
            // 
            // commonPhotos
            // 
            this.commonPhotos.Location = new System.Drawing.Point(377, 15);
            this.commonPhotos.Name = "commonPhotos";
            this.commonPhotos.Size = new System.Drawing.Size(385, 221);
            this.commonPhotos.TabIndex = 21;
            this.commonPhotos.TabStop = false;
            this.commonPhotos.Text = "Photos In Common";
            // 
            // findCommonButton
            // 
            this.findCommonButton.Location = new System.Drawing.Point(17, 408);
            this.findCommonButton.Name = "findCommonButton";
            this.findCommonButton.Size = new System.Drawing.Size(117, 29);
            this.findCommonButton.TabIndex = 20;
            this.findCommonButton.Text = "Find Common";
            this.findCommonButton.UseVisualStyleBackColor = true;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.HorizontalScrollbar = true;
            this.friendsListBox.ItemHeight = 16;
            this.friendsListBox.Location = new System.Drawing.Point(17, 14);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.ScrollAlwaysVisible = true;
            this.friendsListBox.Size = new System.Drawing.Size(333, 388);
            this.friendsListBox.TabIndex = 19;
            // 
            // feed
            // 
            this.feed.Location = new System.Drawing.Point(215, 158);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(399, 352);
            this.feed.TabIndex = 17;
            // 
            // photoPanel
            // 
            this.photoPanel.Location = new System.Drawing.Point(0, 0);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(200, 164);
            this.photoPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 733);
            this.Controls.Add(this.featuresTabs);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxUserPicture);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.pictureBoxCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Facebook Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.groupBoxFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.groupBoxPhotos.ResumeLayout(false);
            this.groupBoxIntro.ResumeLayout(false);
            this.groupBoxIntro.PerformLayout();
            this.groupBoxEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.groupBoxCheckins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).EndInit();
            this.groupBoxLikedPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
            this.featuresTabs.ResumeLayout(false);
            this.timelineTab.ResumeLayout(false);
            this.timelineTab.PerformLayout();
            this.matchTab.ResumeLayout(false);
            this.matchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).EndInit();
            this.commonTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button buttonLogIn;
          private System.Windows.Forms.Button buttonLogOut;
          private System.Windows.Forms.PictureBox pictureBoxUserPicture;
          private System.Windows.Forms.Label labelName;
          private System.Windows.Forms.TextBox textBoxPost;
          private System.Windows.Forms.Button buttonPost;
          private System.Windows.Forms.PictureBox pictureBoxCover;
          private System.Windows.Forms.GroupBox groupBoxFriends;
          private System.Windows.Forms.GroupBox groupBoxPhotos;
          private System.Windows.Forms.GroupBox groupBoxIntro;
          private System.Windows.Forms.PictureBox pictureBoxFriend;
          private System.Windows.Forms.ListBox listBoxFriends;
          private System.Windows.Forms.GroupBox groupBoxEvents;
          private System.Windows.Forms.PictureBox pictureBoxEvent;
          private System.Windows.Forms.ListBox listBoxEvents;
          private System.Windows.Forms.GroupBox groupBoxCheckins;
          private System.Windows.Forms.PictureBox pictureBoxCheckin;
          private System.Windows.Forms.ListBox listBoxCheckins;
          private System.Windows.Forms.GroupBox groupBoxLikedPages;
          private System.Windows.Forms.PictureBox pictureBoxLikedPage;
          private System.Windows.Forms.ListBox listBoxLikedPages;
          private System.Windows.Forms.Button buttonRefresh;
          protected System.Windows.Forms.TextBox textBoxIntro;
          private System.Windows.Forms.Button buttonGetPicturePath;
          private System.Windows.Forms.TextBox textBoxPicturePath;
          private Feed feed;
          private PhotoPanel photoPanel;
        private System.Windows.Forms.TabControl featuresTabs;
        private System.Windows.Forms.TabPage timelineTab;
        private System.Windows.Forms.TabPage matchTab;
        private System.Windows.Forms.TabPage commonTab;
        private System.Windows.Forms.GroupBox matchBox;
        private System.Windows.Forms.ProgressBar matchProgress;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.NumericUpDown ageNumeric;
        private System.Windows.Forms.CheckedListBox genderList;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.GroupBox commonIntro;
        private System.Windows.Forms.GroupBox commonPages;
        private System.Windows.Forms.GroupBox commonPhotos;
        private System.Windows.Forms.Button findCommonButton;
        private System.Windows.Forms.ListBox friendsListBox;
    }
}

