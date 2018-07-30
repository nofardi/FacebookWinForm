using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    interface IListBoxable
    {
        string GetImageUrlOnClick();
        void ListItems(User i_User);
    }
}
