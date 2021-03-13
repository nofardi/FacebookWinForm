namespace FacebookApp
{
    public partial class EventsListBox
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
               this.eventsList = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // eventsList
               // 
               this.eventsList.Dock = System.Windows.Forms.DockStyle.Fill;
               this.eventsList.FormattingEnabled = true;
               this.eventsList.ItemHeight = 16;
               this.eventsList.Location = new System.Drawing.Point(0, 0);
               this.eventsList.Name = "eventsList";
               this.eventsList.ScrollAlwaysVisible = true;
               this.eventsList.Size = new System.Drawing.Size(137, 137);
               this.eventsList.TabIndex = 0;
               this.eventsList.SelectedIndexChanged += new System.EventHandler(this.onIndexSelectChanged);
               // 
               // EventsListBox
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.eventsList);
               this.Name = "EventsListBox";
               this.Size = new System.Drawing.Size(137, 137);
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox eventsList;
    }
}
