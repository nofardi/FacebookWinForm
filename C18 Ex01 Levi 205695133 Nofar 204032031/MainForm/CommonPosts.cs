using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    class CommonPostsFinder : ICommonFinders
    {
        public FacebookObjectCollection<Post> PostsInCommon;
        public void FindCommon(User i_FirstUser, User i_SecUser)
        {
            PostsInCommon = new FacebookObjectCollection<Post>();
            foreach(Post post in i_FirstUser.PostsTaggedIn)
            {
                if(post.TaggedUsers.Contains(i_SecUser))
                {
                    PostsInCommon.Add(post);
                }
            }
        }

        public void SetProp(CommonProp i_CommonProp)
        {
            i_CommonProp.PostsInCommon = PostsInCommon;
        }
    }
}
