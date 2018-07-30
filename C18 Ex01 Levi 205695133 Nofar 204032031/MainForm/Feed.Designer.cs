namespace FacebookApp
{
     partial class Feed
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
               this.panelFeed = new System.Windows.Forms.Panel();
               this.SuspendLayout();
               // 
               // panelFeed
               // 
               this.panelFeed.AutoScroll = true;
               this.panelFeed.BackColor = System.Drawing.Color.WhiteSmoke;
               this.panelFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panelFeed.Location = new System.Drawing.Point(0, 0);
               this.panelFeed.Name = "panelFeed";
               this.panelFeed.Size = new System.Drawing.Size(399, 372);
               this.panelFeed.TabIndex = 0;
               // 
               // Feed
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.panelFeed);
               this.Name = "Feed";
               this.Size = new System.Drawing.Size(399, 372);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panelFeed;
     }
}
