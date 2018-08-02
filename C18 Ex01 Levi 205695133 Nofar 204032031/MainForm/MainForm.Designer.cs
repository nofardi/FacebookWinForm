namespace FacebookApp
{
     public partial class MainForm
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
               this.groupBoxPhotos = new System.Windows.Forms.GroupBox();
               this.groupBoxIntro = new System.Windows.Forms.GroupBox();
               this.textBoxIntro = new System.Windows.Forms.TextBox();
               this.groupBoxEvents = new System.Windows.Forms.GroupBox();
               this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
               this.groupBoxCheckins = new System.Windows.Forms.GroupBox();
               this.pictureBoxCheckin = new System.Windows.Forms.PictureBox();
               this.groupBoxLikedPages = new System.Windows.Forms.GroupBox();
               this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
               this.buttonRefresh = new System.Windows.Forms.Button();
               this.buttonGetPicturePath = new System.Windows.Forms.Button();
               this.textBoxPicturePath = new System.Windows.Forms.TextBox();
               this.featuresTabs = new System.Windows.Forms.TabControl();
               this.timelineTab = new System.Windows.Forms.TabPage();
               this.followersTab = new System.Windows.Forms.TabPage();
               this.topFollowerPic = new System.Windows.Forms.PictureBox();
               this.topFollowerLabel = new System.Windows.Forms.Label();
               this.followersListBox = new System.Windows.Forms.ListBox();
               this.findFollowersButton = new System.Windows.Forms.Button();
               this.commonTab = new System.Windows.Forms.TabPage();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.friendsInCommonPic = new System.Windows.Forms.PictureBox();
               this.commonIntro = new System.Windows.Forms.GroupBox();
               this.introInCommonText = new System.Windows.Forms.TextBox();
               this.commonPages = new System.Windows.Forms.GroupBox();
               this.pagesInCommonPic = new System.Windows.Forms.PictureBox();
               this.findCommonButton = new System.Windows.Forms.Button();
               this.friendsCommonListBox = new System.Windows.Forms.ListBox();
               this.rememberCheckbox = new System.Windows.Forms.CheckBox();
               this.feed = new FacebookApp.Feed();
               this.listBoxFriends = new FacebookApp.FriendsListBox();
               this.likedPagesListBox = new FacebookApp.PagesListBox();
               this.listBoxEvents = new FacebookApp.EventsListBox();
               this.listBoxCheckins = new FacebookApp.CheckinsListBox();
               this.photoPanel = new FacebookApp.PhotoPanel();
               this.topFollowerPosts = new FacebookApp.Feed();
               this.topFollowerPhotos = new FacebookApp.PhotoPanel();
               this.feedInCommon = new FacebookApp.Feed();
               this.photosInCommonPanel = new FacebookApp.PhotoPanel();
               this.friendsInCommonListBox = new FacebookApp.FriendsListBox();
               this.pagesInCommonListBox = new FacebookApp.PagesListBox();
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
               this.followersTab.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.topFollowerPic)).BeginInit();
               this.commonTab.SuspendLayout();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.friendsInCommonPic)).BeginInit();
               this.commonIntro.SuspendLayout();
               this.commonPages.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pagesInCommonPic)).BeginInit();
               this.SuspendLayout();
               // 
               // buttonLogIn
               // 
               this.buttonLogIn.BackColor = System.Drawing.SystemColors.Menu;
               this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonLogIn.Location = new System.Drawing.Point(708, 12);
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
               this.buttonLogOut.Location = new System.Drawing.Point(789, 12);
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
               this.pictureBoxCover.Size = new System.Drawing.Size(859, 153);
               this.pictureBoxCover.TabIndex = 7;
               this.pictureBoxCover.TabStop = false;
               // 
               // groupBoxFriends
               // 
               this.groupBoxFriends.Controls.Add(this.listBoxFriends);
               this.groupBoxFriends.Controls.Add(this.pictureBoxFriend);
               this.groupBoxFriends.Location = new System.Drawing.Point(3, 346);
               this.groupBoxFriends.Name = "groupBoxFriends";
               this.groupBoxFriends.Size = new System.Drawing.Size(200, 164);
               this.groupBoxFriends.TabIndex = 8;
               this.groupBoxFriends.TabStop = false;
               this.groupBoxFriends.Text = "Friends";
               // 
               // pictureBoxFriend
               // 
               this.pictureBoxFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.pictureBoxFriend.Location = new System.Drawing.Point(137, 9);
               this.pictureBoxFriend.Name = "pictureBoxFriend";
               this.pictureBoxFriend.Size = new System.Drawing.Size(60, 60);
               this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxFriend.TabIndex = 21;
               this.pictureBoxFriend.TabStop = false;
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
               this.groupBoxEvents.Controls.Add(this.listBoxEvents);
               this.groupBoxEvents.Controls.Add(this.pictureBoxEvent);
               this.groupBoxEvents.Location = new System.Drawing.Point(628, 6);
               this.groupBoxEvents.Name = "groupBoxEvents";
               this.groupBoxEvents.Size = new System.Drawing.Size(200, 164);
               this.groupBoxEvents.TabIndex = 11;
               this.groupBoxEvents.TabStop = false;
               this.groupBoxEvents.Text = "Events";
               // 
               // pictureBoxEvent
               // 
               this.pictureBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.pictureBoxEvent.Location = new System.Drawing.Point(138, 8);
               this.pictureBoxEvent.Name = "pictureBoxEvent";
               this.pictureBoxEvent.Size = new System.Drawing.Size(60, 60);
               this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxEvent.TabIndex = 15;
               this.pictureBoxEvent.TabStop = false;
               // 
               // groupBoxCheckins
               // 
               this.groupBoxCheckins.Controls.Add(this.listBoxCheckins);
               this.groupBoxCheckins.Controls.Add(this.pictureBoxCheckin);
               this.groupBoxCheckins.Location = new System.Drawing.Point(628, 176);
               this.groupBoxCheckins.Name = "groupBoxCheckins";
               this.groupBoxCheckins.Size = new System.Drawing.Size(200, 164);
               this.groupBoxCheckins.TabIndex = 12;
               this.groupBoxCheckins.TabStop = false;
               this.groupBoxCheckins.Text = "Checkins";
               // 
               // pictureBoxCheckin
               // 
               this.pictureBoxCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxCheckin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.pictureBoxCheckin.Location = new System.Drawing.Point(136, 9);
               this.pictureBoxCheckin.Name = "pictureBoxCheckin";
               this.pictureBoxCheckin.Size = new System.Drawing.Size(60, 60);
               this.pictureBoxCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxCheckin.TabIndex = 17;
               this.pictureBoxCheckin.TabStop = false;
               // 
               // groupBoxLikedPages
               // 
               this.groupBoxLikedPages.Controls.Add(this.likedPagesListBox);
               this.groupBoxLikedPages.Controls.Add(this.pictureBoxLikedPage);
               this.groupBoxLikedPages.Location = new System.Drawing.Point(624, 346);
               this.groupBoxLikedPages.Name = "groupBoxLikedPages";
               this.groupBoxLikedPages.Size = new System.Drawing.Size(200, 164);
               this.groupBoxLikedPages.TabIndex = 12;
               this.groupBoxLikedPages.TabStop = false;
               this.groupBoxLikedPages.Text = "Liked Pages";
               // 
               // pictureBoxLikedPage
               // 
               this.pictureBoxLikedPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxLikedPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.pictureBoxLikedPage.Location = new System.Drawing.Point(140, 9);
               this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
               this.pictureBoxLikedPage.Size = new System.Drawing.Size(60, 60);
               this.pictureBoxLikedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxLikedPage.TabIndex = 19;
               this.pictureBoxLikedPage.TabStop = false;
               // 
               // buttonRefresh
               // 
               this.buttonRefresh.AutoSize = true;
               this.buttonRefresh.BackColor = System.Drawing.SystemColors.Menu;
               this.buttonRefresh.Enabled = false;
               this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonRefresh.Location = new System.Drawing.Point(708, 49);
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
               this.buttonGetPicturePath.Location = new System.Drawing.Point(294, 120);
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
               this.featuresTabs.Controls.Add(this.followersTab);
               this.featuresTabs.Controls.Add(this.commonTab);
               this.featuresTabs.Location = new System.Drawing.Point(12, 172);
               this.featuresTabs.Name = "featuresTabs";
               this.featuresTabs.SelectedIndex = 0;
               this.featuresTabs.Size = new System.Drawing.Size(859, 584);
               this.featuresTabs.TabIndex = 18;
               // 
               // timelineTab
               // 
               this.timelineTab.Controls.Add(this.feed);
               this.timelineTab.Controls.Add(this.textBoxPicturePath);
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
               this.timelineTab.Margin = new System.Windows.Forms.Padding(1);
               this.timelineTab.Name = "timelineTab";
               this.timelineTab.Padding = new System.Windows.Forms.Padding(1);
               this.timelineTab.Size = new System.Drawing.Size(851, 555);
               this.timelineTab.TabIndex = 0;
               this.timelineTab.Text = "Timeline";
               this.timelineTab.UseVisualStyleBackColor = true;
               // 
               // followersTab
               // 
               this.followersTab.Controls.Add(this.topFollowerPosts);
               this.followersTab.Controls.Add(this.topFollowerPhotos);
               this.followersTab.Controls.Add(this.topFollowerPic);
               this.followersTab.Controls.Add(this.topFollowerLabel);
               this.followersTab.Controls.Add(this.followersListBox);
               this.followersTab.Controls.Add(this.findFollowersButton);
               this.followersTab.Location = new System.Drawing.Point(4, 25);
               this.followersTab.Name = "followersTab";
               this.followersTab.Padding = new System.Windows.Forms.Padding(3);
               this.followersTab.Size = new System.Drawing.Size(851, 555);
               this.followersTab.TabIndex = 1;
               this.followersTab.Text = "Top Follower";
               this.followersTab.UseVisualStyleBackColor = true;
               // 
               // topFollowerPic
               // 
               this.topFollowerPic.Location = new System.Drawing.Point(185, 84);
               this.topFollowerPic.Name = "topFollowerPic";
               this.topFollowerPic.Size = new System.Drawing.Size(53, 50);
               this.topFollowerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.topFollowerPic.TabIndex = 3;
               this.topFollowerPic.TabStop = false;
               // 
               // topFollowerLabel
               // 
               this.topFollowerLabel.AutoSize = true;
               this.topFollowerLabel.Location = new System.Drawing.Point(182, 43);
               this.topFollowerLabel.Name = "topFollowerLabel";
               this.topFollowerLabel.Size = new System.Drawing.Size(0, 17);
               this.topFollowerLabel.TabIndex = 2;
               // 
               // followersListBox
               // 
               this.followersListBox.FormattingEnabled = true;
               this.followersListBox.ItemHeight = 16;
               this.followersListBox.Location = new System.Drawing.Point(6, 43);
               this.followersListBox.Name = "followersListBox";
               this.followersListBox.Size = new System.Drawing.Size(170, 132);
               this.followersListBox.TabIndex = 1;
               // 
               // findFollowersButton
               // 
               this.findFollowersButton.Location = new System.Drawing.Point(6, 6);
               this.findFollowersButton.Name = "findFollowersButton";
               this.findFollowersButton.Size = new System.Drawing.Size(170, 31);
               this.findFollowersButton.TabIndex = 0;
               this.findFollowersButton.Text = "Find My Top Follower";
               this.findFollowersButton.UseVisualStyleBackColor = true;
               this.findFollowersButton.Click += new System.EventHandler(this.findFollowersButton_Click);
               // 
               // commonTab
               // 
               this.commonTab.Controls.Add(this.feedInCommon);
               this.commonTab.Controls.Add(this.photosInCommonPanel);
               this.commonTab.Controls.Add(this.groupBox1);
               this.commonTab.Controls.Add(this.commonIntro);
               this.commonTab.Controls.Add(this.commonPages);
               this.commonTab.Controls.Add(this.findCommonButton);
               this.commonTab.Controls.Add(this.friendsCommonListBox);
               this.commonTab.Location = new System.Drawing.Point(4, 25);
               this.commonTab.Name = "commonTab";
               this.commonTab.Size = new System.Drawing.Size(851, 555);
               this.commonTab.TabIndex = 2;
               this.commonTab.Text = "Common Finder";
               this.commonTab.UseVisualStyleBackColor = true;
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.friendsInCommonPic);
               this.groupBox1.Controls.Add(this.friendsInCommonListBox);
               this.groupBox1.Location = new System.Drawing.Point(400, 19);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(153, 120);
               this.groupBox1.TabIndex = 24;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Friends In Common";
               // 
               // friendsInCommonPic
               // 
               this.friendsInCommonPic.Location = new System.Drawing.Point(105, 73);
               this.friendsInCommonPic.Name = "friendsInCommonPic";
               this.friendsInCommonPic.Size = new System.Drawing.Size(48, 41);
               this.friendsInCommonPic.TabIndex = 27;
               this.friendsInCommonPic.TabStop = false;
               // 
               // commonIntro
               // 
               this.commonIntro.Controls.Add(this.introInCommonText);
               this.commonIntro.Location = new System.Drawing.Point(17, 273);
               this.commonIntro.Name = "commonIntro";
               this.commonIntro.Size = new System.Drawing.Size(321, 183);
               this.commonIntro.TabIndex = 23;
               this.commonIntro.TabStop = false;
               this.commonIntro.Text = "Intro In Common";
               // 
               // introInCommonText
               // 
               this.introInCommonText.Location = new System.Drawing.Point(6, 21);
               this.introInCommonText.Multiline = true;
               this.introInCommonText.Name = "introInCommonText";
               this.introInCommonText.Size = new System.Drawing.Size(309, 156);
               this.introInCommonText.TabIndex = 0;
               // 
               // commonPages
               // 
               this.commonPages.Controls.Add(this.pagesInCommonPic);
               this.commonPages.Controls.Add(this.pagesInCommonListBox);
               this.commonPages.Location = new System.Drawing.Point(559, 19);
               this.commonPages.Name = "commonPages";
               this.commonPages.Size = new System.Drawing.Size(160, 120);
               this.commonPages.TabIndex = 22;
               this.commonPages.TabStop = false;
               this.commonPages.Text = "Pages In Common";
               // 
               // pagesInCommonPic
               // 
               this.pagesInCommonPic.Location = new System.Drawing.Point(106, 73);
               this.pagesInCommonPic.Name = "pagesInCommonPic";
               this.pagesInCommonPic.Size = new System.Drawing.Size(48, 41);
               this.pagesInCommonPic.TabIndex = 28;
               this.pagesInCommonPic.TabStop = false;
               // 
               // findCommonButton
               // 
               this.findCommonButton.Location = new System.Drawing.Point(17, 228);
               this.findCommonButton.Name = "findCommonButton";
               this.findCommonButton.Size = new System.Drawing.Size(117, 29);
               this.findCommonButton.TabIndex = 20;
               this.findCommonButton.Text = "Find Common";
               this.findCommonButton.UseVisualStyleBackColor = true;
               this.findCommonButton.Click += new System.EventHandler(this.findCommonButton_Click);
               // 
               // friendsCommonListBox
               // 
               this.friendsCommonListBox.FormattingEnabled = true;
               this.friendsCommonListBox.HorizontalScrollbar = true;
               this.friendsCommonListBox.ItemHeight = 16;
               this.friendsCommonListBox.Location = new System.Drawing.Point(17, 14);
               this.friendsCommonListBox.Name = "friendsCommonListBox";
               this.friendsCommonListBox.ScrollAlwaysVisible = true;
               this.friendsCommonListBox.Size = new System.Drawing.Size(164, 196);
               this.friendsCommonListBox.TabIndex = 19;
               // 
               // rememberCheckbox
               // 
               this.rememberCheckbox.AutoSize = true;
               this.rememberCheckbox.Location = new System.Drawing.Point(713, 125);
               this.rememberCheckbox.Name = "rememberCheckbox";
               this.rememberCheckbox.Size = new System.Drawing.Size(122, 21);
               this.rememberCheckbox.TabIndex = 19;
               this.rememberCheckbox.Text = "Remember Me";
               this.rememberCheckbox.UseVisualStyleBackColor = true;
               // 
               // feed
               // 
               this.feed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.feed.Location = new System.Drawing.Point(215, 158);
               this.feed.Name = "feed";
               this.feed.Size = new System.Drawing.Size(399, 370);
               this.feed.TabIndex = 17;
               // 
               // listBoxFriends
               // 
               this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Left;
               this.listBoxFriends.Location = new System.Drawing.Point(3, 18);
               this.listBoxFriends.Name = "listBoxFriends";
               this.listBoxFriends.PicBox = null;
               this.listBoxFriends.Size = new System.Drawing.Size(130, 143);
               this.listBoxFriends.TabIndex = 18;
               // 
               // likedPagesListBox
               // 
               this.likedPagesListBox.Location = new System.Drawing.Point(4, 29);
               this.likedPagesListBox.Name = "likedPagesListBox";
               this.likedPagesListBox.PicBox = null;
               this.likedPagesListBox.Size = new System.Drawing.Size(130, 132);
               this.likedPagesListBox.TabIndex = 19;
               // 
               // listBoxEvents
               // 
               this.listBoxEvents.Location = new System.Drawing.Point(0, 21);
               this.listBoxEvents.Name = "listBoxEvents";
               this.listBoxEvents.PicBox = null;
               this.listBoxEvents.Size = new System.Drawing.Size(130, 143);
               this.listBoxEvents.TabIndex = 16;
               // 
               // listBoxCheckins
               // 
               this.listBoxCheckins.Location = new System.Drawing.Point(0, 32);
               this.listBoxCheckins.Name = "listBoxCheckins";
               this.listBoxCheckins.PicBox = null;
               this.listBoxCheckins.Size = new System.Drawing.Size(130, 132);
               this.listBoxCheckins.TabIndex = 18;
               // 
               // photoPanel
               // 
               this.photoPanel.Location = new System.Drawing.Point(0, 0);
               this.photoPanel.Name = "photoPanel";
               this.photoPanel.Size = new System.Drawing.Size(200, 164);
               this.photoPanel.TabIndex = 0;
               // 
               // topFollowerPosts
               // 
               this.topFollowerPosts.Location = new System.Drawing.Point(391, 43);
               this.topFollowerPosts.Name = "topFollowerPosts";
               this.topFollowerPosts.Size = new System.Drawing.Size(399, 372);
               this.topFollowerPosts.TabIndex = 5;
               // 
               // topFollowerPhotos
               // 
               this.topFollowerPhotos.Location = new System.Drawing.Point(185, 140);
               this.topFollowerPhotos.Name = "topFollowerPhotos";
               this.topFollowerPhotos.Size = new System.Drawing.Size(200, 164);
               this.topFollowerPhotos.TabIndex = 4;
               // 
               // feedInCommon
               // 
               this.feedInCommon.Location = new System.Drawing.Point(400, 148);
               this.feedInCommon.Name = "feedInCommon";
               this.feedInCommon.Size = new System.Drawing.Size(399, 372);
               this.feedInCommon.TabIndex = 26;
               // 
               // photosInCommonPanel
               // 
               this.photosInCommonPanel.Location = new System.Drawing.Point(187, 14);
               this.photosInCommonPanel.Name = "photosInCommonPanel";
               this.photosInCommonPanel.Size = new System.Drawing.Size(207, 168);
               this.photosInCommonPanel.TabIndex = 25;
               // 
               // friendsInCommonListBox
               // 
               this.friendsInCommonListBox.Location = new System.Drawing.Point(6, 21);
               this.friendsInCommonListBox.Name = "friendsInCommonListBox";
               this.friendsInCommonListBox.PicBox = null;
               this.friendsInCommonListBox.Size = new System.Drawing.Size(141, 93);
               this.friendsInCommonListBox.TabIndex = 0;
               // 
               // pagesInCommonListBox
               // 
               this.pagesInCommonListBox.Location = new System.Drawing.Point(6, 21);
               this.pagesInCommonListBox.Name = "pagesInCommonListBox";
               this.pagesInCommonListBox.PicBox = null;
               this.pagesInCommonListBox.Size = new System.Drawing.Size(141, 90);
               this.pagesInCommonListBox.TabIndex = 0;
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(876, 764);
               this.Controls.Add(this.rememberCheckbox);
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
               this.followersTab.ResumeLayout(false);
               this.followersTab.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.topFollowerPic)).EndInit();
               this.commonTab.ResumeLayout(false);
               this.groupBox1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.friendsInCommonPic)).EndInit();
               this.commonIntro.ResumeLayout(false);
               this.commonIntro.PerformLayout();
               this.commonPages.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pagesInCommonPic)).EndInit();
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
          private System.Windows.Forms.GroupBox groupBoxEvents;
          private System.Windows.Forms.PictureBox pictureBoxEvent;
          private System.Windows.Forms.GroupBox groupBoxCheckins;
          private System.Windows.Forms.PictureBox pictureBoxCheckin;
          private System.Windows.Forms.GroupBox groupBoxLikedPages;
          private System.Windows.Forms.PictureBox pictureBoxLikedPage;
          private System.Windows.Forms.Button buttonRefresh;
          protected System.Windows.Forms.TextBox textBoxIntro;
          private System.Windows.Forms.Button buttonGetPicturePath;
          private System.Windows.Forms.TextBox textBoxPicturePath;
          private Feed feed;
          private PhotoPanel photoPanel;
        private System.Windows.Forms.TabControl featuresTabs;
        private System.Windows.Forms.TabPage timelineTab;
        private System.Windows.Forms.TabPage followersTab;
        private System.Windows.Forms.TabPage commonTab;
        private System.Windows.Forms.GroupBox commonIntro;
        private System.Windows.Forms.GroupBox commonPages;
        private System.Windows.Forms.Button findCommonButton;
        private System.Windows.Forms.ListBox friendsCommonListBox;
        private FriendsListBox listBoxFriends;
        private EventsListBox listBoxEvents;
        private PagesListBox likedPagesListBox;
        private CheckinsListBox listBoxCheckins;
        private FriendsListBox friendsInCommonListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private PagesListBox pagesInCommonListBox;
        private PhotoPanel photosInCommonPanel;
        private System.Windows.Forms.TextBox introInCommonText;
        private Feed feedInCommon;
        private System.Windows.Forms.PictureBox friendsInCommonPic;
        private System.Windows.Forms.PictureBox pagesInCommonPic;
        private System.Windows.Forms.CheckBox rememberCheckbox;
        private System.Windows.Forms.Button findFollowersButton;
        private System.Windows.Forms.ListBox followersListBox;
        private System.Windows.Forms.Label topFollowerLabel;
        private System.Windows.Forms.PictureBox topFollowerPic;
        private Feed topFollowerPosts;
        private PhotoPanel topFollowerPhotos;
    }
}