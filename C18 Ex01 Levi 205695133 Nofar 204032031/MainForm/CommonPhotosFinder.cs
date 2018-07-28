using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System;

namespace FacebookApp
{
    public class CommonPhotosFinder : ICommonFinders
    {
        public List<Photo> PhotosInCommon { get; set; }

        public CommonPhotosFinder()
        {
        }

        public void FindCommon(User i_FirstUser, User i_SecUser)
        {
            PhotosInCommon = new List<Photo>();

            foreach (Photo photo in i_FirstUser.PhotosTaggedIn)
            {
                foreach (Photo friendPhoto in i_SecUser.PhotosTaggedIn)
                {
                    if (photo.Id == friendPhoto.Id)
                    {
                        PhotosInCommon.Add(photo);
                    }
                }
            }
        }

        public void SetProp(CommonProp i_CommonProp)
        {
            i_CommonProp.PhotosInCommon = PhotosInCommon;
        }
    }
}
