using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class EventsListBox : UserControl, IListBoxable
    {
        public EventsListBox()
        {
            InitializeComponent();
        }

        public string GetImageUrlOnClick()
        {
            return "";
        }

        public void ListItems(User i_User)
        {
            throw new NotImplementedException();
        }
    }
}
