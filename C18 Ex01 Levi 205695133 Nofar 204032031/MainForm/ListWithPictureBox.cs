using System;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace FacebookApp
{
    public partial class ListWithPictureBox : UserControl
    {
        User m_LoggedInUser;
        public ListWithPictureBox(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
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
            IListBoxable listBoxableItem = sender as IListBoxable;
            string imageUrl =  listBoxableItem.GetImageUrlOnClick();
            if (!string.IsNullOrEmpty(imageUrl))
            {
                pictureBox.LoadAsync(imageUrl);
            }
            else
            {
                pictureBox.Image = pictureBox.ErrorImage;
            }
        }

        public void PopulateListBox(object i_Items)
        {
            IListBoxable listBoxableItem = i_Items as IListBoxable;
            listBox.Items.Clear();
            listBoxableItem.ListItems(m_LoggedInUser);  
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
