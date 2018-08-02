using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class MainForm : Form
    {
        public const string k_LoginRequestMessage = "Error in Log in";
        private readonly Color r_DefaultFontColor = Color.LightGray;
        public const int k_NumOfLatestPostsToTake = 4;
        public const int k_NumberOfPhotosToShow = 4;
        private UserLogic m_UserLogic = new UserLogic();
        private AppSettings m_AppSettings;

        public MainForm()
        {
            InitializeComponent();
            m_AppSettings = AppSettings.LoadFromFile();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = m_AppSettings.LastWindowLocation;
            this.rememberCheckbox.Checked = m_AppSettings.RememberMe;
            m_UserLogic.AccessToken = m_AppSettings.AccessToken;
        }

          protected override void OnShown(EventArgs e)
          {
               base.OnShown(e);

               if (m_AppSettings.RememberMe
                   && !string.IsNullOrEmpty(m_UserLogic.AccessToken))
               {
                    try
                    {
                         m_UserLogic.Connect();
                         populateUIWithUserInformation();
                    }
                    catch(Exception ex)
                    {
                         MessageBox.Show(ex.Message);
                    }
               }
          }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.RememberMe = this.rememberCheckbox.Checked;
            m_AppSettings.AccessToken = m_UserLogic.AccessToken;

            if (this.rememberCheckbox.Checked)
            {
                m_AppSettings.AccessToken = m_UserLogic.LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.AccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            bool successLogin = true;
            try
            {
                m_UserLogic.Login();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                successLogin = false;
                buttonLogOut.Enabled = true;
            }

            if (successLogin && !string.IsNullOrEmpty(m_UserLogic.LoginResult.AccessToken))
            {
                populateUIWithUserInformation();
            }
            else
            {
                Console.WriteLine(k_LoginRequestMessage);
            }
        }

        private void populateUIWithUserInformation()
        {
            populateLabelName();
            populatePictureBoxUserPicture();
            populatePictureBoxCover();

            populateListBoxFriends();
            populateListBoxCommonFriends();
            populateListBoxEvents();
            populateListBoxCheckins();
            populateListBoxLikedPages();
            
            populateTextBoxIntro();
            populateTextBoxPostWithDefaultString();
            populateUserFeed();

            populatePhotoPanel();

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
                Console.WriteLine("Error: can't retrieve name");
            }
        }

        private void populateListBoxCommonFriends()
        {
            friendsCommonListBox.Items.Clear();
            friendsCommonListBox.DisplayMember = "Name";

            try
            {
                foreach (User friend in m_UserLogic.LoggedInUser.Friends)
                {
                    friendsCommonListBox.Items.Add(friend);
                }
            }
            catch (Exception ex)
            {
                string message = string.Format(@"Friends: {0}", ex.Message);
                MessageBox.Show(message);
            }
        }

        private void populatePictureBoxUserPicture()
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
            IEnumerable<Post> postsToPresent = m_UserLogic.GetLatestPosts(k_NumOfLatestPostsToTake);
            feed.PopulateFeed(postsToPresent);
        }

        private void populateTextBoxIntro()
        {
            textBoxIntro.Clear();
            try
            {
                textBoxIntro.Text = m_UserLogic.GetUserIntroString();
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

        private void populatePhotoPanel()
        {
            IEnumerable<Photo> photos = m_UserLogic.GetLatestPhotos(k_NumberOfPhotosToShow);
            photoPanel.Populate(photos);
        }

        private void populateListBoxItems(object i_ListBoxToPopulate)
        {
            IListBoxable listBoxableItem = i_ListBoxToPopulate as IListBoxable;
            listBoxableItem.ListItems(m_UserLogic.LoggedInUser);
        }

        private void populateListBoxFriends()
        {
            listBoxFriends.PicBox = pictureBoxFriend;
            try
            {
                populateListBoxItems(listBoxFriends);
            }
            catch (Exception ex)
            {
                string message = string.Format(@"Error: Friends: {0}", ex.Message);
                Console.WriteLine(message);
            }
        }

        private void populateListBoxEvents()
        {
            listBoxEvents.PicBox = pictureBoxEvent;
            try
            {
                populateListBoxItems(listBoxEvents);
            }
            catch (Exception ex)
            {
                string message = string.Format(@"Error: Events: {0}", ex.Message);
                Console.WriteLine(message);
            }
        }

        private void populateListBoxCheckins()
        {
            listBoxCheckins.PicBox = pictureBoxCheckin;
            try
            {
                populateListBoxItems(listBoxCheckins);
            }
            catch (Exception ex)
            {
                string message = string.Format(@"Error: Checkins: {0}", ex.Message);
                Console.WriteLine(message);
            }
        }

        private void populateListBoxLikedPages()
        {
            likedPagesListBox.PicBox = pictureBoxLikedPage;
            try
            {
                populateListBoxItems(likedPagesListBox);
            }
            catch (Exception ex)
            {
                string message = string.Format(@"Error: Liked pages: {0}", ex.Message);
                Console.WriteLine(message);
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
                m_UserLogic.LoggedInUser.ReFetch();
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            m_UserLogic.LoggedInUser.ReFetch();
            populateUIWithUserInformation();
        }

        private void buttonGetPicturePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
  
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPicturePath.Visible = true;
                textBoxPicturePath.Text = fileDialog.FileName;
                textBoxPost.Text = string.Empty;
            }

            fileDialog.Dispose();
        }

        private void findCommonButton_Click(object sender, EventArgs e)
        {
            CommonProp commonProperties = m_UserLogic.GetCommon(friendsCommonListBox.SelectedItem);
            populateCommonProps(commonProperties);
        }

        private void populateCommonProps(CommonProp i_CommonProps)
        {
            commonIntro.Text = i_CommonProps.IntroInCommon;

            friendsInCommonListBox.PicBox = friendsInCommonPic;
            friendsInCommonListBox.ShowItems(i_CommonProps.FriendsInCommon);

            pagesInCommonListBox.PicBox = pagesInCommonPic;
            pagesInCommonListBox.ShowItems(i_CommonProps.PagesInCommon);

            photosInCommonPanel.Populate(i_CommonProps.PhotosInCommon);
            feedInCommon.PopulateFeed(i_CommonProps.PostsInCommon);          
        }

        private void findFollowersButton_Click(object sender, EventArgs e)
        {
            const string k_NoFollower = "No Top Followers Were Found";
            if (m_UserLogic.LoggedInUser == null)
            {
                Console.WriteLine(k_LoginRequestMessage);
            }
            else
            {
                this.m_UserLogic.FindBestFollower();
                if (this.m_UserLogic.BestFollowerFinder.BestFollower != null)
                {
                    populateBestFollower();
                }
                else
                {
                    MessageBox.Show(k_NoFollower);
                }
            }
        }

        private void populateBestFollower()
        {
            const string followerStr = "Your best follower is ";
            this.topFollowerLabel.Text = string.Format("{0} {1}", followerStr, this.m_UserLogic.BestFollowerFinder.BestFollower.Name);
            this.topFollowerPic.LoadAsync(this.m_UserLogic.BestFollowerFinder.BestFollower.PictureURL);
            this.populateBestFollowerLikedPostsListBox();
            this.populateBestFollowerLikedPhotosListBox();
        }

        private void populateBestFollowerLikedPhotosListBox()
        {
            topFollowerPhotos.Populate(this.m_UserLogic.BestFollowerFinder.BestFollower.LikedPhotos);
        }

        private void populateBestFollowerLikedPostsListBox()
        {
            topFollowerPosts.PopulateFeed(this.m_UserLogic.BestFollowerFinder.BestFollower.LikedPosts);
        }
    }
}