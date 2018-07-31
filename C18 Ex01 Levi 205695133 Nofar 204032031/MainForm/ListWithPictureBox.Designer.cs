namespace FacebookApp
{
     partial class ListWithPictureBox
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
               this.groupBox = new System.Windows.Forms.GroupBox();
               this.pictureBox = new System.Windows.Forms.PictureBox();
               this.listBox = new System.Windows.Forms.ListBox();
               this.groupBox.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
               this.SuspendLayout();
               // 
               // groupBox
               // 
               this.groupBox.Controls.Add(this.pictureBox);
               this.groupBox.Controls.Add(this.listBox);
               this.groupBox.Location = new System.Drawing.Point(0, 0);
               this.groupBox.Name = "groupBox";
               this.groupBox.Size = new System.Drawing.Size(201, 159);
               this.groupBox.TabIndex = 0;
               this.groupBox.TabStop = false;
               this.groupBox.Text = "groupBox";
               // 
               // pictureBox
               // 
               this.pictureBox.Location = new System.Drawing.Point(134, 21);
               this.pictureBox.Name = "pictureBox";
               this.pictureBox.Size = new System.Drawing.Size(60, 60);
               this.pictureBox.TabIndex = 1;
               this.pictureBox.TabStop = false;
               // 
               // listBox
               // 
               this.listBox.FormattingEnabled = true;
               this.listBox.ItemHeight = 16;
               this.listBox.Location = new System.Drawing.Point(5, 21);
               this.listBox.Name = "listBox";
               this.listBox.Size = new System.Drawing.Size(128, 132);
               this.listBox.TabIndex = 0;
               //this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
               // 
               // ListWithPictureBox
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.groupBox);
               this.Name = "ListWithPictureBox";
               this.Size = new System.Drawing.Size(207, 165);
               this.groupBox.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.GroupBox groupBox;
          private System.Windows.Forms.ListBox listBox;
          private System.Windows.Forms.PictureBox pictureBox;
     }
}
