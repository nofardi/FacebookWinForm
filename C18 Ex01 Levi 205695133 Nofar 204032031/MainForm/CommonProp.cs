using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class CommonProp
    {
        public List<Photo> PhotosInCommon { get; set; }
        public List<User> FriendsInCommon { get; set; }
        public List<Page> PagesInCommon { get; set; }
        public List<Post> PostsInCommon { get; set; }
    }
}