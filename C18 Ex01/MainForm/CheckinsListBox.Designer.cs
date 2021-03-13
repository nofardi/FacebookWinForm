namespace FacebookApp
{
   public partial class CheckinsListBox
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
               this.checkinList = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // checkinList
               // 
               this.checkinList.Dock = System.Windows.Forms.DockStyle.Fill;
               this.checkinList.FormattingEnabled = true;
               this.checkinList.ItemHeight = 16;
               this.checkinList.Location = new System.Drawing.Point(0, 0);
               this.checkinList.Name = "checkinList";
               this.checkinList.ScrollAlwaysVisible = true;
               this.checkinList.Size = new System.Drawing.Size(137, 137);
               this.checkinList.TabIndex = 0;
               this.checkinList.SelectedIndexChanged += new System.EventHandler(this.onIndexSelectChanged);
               // 
               // CheckinsListBox
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.checkinList);
               this.Name = "CheckinsListBox";
               this.Size = new System.Drawing.Size(137, 137);
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox checkinList;
    }
}
