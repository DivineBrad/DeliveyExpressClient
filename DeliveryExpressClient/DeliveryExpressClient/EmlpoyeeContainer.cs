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
    public partial class EmlpoyeeContainer : Form
    {
        public EmlpoyeeContainer()
        {
            InitializeComponent();
        }

        private void EmlpoyeeContainer_Load(object sender, EventArgs e)
        {

        }

        private void menu_Clicked(object sender, EventArgs e)
        {
            if (sender.Equals(newOrderToolStripMenuItem))
            {
                insertOrderForm insertform = new insertOrderForm();
                insertform.MdiParent = this;
                // Display the new form.  
                insertform.Show();

            }
            else if (sender.Equals(updateOrderToolStripMenuItem))
            {
                searchOrderForm sform = new searchOrderForm();
                sform.MdiParent = this;
                sform.Show();

            }
        }
    }
}
