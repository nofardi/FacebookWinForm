namespace FacebookApp
{
    partial class EventsListBox
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
            this.eventsList.FormattingEnabled = true;
            this.eventsList.ItemHeight = 16;
            this.eventsList.Location = new System.Drawing.Point(3, 3);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(144, 132);
            this.eventsList.TabIndex = 0;
            // 
            // EventsListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventsList);
            this.Name = "EventsListBox";
            this.Size = new System.Drawing.Size(150, 139);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox eventsList;
    }
}
