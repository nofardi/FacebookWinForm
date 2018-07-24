using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookApp
{
     public partial class MainForm : Form
     {
          private AppLogic m_AppLogic = new AppLogic();

          public MainForm()
          {
               InitializeComponent();
          }

          private void buttonLogIn_Click(object sender, EventArgs e)
          {
               m_AppLogic.Login();

               if (!string.IsNullOrEmpty(m_AppLogic.LoginResult.AccessToken))
               {
                    populateUIWithUserInformation();
               }
               else
               {
                    MessageBox.Show(m_AppLogic.LoginResult.ErrorMessage);
               }
          }

          private void populateUIWithUserInformation()
          {
               buttonEnabler();
               labelWelcome.Text = string.Format(@"{0} {1}", m_AppLogic.LoggedInUser.FirstName, m_AppLogic.LoggedInUser.LastName);
               pictureBoxUserPicture.LoadAsync(m_AppLogic.LoggedInUser.PictureNormalURL);
               pictureBoxUserPicture.LoadAsync(m_AppLogic.LoggedInUser.PictureLargeURL);
               populateTextBoxPostWithDefaultString();
               populateListBoxFriends();
          }

          private void populateTextBoxPostWithDefaultString()
          {
               string defaultString = string.Format(@"What's on your mind {0}?", m_AppLogic.LoggedInUser.FirstName);
               textBoxPost.Text = defaultString;
               textBoxPost.ForeColor = System.Drawing.Color.LightGray;
          }

          private void populateListBoxFriends()
          {
               //if (m_AppLogic.LoggedInUser.Friends.Count > 0)
               //{
               //     foreach (User friend in m_AppLogic.LoggedInUser.Friends)
               //     {
               //          listBoxFriends.Items.Add(friend.ToString());
               //     }
               //}
               //else
               //{
               //     listBoxFriends.Text = " You have no friends";
               //}
          }

          private void buttonLogOut_Click(object sender, EventArgs e)
          {
               m_AppLogic.Logout();
               clearControls();
          }

          private void clearControls()
          {
               buttonEnabler();
               labelWelcome.Text = "";
               pictureBoxUserPicture.Image = null;
               textBoxPost.Text = "";
               //listBoxFriends.Items.Clear();
          }

          private void buttonEnabler()
          {
               buttonLogIn.Enabled = !buttonLogIn.Enabled;
               buttonLogOut.Enabled = !buttonLogOut.Enabled;
               buttonPost.Enabled = buttonLogOut.Enabled;           
          }

          private void buttonPost_Click(object sender, EventArgs e)
          {
               m_AppLogic.LoggedInUser.PostStatus(textBoxPost.Text);
               updateUserFeed();
               populateTextBoxPostWithDefaultString();
          }

          private void updateUserFeed()
          {
               m_AppLogic.LoggedInUser.ReFetch();
               //this.flowLayoutPanelUserFeed.Controls.Clear();
               //var topPosts = m_UserLogic.LoggedInUser.Posts.Take(5);
               //foreach (var post in topPosts)
               //{
               //     var newPost = new PostControl();
               //     newPost.PostDate = post.CreatedTime.Value.ToLongDateString();
               //     newPost.PostText = post.Message;
               //     newPost.PostPictureUrl = post.PictureURL;
               //     newPost.PostLikes(post.LikedBy.Count());

               //     this.flowLayoutPanelUserFeed.Controls.Add(newPost);
               //}
          }

          private void textBoxPost_Enter(object sender, EventArgs e)
          {
               textBoxPost.Clear();
               textBoxPost.ForeColor = System.Drawing.Color.Black;
          }
     }
}
