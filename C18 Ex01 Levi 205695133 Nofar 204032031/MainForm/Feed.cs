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
     public partial class Feed : UserControl
     {
          public Feed()
          {
               InitializeComponent();
          }

          public void PopulateFeed(IEnumerable<Post> i_Posts)
          {
               flowLayoutPanelFeed.Controls.Clear();
               //m_UserLogic.LoggedInUser.ReFetch();

               try
               {
                    foreach (Post post in i_Posts)
                    {
                         if (post != null)
                         {
                              RegularPost regularPost = new RegularPost(post);
                              flowLayoutPanelFeed.Controls.Add(regularPost);
                         }
                         post.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
               }
               catch (Exception ex)
               {
                    string message = string.Format(@"Feed: {0}", ex.Message);
                    MessageBox.Show(message);
               }

          }
     }
}
