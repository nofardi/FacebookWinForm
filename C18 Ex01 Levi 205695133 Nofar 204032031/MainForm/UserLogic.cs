using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookApp
{
    class UserLogic
    {
        private LoginResult m_LoginResult = null;
        private User m_LoggedInUser = null;
        private bool m_LoggedIn = false;
        public const string k_MyAppID = "1771402262915011";
        public const int k_CollectionLimit = 200;
        public CommonFinder m_CommonFinder { get; }
        public BestFollowerFinder BestFollowerFinder { get; set; }
        public string AccessToken
        {
            set; get;
        }
        public readonly string[] r_Permissions =
               {
               "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "user_events",
                "user_games_activity",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_posts",
                "user_photos",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages",
                "publish_actions",
                "rsvp_event"
          };

        public UserLogic()
        {
            m_CommonFinder = new CommonFinder();
        }

        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
        }

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }
            
        }

        public bool LoggedIn
        {
            get
            {
                return m_LoggedIn;
            }
        }

        public void Login()
        {

            m_LoginResult = FacebookService.Login(k_MyAppID, r_Permissions);
            AccessToken = m_LoginResult.AccessToken;
            if (!string.IsNullOrEmpty(this.AccessToken))
            {
                setLoggedInUser();
            }

        }

        public void Connect()
        {
            m_LoginResult = FacebookService.Connect(this.AccessToken);
            setLoggedInUser();
        }

        private void setLoggedInUser()
        {
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            m_LoggedIn = true;
        }

        public void Logout()
        {
            FacebookService.Logout(() => { });
            m_LoggedIn = false;
        }

        public string GetUserIntroString()
        {
            StringBuilder introString = new StringBuilder();

            if (LoggedInUser.Educations != null)
            {
                foreach (Education education in LoggedInUser.Educations)
                {
                    introString.AppendLine(string.Format("Studied at {0}", education.School.Name));
                }
            }

            if (LoggedInUser.Hometown != null)
            {
                introString.AppendLine(string.Format("Lives in: {0}", LoggedInUser.Hometown.Name));
            }

            if (LoggedInUser.Location != null)
            {
                introString.AppendLine(string.Format("From {0}", LoggedInUser.Location.Name));
            }

            if (LoggedInUser.RelationshipStatus != null)
            {
                introString.AppendLine(string.Format("{0}", LoggedInUser.RelationshipStatus.ToString()));
            }

            if (LoggedInUser.Birthday != null)
            {
                introString.AppendLine(string.Format("Birthday: {0}", LoggedInUser.Birthday));
            }

            return introString.ToString();
        }

        public IEnumerable<Post> GetLatestPosts(int i_NumberOfLatestPosts)
        {
            List<Post> postList = new List<Post>();

            for (int i = 0; i < i_NumberOfLatestPosts; i++)
            {
                try
                {
                    postList.Add(LoggedInUser.Posts[i]);
                }
                catch
                {
                    break;
                }
            }

            return postList;
        }

        public IEnumerable<Photo> GetLatestPhotos(int i_NumberOfLatestPhotos)
        {
            List<Photo> photoList = new List<Photo>();

            for (int i = 0; i < i_NumberOfLatestPhotos; i++)
            {
                try
                {
                    photoList.Add(LoggedInUser.Albums[0].Photos[i]);
                }
                catch
                {
                    break;
                }
            }

            return photoList;
        }

        internal void FindBestMatches()
        {
        }

        internal CommonProp GetCommon(object selectedItem)
        {
            m_CommonFinder.FindCommon(LoggedInUser, selectedItem as User);
            return m_CommonFinder.CommonProp;
        }

        internal void FindBestFollower()
        {
            if (this.BestFollowerFinder == null)
            {
                this.BestFollowerFinder = new BestFollowerFinder(this.LoggedInUser, k_CollectionLimit);
            }
            else
            {
                this.BestFollowerFinder.initializeFollowers();
            }

            this.BestFollowerFinder.FindBestFollower();
        }
    }
}
