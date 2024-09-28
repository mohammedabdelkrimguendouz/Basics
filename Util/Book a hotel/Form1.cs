using Book_a_hotel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_a_hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image[] arrImage = {Resources.image1, Resources.image2,Resources.image3,Resources.image4};
        int i = 0;

        private void btnBook_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Book Successflly";
            notifyIcon1.BalloonTipText = monthCalendar1.SelectionRange.ToString();
            notifyIcon1.ShowBalloonTip(9000);
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            if(i<arrImage.Length-1)
            {
                pbxImage.Image = arrImage[++i];
            }
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                pbxImage.Image = arrImage[--i];
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/index.en.html?aid=309654;label=hotels-english-en-emea-N_GIriD3PogQ*eemi5*gjAS420353753968:pl:ta:p1:p22,563,000:ac:ap:neg:fi:tikwd-12196901:lp9073626:li:dec:dm:ppccp=UmFuZG9tSVYkc2RlIyh9YcsZ-Id2vkzIfTmYhvC5HOg;ws=&gad_source=1&gclid=CjwKCAiAk9itBhASEiwA1my_6yUI3wFmZfZTXgUVfa4UXMXuGRKDI95Fl-XdVir7nINmFv8_u_vVkRoCbhkQAvD_BwE");
        }
    }
}
