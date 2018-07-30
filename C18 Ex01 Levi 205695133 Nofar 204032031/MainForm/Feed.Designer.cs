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
               this.flowLayoutPanelFeed = new System.Windows.Forms.FlowLayoutPanel();
               this.SuspendLayout();
               // 
               // flowLayoutPanelFeed
               // 
               this.flowLayoutPanelFeed.AutoScroll = true;
               this.flowLayoutPanelFeed.Location = new System.Drawing.Point(0, 0);
               this.flowLayoutPanelFeed.Name = "flowLayoutPanelFeed";
               this.flowLayoutPanelFeed.Size = new System.Drawing.Size(399, 369);
               this.flowLayoutPanelFeed.TabIndex = 1;
               // 
               // Feed
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.flowLayoutPanelFeed);
               this.Name = "Feed";
               this.Size = new System.Drawing.Size(399, 372);
               this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFeed;
     }
}
