﻿using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public interface ICommonFinders
    {
        void FindCommon(User i_FirstUser, User i_SecUser);

        void SetProp(CommonProp i_CommonProp);
    }
}