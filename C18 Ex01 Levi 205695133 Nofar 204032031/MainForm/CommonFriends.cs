using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    class CommonFriendsFinder : ICommonFinders
    {
        private FacebookObjectCollection<User> m_FriendsInCommon;

        public void FindCommon(User i_FirstUser, User i_SecUser)
        {
            m_FriendsInCommon = new FacebookObjectCollection<User>();
            foreach(User friend in i_FirstUser.Friends)
            {
                foreach (User friendOfFriend in friend.Friends)
                {
                    if (friendOfFriend.Id == i_SecUser.Id)
                    {
                        m_FriendsInCommon.Add(friend);
                    }
                }
            }
        }

        public void SetProp(CommonProp i_CommonProp)
        {
            i_CommonProp.FriendsInCommon = m_FriendsInCommon;
        }
    }
}
