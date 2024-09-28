using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club_Project_Idea_User_Control_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlPoolTable2_OnTableCompleted(object sender, ctrlPoolTable.TableCompletedEventArgs e)
        {
            MessageBox.Show($"Time Game : {e.TimeText} \n Rate Per Hour : {e.RatePerHour}\n Total Fees : {e.TotalFees}");
        }
    }
}
