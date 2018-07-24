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
               this.listBoxFriends = new System.Windows.Forms.ListBox();
               this.labelWelcome = new System.Windows.Forms.Label();
               this.textBoxPost = new System.Windows.Forms.TextBox();
               this.buttonPost = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).BeginInit();
               this.SuspendLayout();
               // 
               // buttonLogIn
               // 
               this.buttonLogIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonLogIn.Location = new System.Drawing.Point(12, 12);
               this.buttonLogIn.Name = "buttonLogIn";
               this.buttonLogIn.Size = new System.Drawing.Size(75, 31);
               this.buttonLogIn.TabIndex = 0;
               this.buttonLogIn.Text = "LogIn";
               this.buttonLogIn.UseVisualStyleBackColor = false;
               this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
               // 
               // buttonLogOut
               // 
               this.buttonLogOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonLogOut.Location = new System.Drawing.Point(93, 12);
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
               this.pictureBoxUserPicture.Location = new System.Drawing.Point(12, 49);
               this.pictureBoxUserPicture.Name = "pictureBoxUserPicture";
               this.pictureBoxUserPicture.Size = new System.Drawing.Size(126, 117);
               this.pictureBoxUserPicture.TabIndex = 2;
               this.pictureBoxUserPicture.TabStop = false;
               // 
               // listBoxFriends
               // 
               this.listBoxFriends.FormattingEnabled = true;
               this.listBoxFriends.ItemHeight = 16;
               this.listBoxFriends.Location = new System.Drawing.Point(12, 189);
               this.listBoxFriends.Name = "listBoxFriends";
               this.listBoxFriends.Size = new System.Drawing.Size(126, 164);
               this.listBoxFriends.TabIndex = 3;
               // 
               // labelWelcome
               // 
               this.labelWelcome.AutoSize = true;
               this.labelWelcome.Location = new System.Drawing.Point(174, 19);
               this.labelWelcome.Name = "labelWelcome";
               this.labelWelcome.Size = new System.Drawing.Size(46, 17);
               this.labelWelcome.TabIndex = 4;
               this.labelWelcome.Text = "label1";
               // 
               // textBoxPost
               // 
               this.textBoxPost.Location = new System.Drawing.Point(177, 61);
               this.textBoxPost.Name = "textBoxPost";
               this.textBoxPost.Size = new System.Drawing.Size(227, 22);
               this.textBoxPost.TabIndex = 5;
               // 
               // buttonPost
               // 
               this.buttonPost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonPost.Location = new System.Drawing.Point(177, 89);
               this.buttonPost.Name = "buttonPost";
               this.buttonPost.Size = new System.Drawing.Size(75, 31);
               this.buttonPost.TabIndex = 6;
               this.buttonPost.Text = "Post";
               this.buttonPost.UseVisualStyleBackColor = false;
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(627, 476);
               this.Controls.Add(this.buttonPost);
               this.Controls.Add(this.textBoxPost);
               this.Controls.Add(this.labelWelcome);
               this.Controls.Add(this.listBoxFriends);
               this.Controls.Add(this.pictureBoxUserPicture);
               this.Controls.Add(this.buttonLogOut);
               this.Controls.Add(this.buttonLogIn);
               this.Name = "MainForm";
               this.Text = "Facebook Form";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button buttonLogIn;
          private System.Windows.Forms.Button buttonLogOut;
          private System.Windows.Forms.PictureBox pictureBoxUserPicture;
          private System.Windows.Forms.ListBox listBoxFriends;
          private System.Windows.Forms.Label labelWelcome;
          private System.Windows.Forms.TextBox textBoxPost;
          private System.Windows.Forms.Button buttonPost;
     }
}

