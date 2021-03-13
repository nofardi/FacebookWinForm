using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace FacebookApp
{
    public class Utility
    {
        public static void ClearControls(ControlCollection i_Controls)
        {
            foreach (Control control in i_Controls)
            {
                if (control is ListBox)
                {
                    ((ListBox)control).Items.Clear();
                }
                else if (control is IListBoxable)
                {
                    ((IListBoxable)control).Clear();
                }
                else if (control is PictureBox)
                {
                    ((PictureBox)control).Image = null;
                }
                else if (control is Label || control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is Panel)
                {
                    control.Controls.Clear();
                }
                else if (control is GroupBox || control is UserControl)
                {
                    ClearControls(control.Controls);
                }
                else if (control is TabControl)
                {
                    clearTabs((TabControl)control);
                }
            }
        }

        private static void clearTabs(TabControl i_TabControl)
        {
            foreach (TabPage page in i_TabControl.TabPages)
            {
                ClearControls(page.Controls);
            }
        }
    }
}
