using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    class CommonPagesFinder : ICommonFinders
    {
        public List<Page> PagesInCommon { get; set; }
        public void FindCommon(User i_FirstUser, User i_SecUser)
        {
            PagesInCommon = new List<Page>();
            foreach(Page page in i_FirstUser.LikedPages)
            {
                foreach(Page friendPage in i_SecUser.LikedPages)
                {
                    if(friendPage.Id == page.Id)
                    {
                        PagesInCommon.Add(page);
                    }
                }
            }
        }

        public void SetProp(CommonProp i_CommonProp)
        {
            i_CommonProp.PagesInCommon = PagesInCommon;
        }
    }
}
