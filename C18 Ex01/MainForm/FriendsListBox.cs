using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class FriendsListBox : UserControl, IListBoxable
    {
        public FriendsListBox()
        {
            InitializeComponent();
        }

        public PictureBox PicBox { get; set; }

          private string getImageUrlOnClick()
          {
               User selectedFriend = this.friendsList.SelectedItem as User;
               string picUrl = string.Empty;
               if (selectedFriend != null)
               {
                    if (selectedFriend.PictureSmallURL != null)
                    {
                         picUrl = selectedFriend.PictureSmallURL;
                    }
               }

               return picUrl;
          }

        public void ListItems(User i_User)
        {
            ShowItems(i_User.Friends);
        }

        public void ShowItems(FacebookObjectCollection<User> i_Users)
        {
            this.friendsList.DisplayMember = "Name";
            this.Clear();
            foreach (User user in i_Users)
            {
                this.friendsList.Items.Add(user);
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
            friendsList.Items.Clear();
        }
    }
}
