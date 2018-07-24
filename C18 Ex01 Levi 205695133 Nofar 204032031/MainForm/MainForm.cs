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
               buttonLogIn.Text = "Switch User";
               labelWelcome.Text = string.Format(@"Welcome {0}", m_AppLogic.LoggedInUser.FirstName);
               pictureBoxUserPicture.LoadAsync(m_AppLogic.LoggedInUser.PictureNormalURL);
               textBoxPost.Text = string.Format(@"What's on your mind {0}?", m_AppLogic.LoggedInUser.FirstName);
               populateListBoxFriends();
               //if (m_LoggedInUser.Posts.Count > 0)
               //{
               //     textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
               //}
          }

          private void populateListBoxFriends()
          {
               if (m_AppLogic.LoggedInUser.Friends.Count > 0)
               {
                    foreach (User friend in m_AppLogic.LoggedInUser.Friends)
                    {
                         listBoxFriends.Items.Add(friend.ToString());
                    }
               }
               else
               {
                    listBoxFriends.Text = " You have no friends";
               }
          }

          private void buttonLogOut_Click(object sender, EventArgs e)
          {

          }
     }
}
