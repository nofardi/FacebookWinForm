using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    class AppLogic
    {
        private LoginResult m_LoginResult = null;
        private User m_LoggedInUser = null;
        public const string k_MyAppID = "1771402262915011";
        public CommonFinder m_CommonFinder { get; }

        public readonly string[] r_Permissions =
             {"public_profile",
                "user_friends",
                "user_likes",
                "user_photos",
                "user_posts",
         //       "user_about_me",
                "manage_pages",
              //  "publish_actions",
                "publish_pages",

          };

        public AppLogic()
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

        public void Login()
        {
            m_LoginResult = FacebookService.Login(k_MyAppID, r_Permissions);
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
        }

        public void Logout()
        {
            FacebookService.Logout(() => { });
        }


        internal void FindBestMatches()
        {
        }

        internal CommonProp GetCommon(object selectedItem)
        {
            m_CommonFinder.FindCommon(LoggedInUser, selectedItem as User);
            return m_CommonFinder.CommonProp;
        }
    }
}
