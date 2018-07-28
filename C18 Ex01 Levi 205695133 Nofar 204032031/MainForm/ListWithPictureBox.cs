using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
     public partial class ListWithPictureBox : UserControl
     {
          public ListWithPictureBox()
          {
               InitializeComponent();
          }

          public string Title
          {
               get
               {
                    return groupBox.Text;
               }
               set
               {
                    groupBox.Text = value;
               }
          }

          private void listBox_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void displaySelectedFriendPicture()
          {
               //if (listBox.SelectedItems.Count == 1)
               //{
               //     FacebookWrapper.ObjectModel selected = listBox.SelectedItem as User;
               //     if (selected.PictureSmallURL != null)
               //     {
               //          pictureBox.LoadAsync(selected.PictureSmallURL);
               //     }
               //     else
               //     {
               //          pictureBox.Image = pictureBox.ErrorImage;
               //     }
               //}
          }
     }
     
}
