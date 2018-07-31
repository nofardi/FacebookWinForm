using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookApp
{
    public class Follower
    {
        public string Id { get; set; }
        public List<Photo> LikedPhotos { get; set; } = new List<Photo>();
        public List<Post> LikedPosts { get; set; } = new List<Post>();
        public uint numberOfLikes { get; set; } = 0;
        public string Name { get; set; }
        public string PictureURL { get; set; }

        public void AddLikedPhoto(Photo i_LikedPhoto)
        {
            LikedPhotos.Add(i_LikedPhoto);
        }

        public void AddLikedPost(Post i_LikedPost)
        {
            LikedPosts.Add(i_LikedPost);
        }
    }

}