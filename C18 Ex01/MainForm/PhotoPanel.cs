﻿using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
     public partial class PhotoPanel : UserControl
     {
          public PhotoPanel()
          {
               InitializeComponent();
          }

          public void Populate(IEnumerable<Photo> i_Photos)
          {
               flowLayoutPanelPhotos.Controls.Clear();
               foreach (Photo photo in i_Photos)
               {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Width = 60;
                    pictureBox.Height = 60;
                    pictureBox.Image = photo.ImageThumb;
                    flowLayoutPanelPhotos.Controls.Add(pictureBox);
               }
          }
     }
}
