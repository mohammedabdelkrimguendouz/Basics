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
    public partial class frmTreeViewAndImageList : Form
    {
        public frmTreeViewAndImageList()
        {
            InitializeComponent();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        { 
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void frmTreeViewAndImageList_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("SOUSO");
        }

        
        private void CheckTreeViewNode(TreeNode Node,Boolean isChecked)
        {
            foreach(TreeNode item in Node.Nodes)
            {
                item.Checked=isChecked;
                if(item.Nodes.Count>0 )
                {
                    this.CheckTreeViewNode(item,isChecked);
                }
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }
    }
}
