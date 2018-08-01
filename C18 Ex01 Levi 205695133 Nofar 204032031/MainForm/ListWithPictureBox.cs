using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

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
