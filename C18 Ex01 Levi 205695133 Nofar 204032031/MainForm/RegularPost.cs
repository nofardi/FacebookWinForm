using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
     public partial class RegularPost : UserControl
     {
          public RegularPost()
          {
               InitializeComponent();
          }

          public void Populate(Post i_Post)
          {
               populateUserInformation(i_Post.From);
               labelTime.Text = i_Post.UpdateTime.ToString();
               textBoxPost.Text = i_Post.Message;
               linkLabelLike.Text = string.Format("Like({0})", i_Post.LikedBy.Count);
               populatePictureBoxPicturePost(i_Post.PictureURL);
          }

          private void populateUserInformation(User i_User)
          {
               if (i_User != null)
               {
                    pictureBoxUser.LoadAsync(i_User.PictureSmallURL);
                    labelUserName.Text = i_User.Name;
               }
               else
               {
                    pictureBoxUser.Image = pictureBoxUser.ErrorImage;
                    labelUserName.Text = "[Error]";
               }
          }

          private void populatePictureBoxPicturePost(string i_ImageURL)
          {
               if (i_ImageURL != null)
               {
                    pictureBoxPicturePost.LoadAsync(i_ImageURL);
               }
          }
     }
}
