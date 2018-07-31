using System;
using System.Windows.Forms;

namespace FacebookApp
{
    partial class FriendsListBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

          public new AutoScaleMode AutoScaleMode { get; private set; }

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
            this.friendsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // friendsList
            // 
            this.friendsList.FormattingEnabled = true;
            this.friendsList.ItemHeight = 16;
            this.friendsList.Location = new System.Drawing.Point(3, 3);
            this.friendsList.Name = "friendsList";
            this.friendsList.Size = new System.Drawing.Size(134, 84);
            this.friendsList.TabIndex = 0;
            this.friendsList.SelectedIndexChanged += new System.EventHandler(this.onIndexSelectChanged);
            // 
            // FriendsListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.friendsList);
            this.Name = "FriendsListBox";
            this.Size = new System.Drawing.Size(140, 91);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox friendsList;

        public static implicit operator ListBox(FriendsListBox v)
        {
            return new ListBox();
        }
    }
}
