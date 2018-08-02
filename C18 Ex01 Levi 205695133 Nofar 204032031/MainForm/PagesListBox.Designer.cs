namespace FacebookApp
{
    public partial class PagesListBox
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
               this.pagesList = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // pagesList
               // 
               this.pagesList.Dock = System.Windows.Forms.DockStyle.Fill;
               this.pagesList.FormattingEnabled = true;
               this.pagesList.ItemHeight = 16;
               this.pagesList.Location = new System.Drawing.Point(0, 0);
               this.pagesList.Name = "pagesList";
               this.pagesList.ScrollAlwaysVisible = true;
               this.pagesList.Size = new System.Drawing.Size(137, 137);
               this.pagesList.TabIndex = 0;
               this.pagesList.SelectedIndexChanged += new System.EventHandler(this.onIndexSelectChanged);
               // 
               // PagesListBox
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.pagesList);
               this.Name = "PagesListBox";
               this.Size = new System.Drawing.Size(137, 137);
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox pagesList;
    }
}
