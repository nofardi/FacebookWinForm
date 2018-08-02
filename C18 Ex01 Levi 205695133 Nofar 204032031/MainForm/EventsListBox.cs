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
        public PictureBox PicBox { get; set; }

        public EventsListBox()
        {
            InitializeComponent();
        }

          private string getImageUrlOnClick()
          {
               Event selectedEvent = this.eventsList.SelectedItem as Event;
               string picUrl = string.Empty;
               if (selectedEvent != null)
               {
                    if (selectedEvent != null)
                    {
                         if (selectedEvent.PictureSmallURL != null)
                         {
                              picUrl = selectedEvent.PictureSmallURL;
                         }
                    }
               }

               return picUrl;
          }

        public void ListItems(User i_User)
        {
            this.eventsList.DisplayMember = "Name";
            this.eventsList.Items.Clear();

            foreach (Event userEvent in i_User.Events)
            {
                this.eventsList.Items.Add(userEvent);
            }
        }

        private void onIndexSelectChanged(object sender, EventArgs e)
        {
            string picUrl = getImageUrlOnClick();
            if (!string.IsNullOrEmpty(picUrl))
            {
                PicBox.LoadAsync(picUrl);
            }
            else
            {
                PicBox.Image = PicBox.ErrorImage;
            }
        }

        public void Clear()
        {
            eventsList.Items.Clear();
        }
    }
}
