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
               this.groupBoxPhotos = new System.Windows.Forms.GroupBox();
               this.groupBoxIntro = new System.Windows.Forms.GroupBox();
               this.groupBoxEvents = new System.Windows.Forms.GroupBox();
               this.groupBoxCheckins = new System.Windows.Forms.GroupBox();
               this.groupBoxLikedPages = new System.Windows.Forms.GroupBox();
               this.listBoxPosts = new System.Windows.Forms.ListBox();
               this.listBox1 = new System.Windows.Forms.ListBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.listBox2 = new System.Windows.Forms.ListBox();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.listBox3 = new System.Windows.Forms.ListBox();
               this.pictureBox4 = new System.Windows.Forms.PictureBox();
               this.listBox4 = new System.Windows.Forms.ListBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
               this.groupBoxFriends.SuspendLayout();
               this.groupBoxEvents.SuspendLayout();
               this.groupBoxCheckins.SuspendLayout();
               this.groupBoxLikedPages.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
               this.labelWelcome.Size = new System.Drawing.Size(289, 31);
               this.labelWelcome.TabIndex = 4;
               this.labelWelcome.Text = "FirstName LastName";
               // 
               // textBoxPost
               // 
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
               this.pictureBoxBackGround.BackColor = System.Drawing.SystemColors.HotTrack;
               this.pictureBoxBackGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.pictureBoxBackGround.Location = new System.Drawing.Point(12, 3);
               this.pictureBoxBackGround.Name = "pictureBoxBackGround";
               this.pictureBoxBackGround.Size = new System.Drawing.Size(780, 163);
               this.pictureBoxBackGround.TabIndex = 7;
               this.pictureBoxBackGround.TabStop = false;
               // 
               // groupBoxFriends
               // 
               this.groupBoxFriends.Controls.Add(this.pictureBox4);
               this.groupBoxFriends.Controls.Add(this.listBox4);
               this.groupBoxFriends.Location = new System.Drawing.Point(13, 548);
               this.groupBoxFriends.Name = "groupBoxFriends";
               this.groupBoxFriends.Size = new System.Drawing.Size(200, 164);
               this.groupBoxFriends.TabIndex = 8;
               this.groupBoxFriends.TabStop = false;
               this.groupBoxFriends.Text = "Friends";
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
               this.groupBoxEvents.Controls.Add(this.pictureBox1);
               this.groupBoxEvents.Controls.Add(this.listBox1);
               this.groupBoxEvents.Location = new System.Drawing.Point(592, 202);
               this.groupBoxEvents.Name = "groupBoxEvents";
               this.groupBoxEvents.Size = new System.Drawing.Size(200, 164);
               this.groupBoxEvents.TabIndex = 11;
               this.groupBoxEvents.TabStop = false;
               this.groupBoxEvents.Text = "Events";
               // 
               // groupBoxCheckins
               // 
               this.groupBoxCheckins.Controls.Add(this.pictureBox2);
               this.groupBoxCheckins.Controls.Add(this.listBox2);
               this.groupBoxCheckins.Location = new System.Drawing.Point(592, 378);
               this.groupBoxCheckins.Name = "groupBoxCheckins";
               this.groupBoxCheckins.Size = new System.Drawing.Size(200, 164);
               this.groupBoxCheckins.TabIndex = 12;
               this.groupBoxCheckins.TabStop = false;
               this.groupBoxCheckins.Text = "Checkins";
               // 
               // groupBoxLikedPages
               // 
               this.groupBoxLikedPages.Controls.Add(this.pictureBox3);
               this.groupBoxLikedPages.Controls.Add(this.listBox3);
               this.groupBoxLikedPages.Location = new System.Drawing.Point(592, 548);
               this.groupBoxLikedPages.Name = "groupBoxLikedPages";
               this.groupBoxLikedPages.Size = new System.Drawing.Size(200, 164);
               this.groupBoxLikedPages.TabIndex = 12;
               this.groupBoxLikedPages.TabStop = false;
               this.groupBoxLikedPages.Text = "Liked Pages";
               // 
               // listBoxPosts
               // 
               this.listBoxPosts.FormattingEnabled = true;
               this.listBoxPosts.ItemHeight = 16;
               this.listBoxPosts.Location = new System.Drawing.Point(231, 294);
               this.listBoxPosts.Name = "listBoxPosts";
               this.listBoxPosts.Size = new System.Drawing.Size(333, 212);
               this.listBoxPosts.TabIndex = 13;
               // 
               // listBox1
               // 
               this.listBox1.FormattingEnabled = true;
               this.listBox1.ItemHeight = 16;
               this.listBox1.Location = new System.Drawing.Point(6, 26);
               this.listBox1.Name = "listBox1";
               this.listBox1.Size = new System.Drawing.Size(131, 132);
               this.listBox1.TabIndex = 14;
               // 
               // pictureBox1
               // 
               this.pictureBox1.Location = new System.Drawing.Point(140, 9);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(60, 62);
               this.pictureBox1.TabIndex = 15;
               this.pictureBox1.TabStop = false;
               // 
               // pictureBox2
               // 
               this.pictureBox2.Location = new System.Drawing.Point(140, 9);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(60, 62);
               this.pictureBox2.TabIndex = 17;
               this.pictureBox2.TabStop = false;
               // 
               // listBox2
               // 
               this.listBox2.FormattingEnabled = true;
               this.listBox2.ItemHeight = 16;
               this.listBox2.Location = new System.Drawing.Point(6, 26);
               this.listBox2.Name = "listBox2";
               this.listBox2.Size = new System.Drawing.Size(131, 132);
               this.listBox2.TabIndex = 16;
               // 
               // pictureBox3
               // 
               this.pictureBox3.Location = new System.Drawing.Point(140, 9);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(60, 62);
               this.pictureBox3.TabIndex = 19;
               this.pictureBox3.TabStop = false;
               // 
               // listBox3
               // 
               this.listBox3.FormattingEnabled = true;
               this.listBox3.ItemHeight = 16;
               this.listBox3.Location = new System.Drawing.Point(6, 26);
               this.listBox3.Name = "listBox3";
               this.listBox3.Size = new System.Drawing.Size(131, 132);
               this.listBox3.TabIndex = 18;
               // 
               // pictureBox4
               // 
               this.pictureBox4.Location = new System.Drawing.Point(140, 9);
               this.pictureBox4.Name = "pictureBox4";
               this.pictureBox4.Size = new System.Drawing.Size(60, 62);
               this.pictureBox4.TabIndex = 21;
               this.pictureBox4.TabStop = false;
               // 
               // listBox4
               // 
               this.listBox4.FormattingEnabled = true;
               this.listBox4.ItemHeight = 16;
               this.listBox4.Location = new System.Drawing.Point(6, 26);
               this.listBox4.Name = "listBox4";
               this.listBox4.Size = new System.Drawing.Size(131, 132);
               this.listBox4.TabIndex = 20;
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(804, 724);
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
               this.Name = "MainForm";
               this.Text = "Facebook Form";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
               this.groupBoxFriends.ResumeLayout(false);
               this.groupBoxEvents.ResumeLayout(false);
               this.groupBoxCheckins.ResumeLayout(false);
               this.groupBoxLikedPages.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
          private System.Windows.Forms.PictureBox pictureBox4;
          private System.Windows.Forms.ListBox listBox4;
          private System.Windows.Forms.GroupBox groupBoxEvents;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.ListBox listBox1;
          private System.Windows.Forms.GroupBox groupBoxCheckins;
          private System.Windows.Forms.PictureBox pictureBox2;
          private System.Windows.Forms.ListBox listBox2;
          private System.Windows.Forms.GroupBox groupBoxLikedPages;
          private System.Windows.Forms.PictureBox pictureBox3;
          private System.Windows.Forms.ListBox listBox3;
          private System.Windows.Forms.ListBox listBoxPosts;
     }
}

