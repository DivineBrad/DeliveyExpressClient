using DeliveryExpressClient.DeliveryService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace DeliveryExpressClient
{
    public partial class updateItem : Form
    {
        DeliveryServiceClient client = null;
        UpdateItemValues updateform = null;
        private static Item item=null;
        public updateItem()
        {
            InitializeComponent();
            client = new DeliveryServiceClient("BasicHttpBinding_IDeliveryService");
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            lblStatusUpdt.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            if (id != "")
            {
                try
                {
                    int convId = Convert.ToInt32(txtId.Text);
                    item = client.GetItem(convId);
                    //lblStatusUpdt.Text = item.Name;
                   updateform = new UpdateItemValues();
                    // Set the Parent Form of the Child window.  
                    //newMDIChild.MdiParent = this;
                    // Display the new form.  
                    updateform.Show();
                    this.Close();
                }
                catch (FaultException<Fault> obj)
                {
                    lblStatusUpdt.ForeColor = Color.Red;
                    lblStatusUpdt.Text = obj.Code + " " + obj.Detail + " because " + obj.Reason;
                }

            }
            else
            {
                lblStatusUpdt.ForeColor = Color.Red;
                lblStatusUpdt.Text = "ITEM ID REQUIRED !!";
            }
        }
        public static Item getLoadedItem()
        {
            return item;
        }
    }
}
