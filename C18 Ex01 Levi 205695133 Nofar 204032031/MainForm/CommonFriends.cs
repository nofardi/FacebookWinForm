using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    class CommonFriendsFinder : ICommonFinders
    {
        public List<User> FriendsInCommon;

        public void FindCommon(User i_FisrtUser, User i_SecUser)
        {
            FriendsInCommon = new List<User>();
            foreach(User friend in i_FisrtUser.Friends)
            {
                if(friend.Friends.Contains(i_SecUser))
                {
                    FriendsInCommon.Add(friend);
                }
            }
        }

        public void SetProp(CommonProp i_CommonProp)
        {
            i_CommonProp.FriendsInCommon = FriendsInCommon;
        }
    }
}
