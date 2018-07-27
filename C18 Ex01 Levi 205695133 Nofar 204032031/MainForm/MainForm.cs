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
          }

          private void populateUIWithUserInformation()
          {
               buttonEnabler();
               labelWelcome.Text = string.Format(@"{0} {1}", m_AppLogic.LoggedInUser.FirstName, m_AppLogic.LoggedInUser.LastName);
               pictureBoxUserPicture.LoadAsync(m_AppLogic.LoggedInUser.PictureNormalURL);
               //pictureBoxBackGround.LoadAsync(m_AppLogic.LoggedInUser.Cover.SourceURL);
               populateTextBoxPostWithDefaultString();
               populateListBoxes();
               populateUserFeed();
          }

          private void populateListBoxes()
          {
               populateListBoxFriends();
               populateListBoxEvents();
               populateListBoxCheckins();
               //    populateListBoxLikedPages();
          }

          private void populateTextBoxPostWithDefaultString()
          {
               textBoxPost.Undo();
               string defaultString = string.Format(@"What's on your mind {0}?", m_AppLogic.LoggedInUser.FirstName);
               textBoxPost.Text = defaultString;
               textBoxPost.ForeColor = System.Drawing.Color.LightGray;
          }

          private void populateListBoxFriends()
          {
               listBoxFriends.Items.Clear();
               listBoxFriends.DisplayMember = "Name";
               if (m_AppLogic.LoggedInUser.Friends.Count > 0)
               {
                    foreach (User friend in m_AppLogic.LoggedInUser.Friends)
                    {
                         listBoxFriends.Items.Add(friend);
                         friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
               }

          }

          private void populateListBoxEvents()
          {
               //listBoxEvents.Items.Clear();
               //listBoxEvents.DisplayMember = "Name";

               //if (m_AppLogic.LoggedInUser.Events.Count > 0)
               //{
               //     foreach (Event fbEvent in m_AppLogic.LoggedInUser.Events)
               //     {
               //          listBoxEvents.Items.Add(fbEvent);
               //     }
               //}
          }

          private void populateListBoxCheckins()
          {
               if (m_AppLogic.LoggedInUser.Checkins.Count > 0)
               {
                    foreach (Checkin checkin in m_AppLogic.LoggedInUser.Checkins)
                    {
                         listBoxCheckins.Items.Add(checkin.Place.Name);
                    }
               }

          }

          private void populateListBoxLikedPages()
          {
               listBoxLikedPages.Items.Clear();
               listBoxLikedPages.DisplayMember = "Name";

               if (m_AppLogic.LoggedInUser.LikedPages.Count > 0)
               {
                    foreach (Page page in m_AppLogic.LoggedInUser.LikedPages)
                    {
                         listBoxLikedPages.Items.Add(page);
                    }
               }

          }

          private void buttonLogOut_Click(object sender, EventArgs e)
          {
               m_AppLogic.Logout();
               clearUI();
          }

          private void clearUI()
          {
               buttonEnabler();
               Utility.ClearControls(Controls);
          }

          private void buttonEnabler()
          {
               buttonLogIn.Enabled = !buttonLogIn.Enabled;
               buttonLogOut.Enabled = !buttonLogOut.Enabled;
               buttonPost.Enabled = buttonLogOut.Enabled;
               textBoxPost.Enabled = buttonPost.Enabled;
          }

          private void buttonPost_Click(object sender, EventArgs e)
          {
               m_AppLogic.LoggedInUser.PostStatus(textBoxPost.Text);
               populateUserFeed();
               populateTextBoxPostWithDefaultString();
          }

          private void populateUserFeed()
          {
               listBoxPosts.Items.Clear();
               if (m_AppLogic.LoggedInUser.Posts.Count > 0)
               {

                    foreach (Post post in m_AppLogic.LoggedInUser.Posts)
                    {
                         if (post.Message != null)
                         {
                              listBoxPosts.Items.Add(post.Message);
                         }
                         else if (post.Caption != null)
                         {
                              listBoxPosts.Items.Add(post.Caption);
                         }
                         else
                         {
                              listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                         }
                    }
               }


          }

          private void textBoxPost_Enter(object sender, EventArgs e)
          {
               textBoxPost.Clear();
               textBoxPost.ForeColor = System.Drawing.Color.Black;
          }

          private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
          {
               displaySelectedFriendPicture();
          }

          private void displaySelectedFriendPicture()
          {
               if (listBoxFriends.SelectedItems.Count == 1)
               {
                    User selectedFriend = listBoxFriends.SelectedItem as User;
                    if (selectedFriend.PictureSmallURL != null)
                    {
                         pictureBoxFriend.LoadAsync(selectedFriend.PictureSmallURL);
                    }
                    else
                    {
                         pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
                    }
               }
          }

          private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
          {
               displaySelectedEventPicture();
          }

          private void displaySelectedEventPicture()
          {
               if (listBoxEvents.SelectedItems.Count == 1)
               {
                    Event selectedEvent = listBoxEvents.SelectedItem as Event;
                    pictureBoxEvent.LoadAsync(selectedEvent.PictureSmallURL);
               }
          }

          private void listBoxCheckins_SelectedIndexChanged(object sender, EventArgs e)
          {
               displaySelectedCheckinPicture();
          }

          private void displaySelectedCheckinPicture()
          {
               if (listBoxCheckins.SelectedItems.Count == 1)
               {
                    Checkin selectedCheckin = listBoxCheckins.SelectedItem as Checkin;
                    pictureBoxCheckin.LoadAsync(selectedCheckin.PictureURL);
               }
          }

          private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
          {
               displaySelectedPagePicture();
          }

          private void displaySelectedPagePicture()
          {
               if (listBoxLikedPages.SelectedItems.Count == 1)
               {
                    Page selectedPage = listBoxLikedPages.SelectedItem as Page;
                    pictureBoxLikedPage.LoadAsync(selectedPage.PictureSmallURL);
               }
          }

          private void buttonRefresh_Click(object sender, EventArgs e)
          {
               populateUserFeed();
          }
     }
}

