using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class CommonProp
    {
        public FacebookObjectCollection<Photo> PhotosInCommon { get; set; }

        public FacebookObjectCollection<User> FriendsInCommon { get; set; }

        public FacebookObjectCollection<Page> PagesInCommon { get; set; }

        public FacebookObjectCollection<Post> PostsInCommon { get; set; }

        public string IntroInCommon { get; set; }
    }
}