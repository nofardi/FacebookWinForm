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
        public readonly string[] r_Permissions =
             {
               "public_profile",
                "user_friends",
                "user_likes",
                "user_photos",
                "user_posts",
                "manage_pages",
                "publish_pages",
                "publish_actions"
          };

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
    }
}
