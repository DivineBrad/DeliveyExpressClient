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
    public partial class viewItems : Form
    {
        DeliveryServiceClient client = null;
        public viewItems()
        {
            InitializeComponent();
            client = new DeliveryServiceClient("BasicHttpBinding_IDeliveryService");
        }

        private void viewItems_Load(object sender, EventArgs e)
        {
            try
            {
                List<Item> item_List = client.GetItems().ToList();
                itemsGridView.DataSource = item_List;
            }
            catch (FaultException<Fault> obj)
            {
                itemsGridView.DataSource = "";
            }
        }

        private void onsearchbox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            String value = txtItemName.Text;
            if (value != "")
            {
                List<Item> item_List = client.GetItemsByName(txtItemName.Text).ToList();
                itemsGridView.DataSource = item_List;
            }
            else
            {
                List<Item> item_List = client.GetItems().ToList();
                itemsGridView.DataSource = item_List;
            }
        }
    }
}
