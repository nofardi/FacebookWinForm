using System;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace FacebookApp
{
    public partial class ListWithPictureBox : UserControl
    {
        public User LoggedInUser { get; set; }
        public ListBox ListBoxInGroup { get { return listBox; } set { ListBoxInGroup = value; } }

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

        //private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    IListBoxable listBoxableItem = sender as IListBoxable;
        //    string imageUrl =  listBoxableItem.GetImageUrlOnClick();
        //    if (!string.IsNullOrEmpty(imageUrl))
        //    {
        //        pictureBox.LoadAsync(imageUrl);
        //    }
        //    else
        //    {
        //        pictureBox.Image = pictureBox.ErrorImage;
        //    }
        //}

        public void PopulateListBox()
        {
            IListBoxable listBoxableItem = listBox as IListBoxable;
            listBox.Items.Clear();
            listBoxableItem.ListItems(LoggedInUser);  
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
