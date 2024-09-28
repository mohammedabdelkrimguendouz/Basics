using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstEWinFormsProject
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)|| string.IsNullOrEmpty(txtID.Text))
                return;
            ListViewItem Item=new ListViewItem(txtID.Text.Trim());
            if(rbMale.Checked)
                Item.ImageIndex = 0;
            else
                Item.ImageIndex=1;
            Item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(Item);
            txtName.Clear();
            txtID.Clear();
            txtID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count>0)
               listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
             
            for(byte i=1;i<=10;i++)
            {
                ListViewItem Item = new ListViewItem(i.ToString());
                if (i%2==0)
                    Item.ImageIndex = 0;
                else
                    Item.ImageIndex = 1;
                Item.SubItems.Add("Person"+i);
                listView1.Items.Add(Item);
            }
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbTitle_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}
