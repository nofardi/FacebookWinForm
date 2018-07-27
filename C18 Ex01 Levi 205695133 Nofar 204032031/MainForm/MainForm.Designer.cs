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
               this.labelWelcome = new System.Windows.Forms.Label();
               this.textBoxPost = new System.Windows.Forms.TextBox();
               this.buttonPost = new System.Windows.Forms.Button();
               this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
               this.groupBoxFriends = new System.Windows.Forms.GroupBox();
               this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
               this.listBoxFriends = new System.Windows.Forms.ListBox();
               this.groupBoxPhotos = new System.Windows.Forms.GroupBox();
               this.groupBoxIntro = new System.Windows.Forms.GroupBox();
               this.groupBoxEvents = new System.Windows.Forms.GroupBox();
               this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
               this.listBoxEvents = new System.Windows.Forms.ListBox();
               this.groupBoxCheckins = new System.Windows.Forms.GroupBox();
               this.pictureBoxCheckin = new System.Windows.Forms.PictureBox();
               this.listBoxCheckins = new System.Windows.Forms.ListBox();
               this.groupBoxLikedPages = new System.Windows.Forms.GroupBox();
               this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
               this.listBoxLikedPages = new System.Windows.Forms.ListBox();
               this.listBoxPosts = new System.Windows.Forms.ListBox();
               this.buttonRefresh = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
               this.groupBoxFriends.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
               this.groupBoxEvents.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
               this.groupBoxCheckins.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).BeginInit();
               this.groupBoxLikedPages.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
               this.SuspendLayout();
               // 
               // buttonLogIn
               // 
               this.buttonLogIn.BackColor = System.Drawing.SystemColors.Menu;
               this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonLogIn.Location = new System.Drawing.Point(619, 12);
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
               this.buttonLogOut.Location = new System.Drawing.Point(700, 12);
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
               this.pictureBoxUserPicture.Location = new System.Drawing.Point(33, 65);
               this.pictureBoxUserPicture.Name = "pictureBoxUserPicture";
               this.pictureBoxUserPicture.Size = new System.Drawing.Size(126, 117);
               this.pictureBoxUserPicture.TabIndex = 2;
               this.pictureBoxUserPicture.TabStop = false;
               // 
               // labelWelcome
               // 
               this.labelWelcome.AutoSize = true;
               this.labelWelcome.BackColor = System.Drawing.SystemColors.HotTrack;
               this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelWelcome.ForeColor = System.Drawing.Color.White;
               this.labelWelcome.Location = new System.Drawing.Point(165, 125);
               this.labelWelcome.Name = "labelWelcome";
               this.labelWelcome.Size = new System.Drawing.Size(0, 31);
               this.labelWelcome.TabIndex = 4;
               // 
               // textBoxPost
               // 
               this.textBoxPost.Enabled = false;
               this.textBoxPost.Location = new System.Drawing.Point(231, 211);
               this.textBoxPost.Name = "textBoxPost";
               this.textBoxPost.Size = new System.Drawing.Size(333, 22);
               this.textBoxPost.TabIndex = 5;
               this.textBoxPost.Enter += new System.EventHandler(this.textBoxPost_Enter);
               // 
               // buttonPost
               // 
               this.buttonPost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.buttonPost.Enabled = false;
               this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonPost.Location = new System.Drawing.Point(489, 239);
               this.buttonPost.Name = "buttonPost";
               this.buttonPost.Size = new System.Drawing.Size(75, 31);
               this.buttonPost.TabIndex = 6;
               this.buttonPost.Text = "Post";
               this.buttonPost.UseVisualStyleBackColor = false;
               this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
               // 
               // pictureBoxBackGround
               // 
               this.pictureBoxBackGround.BackColor = System.Drawing.SystemColors.Control;
               this.pictureBoxBackGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.pictureBoxBackGround.Location = new System.Drawing.Point(12, 3);
               this.pictureBoxBackGround.Name = "pictureBoxBackGround";
               this.pictureBoxBackGround.Size = new System.Drawing.Size(780, 163);
               this.pictureBoxBackGround.TabIndex = 7;
               this.pictureBoxBackGround.TabStop = false;
               // 
               // groupBoxFriends
               // 
               this.groupBoxFriends.Controls.Add(this.pictureBoxFriend);
               this.groupBoxFriends.Controls.Add(this.listBoxFriends);
               this.groupBoxFriends.Location = new System.Drawing.Point(13, 548);
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
               this.pictureBoxFriend.Size = new System.Drawing.Size(60, 62);
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
               this.groupBoxPhotos.Location = new System.Drawing.Point(13, 378);
               this.groupBoxPhotos.Name = "groupBoxPhotos";
               this.groupBoxPhotos.Size = new System.Drawing.Size(200, 164);
               this.groupBoxPhotos.TabIndex = 9;
               this.groupBoxPhotos.TabStop = false;
               this.groupBoxPhotos.Text = "Photos";
               // 
               // groupBoxIntro
               // 
               this.groupBoxIntro.Location = new System.Drawing.Point(13, 202);
               this.groupBoxIntro.Name = "groupBoxIntro";
               this.groupBoxIntro.Size = new System.Drawing.Size(200, 164);
               this.groupBoxIntro.TabIndex = 10;
               this.groupBoxIntro.TabStop = false;
               this.groupBoxIntro.Text = "Intro";
               // 
               // groupBoxEvents
               // 
               this.groupBoxEvents.Controls.Add(this.pictureBoxEvent);
               this.groupBoxEvents.Controls.Add(this.listBoxEvents);
               this.groupBoxEvents.Location = new System.Drawing.Point(592, 202);
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
               this.pictureBoxEvent.Size = new System.Drawing.Size(60, 62);
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
               this.groupBoxCheckins.Location = new System.Drawing.Point(592, 378);
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
               this.pictureBoxCheckin.Size = new System.Drawing.Size(60, 62);
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
               this.groupBoxLikedPages.Location = new System.Drawing.Point(592, 548);
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
               this.pictureBoxLikedPage.Size = new System.Drawing.Size(60, 62);
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
               // listBoxPosts
               // 
               this.listBoxPosts.FormattingEnabled = true;
               this.listBoxPosts.HorizontalScrollbar = true;
               this.listBoxPosts.ItemHeight = 16;
               this.listBoxPosts.Location = new System.Drawing.Point(231, 294);
               this.listBoxPosts.Name = "listBoxPosts";
               this.listBoxPosts.ScrollAlwaysVisible = true;
               this.listBoxPosts.Size = new System.Drawing.Size(333, 356);
               this.listBoxPosts.TabIndex = 13;
               // 
               // buttonRefresh
               // 
               this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonRefresh.Location = new System.Drawing.Point(489, 656);
               this.buttonRefresh.Name = "buttonRefresh";
               this.buttonRefresh.Size = new System.Drawing.Size(75, 27);
               this.buttonRefresh.TabIndex = 14;
               this.buttonRefresh.Text = "Refresh";
               this.buttonRefresh.UseVisualStyleBackColor = false;
               this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(804, 724);
               this.Controls.Add(this.buttonRefresh);
               this.Controls.Add(this.listBoxPosts);
               this.Controls.Add(this.groupBoxLikedPages);
               this.Controls.Add(this.groupBoxCheckins);
               this.Controls.Add(this.groupBoxEvents);
               this.Controls.Add(this.groupBoxIntro);
               this.Controls.Add(this.groupBoxPhotos);
               this.Controls.Add(this.groupBoxFriends);
               this.Controls.Add(this.buttonPost);
               this.Controls.Add(this.textBoxPost);
               this.Controls.Add(this.labelWelcome);
               this.Controls.Add(this.pictureBoxUserPicture);
               this.Controls.Add(this.buttonLogOut);
               this.Controls.Add(this.buttonLogIn);
               this.Controls.Add(this.pictureBoxBackGround);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Name = "MainForm";
               this.Text = "Facebook Form";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
               this.groupBoxFriends.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
               this.groupBoxEvents.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
               this.groupBoxCheckins.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).EndInit();
               this.groupBoxLikedPages.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button buttonLogIn;
          private System.Windows.Forms.Button buttonLogOut;
          private System.Windows.Forms.PictureBox pictureBoxUserPicture;
          private System.Windows.Forms.Label labelWelcome;
          private System.Windows.Forms.TextBox textBoxPost;
          private System.Windows.Forms.Button buttonPost;
          private System.Windows.Forms.PictureBox pictureBoxBackGround;
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
          private System.Windows.Forms.ListBox listBoxPosts;
          private System.Windows.Forms.Button buttonRefresh;
     }
}

