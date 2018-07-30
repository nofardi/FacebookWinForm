using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FacebookApp
{
     public partial class MainForm : Form
     {
          private UserLogic m_UserLogic = new UserLogic();
          private readonly Color r_DefaultFontColor = Color.LightGray;

          public MainForm()
          {
               InitializeComponent();
          }

          private void buttonLogIn_Click(object sender, EventArgs e)
          {
               m_UserLogic.Login();

               if (!string.IsNullOrEmpty(m_UserLogic.LoginResult.AccessToken))
               {
                    populateUIWithUserInformation();
               }
               else
               {
                    MessageBox.Show("Error accessing user");
               }
          }

          private void populateUIWithUserInformation()
          {
               populateLabelName();
               populatePictrureBoxUserPicture();
               populatePictureBoxCover();

               populateListBoxFriends();
               populateListBoxEvents();
               populateListBoxCheckins();
               populateListBoxLikedPages();



               populateTextBoxIntro();
               populateTextBoxPostWithDefaultString();
               populateUserFeed();

               populateGroupBoxPhotos();

               controlsEnabler();
          }

          private void populateLabelName()
          {
               if (m_UserLogic.LoggedInUser.FirstName != null && m_UserLogic.LoggedInUser.LastName != null)
               {
                    labelName.Text = string.Format(@"{0} {1}", m_UserLogic.LoggedInUser.FirstName, m_UserLogic.LoggedInUser.LastName);
               }
               else
               {
                    MessageBox.Show("Error: can't retrieve name");
               }
          }

          private void populatePictrureBoxUserPicture()
          {
               if (m_UserLogic.LoggedInUser.PictureNormalURL != null)
               {
                    pictureBoxUserPicture.LoadAsync(m_UserLogic.LoggedInUser.PictureNormalURL);
               }
               else
               {
                    pictureBoxUserPicture.Image = pictureBoxUserPicture.ErrorImage;
               }
          }

          private void populatePictureBoxCover()
          {
               if (m_UserLogic.LoggedInUser.Cover != null)
               {
                    pictureBoxCover.LoadAsync(m_UserLogic.LoggedInUser.Cover.SourceURL);
               }
               else
               {
                    pictureBoxCover.Image = pictureBoxCover.ErrorImage;
               }
          }

          private void populateUserFeed()
          {
               
               feed.PopulateFeed(m_UserLogic.LoggedInUser.Posts);             
          }

          private void populateTextBoxIntro()
          {
               textBoxIntro.Clear();
               try
               {
                    textBoxIntro.Text = m_UserLogic.GetUserIntro();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
          }

          private void populateTextBoxPostWithDefaultString()
          {
               textBoxPost.Undo();
               string defaultString = string.Format(@"What's on your mind {0}?", m_UserLogic.LoggedInUser.FirstName);
               textBoxPost.Text = defaultString;
               textBoxPost.ForeColor = r_DefaultFontColor;
          }

          private void populateGroupBoxPhotos()
          {
               //groupBoxPhotos.Controls.Clear();
               //m_UserLogic.LoggedInUser.Albums.
               //try
               //{
               //     foreach (Pictures photo in m_UserLogic.LoggedInUser.Pictures)
               //     {
               //          PictureBox pictureBox = new PictureBox();
               //          pictureBox.LoadAsync(photo.ThumbURL);
               //          groupBoxPhotos.Controls.Add(pictureBox);
               //     }

               //}
               //catch (Exception ex)
               //{
               //     MessageBox.Show(ex.Message);
               //}
          }


          private void populateListBoxFriends()
          {
               listBoxFriends.Items.Clear();
               listBoxFriends.DisplayMember = "Name";

               try
               {
                    foreach (User friend in m_UserLogic.LoggedInUser.Friends)
                    {
                         listBoxFriends.Items.Add(friend);
                    }
               }
               catch (Exception ex)
               {
                    string message = string.Format(@"Friends: {0}", ex.Message);
                    MessageBox.Show(message);
               }
          }

          private void populateListBoxEvents()
          {
               listBoxEvents.Items.Clear();
               listBoxEvents.DisplayMember = "Name";

               try
               {
                    foreach (Event fbEvent in m_UserLogic.LoggedInUser.Events)
                    {
                         listBoxEvents.Items.Add(fbEvent);
                    }
               }
               catch (Exception ex)
               {
                    string message = string.Format(@"Events: {0}", ex.Message);
                    MessageBox.Show(message);
               }
          }

          private void populateListBoxCheckins()
          {
               listBoxCheckins.Items.Clear();
               listBoxCheckins.DisplayMember = "Name";
               try
               {
                    foreach (Checkin checkin in m_UserLogic.LoggedInUser.Checkins)
                    {
                         listBoxCheckins.Items.Add(checkin.Place.Name);
                    }
               }
               catch (Exception ex)
               {
                    string message = string.Format(@"Checkins: {0}", ex.Message);
                    MessageBox.Show(message);
               }
          }

          private void populateListBoxLikedPages()
          {
               listBoxLikedPages.Items.Clear();
               listBoxLikedPages.DisplayMember = "Name";

               try
               {
                    foreach (Page page in m_UserLogic.LoggedInUser.LikedPages)
                    {
                         listBoxLikedPages.Items.Add(page);
                    }
               }
               catch (Exception ex)
               {
                    string message = string.Format(@"Liked pages: {0}", ex.Message);
                    MessageBox.Show(message);
               }

          }

          private void buttonLogOut_Click(object sender, EventArgs e)
          {
               m_UserLogic.Logout();
               clearUI();
          }

          private void clearUI()
          {
               controlsEnabler();
               Utility.ClearControls(Controls);
          }

          private void controlsEnabler()
          {
               buttonLogIn.Enabled = !m_UserLogic.LoggedIn;
               buttonLogOut.Enabled = m_UserLogic.LoggedIn;
               buttonPost.Enabled = m_UserLogic.LoggedIn;
               buttonGetPicturePath.Enabled = m_UserLogic.LoggedIn;
               buttonRefresh.Enabled = m_UserLogic.LoggedIn;
               textBoxPost.Enabled = m_UserLogic.LoggedIn;
               textBoxPicturePath.Visible = false;
          }

          private void buttonPost_Click(object sender, EventArgs e)
          {
               if (tryToPost())
               {
                    //m_UserLogic.LoggedInUser.ReFetch();//!!!
                    populateUserFeed();
               }
               populateTextBoxPostWithDefaultString();
          }

          private bool tryToPost()
          {
               bool isSuccess = false;

               if (textBoxPicturePath.Visible)
               {
                    isSuccess = tryToPostPicture();
               }
               else
               {
                    isSuccess = tryToPostStatus();
               }

               textBoxPicturePath.Visible = false;

               return isSuccess;
          }

          private bool tryToPostPicture()
          {
               string picturePath = textBoxPicturePath.Text;
               string description = textBoxPost.Text;
               bool isSuccess = false;
               try
               {
                    if (File.Exists(picturePath))
                    {
                         m_UserLogic.LoggedInUser.PostPhoto(picturePath, description);
                         isSuccess = true;
                    }
                    else
                    {
                         MessageBox.Show("Error: Photo doesnt exist");
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
          

               return isSuccess;
          }

          private bool tryToPostStatus()
          {
               string status = textBoxPost.Text;
               bool isSuccess = false;

               if (string.IsNullOrEmpty(status) || textBoxPost.ForeColor == r_DefaultFontColor)
               {
                    MessageBox.Show("Error: Empty post");
               }
               else
               {
                    try
                    {
                         m_UserLogic.LoggedInUser.PostStatus(status);
                         isSuccess = true;
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show(ex.Message);
                    }
               }

               return isSuccess;
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
                    if (selectedEvent.PictureSmallURL != null)
                    {
                         pictureBoxEvent.LoadAsync(selectedEvent.PictureSmallURL);
                    }
                    else
                    {
                         pictureBoxEvent.Image = pictureBoxEvent.ErrorImage;
                    }
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
                    if (selectedCheckin.PictureURL != null)
                    {
                         pictureBoxCheckin.LoadAsync(selectedCheckin.PictureURL);
                    }
                    else
                    {
                         pictureBoxCheckin.Image = pictureBoxCheckin.ErrorImage;
                    }
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
                    if (selectedPage.PictureSmallURL != null)
                    {
                         pictureBoxLikedPage.LoadAsync(selectedPage.PictureSmallURL);
                    }
                    else
                    {
                         pictureBoxLikedPage.Image = pictureBoxLikedPage.ErrorImage;
                    }
               }
          }

          private void buttonRefresh_Click(object sender, EventArgs e)
          {
               m_UserLogic.LoggedInUser.ReFetch();
               populateUIWithUserInformation();
          }

          private void buttonGetPicturePath_Click(object sender, EventArgs e)
          {
               OpenFileDialog fileDialog = new OpenFileDialog();
               // image filters  
               fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
               if (fileDialog.ShowDialog() == DialogResult.OK)
               {
                    // display image in picture box  
                    //pictureBox1.Image = new Bitmap(open.FileName);
                    // image file path 
                    textBoxPicturePath.Visible = true;
                    textBoxPicturePath.Text = fileDialog.FileName;
                    textBoxPost.Text = string.Empty;
               }
               fileDialog.Dispose();
          }
     }
}

