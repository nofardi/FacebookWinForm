namespace FacebookApp
{
     partial class RegularPost
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.pictureBoxUser = new System.Windows.Forms.PictureBox();
               this.labelUserName = new System.Windows.Forms.Label();
               this.textBoxPost = new System.Windows.Forms.TextBox();
               this.labelTime = new System.Windows.Forms.Label();
               this.linkLabelLike = new System.Windows.Forms.LinkLabel();
               this.pictureBoxPicturePost = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicturePost)).BeginInit();
               this.SuspendLayout();
               // 
               // pictureBoxUser
               // 
               this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.pictureBoxUser.Location = new System.Drawing.Point(3, 0);
               this.pictureBoxUser.Name = "pictureBoxUser";
               this.pictureBoxUser.Size = new System.Drawing.Size(35, 35);
               this.pictureBoxUser.TabIndex = 0;
               this.pictureBoxUser.TabStop = false;
               // 
               // labelUserName
               // 
               this.labelUserName.AutoSize = true;
               this.labelUserName.BackColor = System.Drawing.Color.Transparent;
               this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelUserName.ForeColor = System.Drawing.Color.Blue;
               this.labelUserName.Location = new System.Drawing.Point(44, 0);
               this.labelUserName.Name = "labelUserName";
               this.labelUserName.Size = new System.Drawing.Size(84, 17);
               this.labelUserName.TabIndex = 1;
               this.labelUserName.Text = "user name";
               // 
               // textBoxPost
               // 
               this.textBoxPost.BackColor = System.Drawing.Color.White;
               this.textBoxPost.Location = new System.Drawing.Point(3, 37);
               this.textBoxPost.Multiline = true;
               this.textBoxPost.Name = "textBoxPost";
               this.textBoxPost.ReadOnly = true;
               this.textBoxPost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
               this.textBoxPost.Size = new System.Drawing.Size(214, 47);
               this.textBoxPost.TabIndex = 2;
               // 
               // labelTime
               // 
               this.labelTime.AutoSize = true;
               this.labelTime.ForeColor = System.Drawing.Color.Gray;
               this.labelTime.Location = new System.Drawing.Point(44, 17);
               this.labelTime.Name = "labelTime";
               this.labelTime.Size = new System.Drawing.Size(69, 17);
               this.labelTime.TabIndex = 4;
               this.labelTime.Text = "labelTime";
               // 
               // linkLabelLike
               // 
               this.linkLabelLike.AutoSize = true;
               this.linkLabelLike.Location = new System.Drawing.Point(4, 87);
               this.linkLabelLike.Name = "linkLabelLike";
               this.linkLabelLike.Size = new System.Drawing.Size(29, 17);
               this.linkLabelLike.TabIndex = 6;
               this.linkLabelLike.TabStop = true;
               this.linkLabelLike.Text = "like";
               // 
               // pictureBoxPicturePost
               // 
               this.pictureBoxPicturePost.Location = new System.Drawing.Point(223, 3);
               this.pictureBoxPicturePost.Name = "pictureBoxPicturePost";
               this.pictureBoxPicturePost.Size = new System.Drawing.Size(96, 84);
               this.pictureBoxPicturePost.TabIndex = 5;
               this.pictureBoxPicturePost.TabStop = false;
               // 
               // RegularPost
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.Controls.Add(this.linkLabelLike);
               this.Controls.Add(this.pictureBoxPicturePost);
               this.Controls.Add(this.labelTime);
               this.Controls.Add(this.textBoxPost);
               this.Controls.Add(this.labelUserName);
               this.Controls.Add(this.pictureBoxUser);
               this.Name = "RegularPost";
               this.Size = new System.Drawing.Size(320, 109);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicturePost)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.PictureBox pictureBoxUser;
          private System.Windows.Forms.Label labelUserName;
          private System.Windows.Forms.TextBox textBoxPost;
          private System.Windows.Forms.Label labelTime;
          private System.Windows.Forms.LinkLabel linkLabelLike;
          private System.Windows.Forms.PictureBox pictureBoxPicturePost;
     }
}
