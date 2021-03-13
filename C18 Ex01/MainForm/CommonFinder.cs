using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class CommonFinder
    {
        private List<ICommonFinders> m_CommonFinders;

        public CommonProp CommonProp { get; set; }

        public CommonFinder()
        {
            m_CommonFinders = new List<ICommonFinders>
            {
                new CommonPhotosFinder(),
                new CommonFriendsFinder(),
                new CommonIntroFinder(),
                new CommonPagesFinder(),
                new CommonPostsFinder()
            };
            CommonProp = new CommonProp();
        }

        public void FindCommon(User i_FirstUser, User i_SecUser)
        {
            List<object> commonProperty = new List<object>();
            foreach (ICommonFinders commonFinder in m_CommonFinders)
            {
                try
                {
                    commonFinder.FindCommon(i_FirstUser, i_SecUser);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Error: Common: {0} {1}", commonFinder.GetType(), ex.Message));
                }
                finally
                {
                    commonFinder.SetProp(CommonProp);
                }
            }
        }
    }
}
