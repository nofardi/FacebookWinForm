using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
namespace FacebookApp
{
    public class CommonPhotosFinder
    {
        public List<Photo> PhotosInCommon { get; set; }

        public User LoggedInUser { get; set; }
        public User FriendUser { get; set; }

        public CommonPhotosFinder()
        {
        }

        public CommonPhotosFinder(User i_LoggedInUser, User i_SelectedUser)
        {
            LoggedInUser = i_LoggedInUser;
            FriendUser = i_SelectedUser;
        }

        public void FindCommonPhotos()
        {
            PhotosInCommon = new List<Photo>();

            foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
            {
                foreach (Photo friendPhoto in FriendUser.PhotosTaggedIn)
                {
                    if (photo.Id == friendPhoto.Id)
                    {
                        PhotosInCommon.Add(photo);
                    }
                }
            }
        }


    }
}
