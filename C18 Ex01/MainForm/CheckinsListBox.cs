using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
     public partial class CheckinsListBox : UserControl, IListBoxable
     {
          public CheckinsListBox()
          {
               InitializeComponent();
          }

          public PictureBox PicBox { get; set; }

          private string getImageUrlOnClick()
          {
               Checkin selectedCheckin = this.checkinList.SelectedItem as Checkin;
               string picUrl = string.Empty;
               if (selectedCheckin != null)
               {
                    if (selectedCheckin.PictureURL != null)
                    {
                         picUrl = selectedCheckin.PictureURL;
                    }
               }

               return picUrl;
          }

          public void ListItems(User i_User)
          {
               this.checkinList.DisplayMember = "Name";
               Clear();

               foreach (Checkin checkin in i_User.Checkins)
               {
                    this.checkinList.Items.Add(checkin);
               }
          }

          private void onIndexSelectChanged(object sender, EventArgs e)
          {
               string picUrl = getImageUrlOnClick();
               if (!string.IsNullOrEmpty(picUrl))
               {
                    PicBox.LoadAsync(picUrl);
               }
               else
               {
                    PicBox.Image = PicBox.ErrorImage;
               }
          }

          public void Clear()
          {
               checkinList.Items.Clear();
          }
     }
}
