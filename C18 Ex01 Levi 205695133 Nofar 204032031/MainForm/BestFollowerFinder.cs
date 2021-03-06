﻿using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class BestFollowerFinder
    {
        private int GeneralCollectionLimit { get; }

        private Dictionary<string, Follower> m_Followers;

        public Follower BestFollower { get; set; }

        public User LoggedInUser { get; set; }

        public BestFollowerFinder(User i_LoggedInUser, int i_CollectionLimit)
        {
            LoggedInUser = i_LoggedInUser;
            this.GeneralCollectionLimit = i_CollectionLimit;
            InitializeFollowers();
        }

        public void InitializeFollowers()
        {
            m_Followers = new Dictionary<string, Follower>(LoggedInUser.Friends.Count);
            foreach (User friend in LoggedInUser.Friends)
            {
                Follower follower = new Follower { Id = friend.Id };
                m_Followers.Add(follower.Id, follower);
            }
        }

        public void FindBestFollower()
        {
            const int k_CollectionLimit = 30;
            FacebookService.s_CollectionLimit = k_CollectionLimit;
            LoggedInUser.ReFetch();
            bool postsLikesFound = this.countLikesInPosts();
            bool photosLikesFound = this.countLikesInPhotos();
            if (postsLikesFound || photosLikesFound)
            {
                this.BestFollower = new Follower();
                foreach (Follower follower in m_Followers.Values)
                {
                    if (follower.numberOfLikes > this.BestFollower.numberOfLikes)
                    {
                        this.BestFollower = follower;
                    }
                }
            }
        }

        private bool countLikesInPosts()
        {
            bool likesFound = false;

            try
            {
                foreach (Post post in LoggedInUser.WallPosts)
                {
                    if (post.Description != null || post.Message != null)
                    {
                        foreach (User user in post.LikedBy)
                        {
                            if (isUserInFriendsList(user))
                            {
                                updateFollower(user);
                                m_Followers[user.Id].LikedPosts.Add(post);
                                likesFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error: Finding liked posts by follower {0}", ex.Message));
            }

            return likesFound;
        }

        private bool countLikesInPhotos()
        {
            bool likesFound = false;
            FacebookService.s_CollectionLimit = 15;

            try
            {
                foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
                {
                    foreach (User friend in photo.LikedBy)
                    {
                        if (isUserInFriendsList(friend))
                        {
                            updateFollower(friend);
                            m_Followers[friend.Id].LikedPhotos.Add(photo);
                            likesFound = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error: Finding liked photos by follower {0}", ex.Message));
            }

            FacebookService.s_CollectionLimit = this.GeneralCollectionLimit;
            return likesFound;
        }

        private bool isUserInFriendsList(User i_User)
        {
            bool result = false;
            foreach (User friend in this.LoggedInUser.Friends)
            {
                if (friend.Id == i_User.Id)
                {
                    result = true;
                }
            }

            return result;
        }

        private void updateFollower(User i_Friend)
        {
            m_Followers[i_Friend.Id].Name = i_Friend.Name;
            m_Followers[i_Friend.Id].numberOfLikes++;
            m_Followers[i_Friend.Id].PictureURL = i_Friend.PictureLargeURL;
        }
    }
}