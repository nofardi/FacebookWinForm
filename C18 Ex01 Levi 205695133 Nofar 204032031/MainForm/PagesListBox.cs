using System;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace FacebookApp
{
    public partial class PagesListBox : UserControl, IListBoxable
    {
        public PagesListBox()
        {
            InitializeComponent();
        }

        public PictureBox PicBox { get; set; }

        private string getImageUrlOnClick()
        {
            Page selectedPage = this.pagesList.SelectedItem as Page;
            string picUrl = string.Empty;
            if (selectedPage.PictureSmallURL != null)
            {
                picUrl = selectedPage.PictureSmallURL;
            }

            return picUrl;
        }

        public void ListItems(User i_User)
        {
            ShowItems(i_User.LikedPages);
        }

        public void ShowItems(FacebookObjectCollection<Page> i_Pages)
        {
            this.pagesList.DisplayMember = "Name";
            this.Clear();
            foreach (Page page in i_Pages)
            {
                this.pagesList.Items.Add(page);
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
            pagesList.Items.Clear();
        }
    }
}
