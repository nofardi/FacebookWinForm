using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
        }
    }
}
