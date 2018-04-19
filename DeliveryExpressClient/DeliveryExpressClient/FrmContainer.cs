using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryExpressClient
{
    public partial class FrmContainer : Form
    {
        public FrmContainer()
        {
            InitializeComponent();
        }

        private void menuClicked(object sender, EventArgs e)
        {
            if (sender.Equals(NewItemStrip))
            {
                insertItem newMDIChild = new insertItem();
                // Set the Parent Form of the Child window.  
                newMDIChild.MdiParent = this;
                // Display the new form.  
                newMDIChild.Show();
            }
            else if (sender.Equals(UpdateItemStrip))
            {
                updateItem newMDIChild = new updateItem();
                // Set the Parent Form of the Child window.  
                newMDIChild.MdiParent = this;
                // Display the new form.  
                newMDIChild.Show();
            }
            else if (sender.Equals(ViewItemsStrip))
            {
                viewItems newMDIChild = new viewItems();
                // Set the Parent Form of the Child window.  
                newMDIChild.MdiParent = this;
                // Display the new form.  
                newMDIChild.Show();
            }
        }

        /* private void toolStripMenuItem1_Click(object sender, EventArgs e)
         {
             Form2 newMDIChild = new Form2();
             // Set the Parent Form of the Child window.  
             newMDIChild.MdiParent = this;
             // Display the new form.  
             newMDIChild.Show();
         }*/
    }
}
