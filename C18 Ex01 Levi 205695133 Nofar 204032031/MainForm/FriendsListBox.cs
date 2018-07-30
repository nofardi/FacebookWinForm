using System;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace FacebookApp
{
    public partial class FriendsListBox : UserControl, IListBoxable
    {
        public FriendsListBox()
        {
            InitializeComponent();
        }

        public string GetImageUrlOnClick()
        {
            User selectedFriend = this.friendsList.SelectedItem as User;
            string picUrl = string.Empty;
            if (selectedFriend.PictureSmallURL != null)
            {
                picUrl = selectedFriend.PictureSmallURL;
            }

            return picUrl;
        }

        public void ListItems(User i_User)
        {
            try
            {
                foreach (User friend in i_User.Friends)
                {
                    this.friendsList.Items.Add(friend);
                }
            }
            catch (Exception ex)
            {
                string message = string.Format(@"Friends: {0}", ex.Message);
                MessageBox.Show(message);
            }
        }
    }
}
