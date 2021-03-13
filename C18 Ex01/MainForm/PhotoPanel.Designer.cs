namespace FacebookApp
{
     public partial class PhotoPanel
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
               this.groupBoxPhotos = new System.Windows.Forms.GroupBox();
               this.flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
               this.groupBoxPhotos.SuspendLayout();
               this.SuspendLayout();
               // 
               // groupBoxPhotos
               // 
               this.groupBoxPhotos.Controls.Add(this.flowLayoutPanelPhotos);
               this.groupBoxPhotos.Location = new System.Drawing.Point(0, 0);
               this.groupBoxPhotos.Name = "groupBoxPhotos";
               this.groupBoxPhotos.Size = new System.Drawing.Size(200, 164);
               this.groupBoxPhotos.TabIndex = 0;
               this.groupBoxPhotos.TabStop = false;
               this.groupBoxPhotos.Text = "Photos";
               // 
               // flowLayoutPanelPhotos
               // 
               this.flowLayoutPanelPhotos.AutoScroll = true;
               this.flowLayoutPanelPhotos.Location = new System.Drawing.Point(0, 21);
               this.flowLayoutPanelPhotos.Name = "flowLayoutPanelPhotos";
               this.flowLayoutPanelPhotos.Size = new System.Drawing.Size(200, 140);
               this.flowLayoutPanelPhotos.TabIndex = 0;
               // 
               // PhotoPanel
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.groupBoxPhotos);
               this.Name = "PhotoPanel";
               this.Size = new System.Drawing.Size(200, 164);
               this.groupBoxPhotos.ResumeLayout(false);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.GroupBox groupBoxPhotos;
          private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
     }
}
