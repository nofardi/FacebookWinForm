using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Text;

namespace FacebookApp
{
     class UserLogic
     {
          private LoginResult m_LoginResult = null;
          private User m_LoggedInUser = null;
          private bool m_LoggedIn = false;
          public const string k_MyAppID = "1771402262915011";
          public readonly string[] r_Permissions =
               { "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
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

               if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
               {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    m_LoggedIn = true;
               }
          }

          public void Logout()
          {
               FacebookService.Logout(() => { });
               m_LoggedIn = false;
          }

          public string GetUserIntro()
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
     }
}
