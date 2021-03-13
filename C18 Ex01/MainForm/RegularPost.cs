using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
     public partial class RegularPost : UserControl
     {
          private Post m_Post = null;

          public RegularPost(Post i_Post)
          {
               InitializeComponent();

               m_Post = i_Post;
               populate();
          }

          private void populate()
          {
               if (m_Post != null)
               {
                    populateUserInformation();
                    labelTime.Text = m_Post.UpdateTime.ToString();
                    populateTextBoxPost();
                    populateLinkLabelLike();
                    populatePictureBoxPicturePost(m_Post.PictureURL);
               }
          }

          private void populateTextBoxPost()
          {
               StringBuilder message = new StringBuilder();
               message.Append(m_Post.Message);
               message.Append(m_Post.Description);
               textBoxPost.Text = message.ToString();
          }

          private void populateUserInformation()
          {
               if (m_Post.From != null)
               {
                    pictureBoxUser.LoadAsync(m_Post.From.PictureLargeURL);
                    labelUserName.Text = m_Post.From.Name;
               }
               else
               {
                    pictureBoxUser.Image = pictureBoxUser.ErrorImage;
                    labelUserName.Text = "[Error]";
               }
          }

          private void populateLinkLabelLike()
          {
               linkLabelLike.Text = string.Format("Like({0})", m_Post.LikedBy.Count);
          }

          private void populatePictureBoxPicturePost(string i_ImageURL)
          {
               if (i_ImageURL != null)
               {
                    pictureBoxPicturePost.LoadAsync(i_ImageURL);
               }
          }

          private void linkLabelLike_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          {
               try
               {
                    m_Post.Like();
                    populateLinkLabelLike();
               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
          }
     }
}
