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
    
    public partial class UpdateItemValues : Form
    {
        DeliveryServiceClient client = null;
        public UpdateItemValues()
        {
            InitializeComponent();
            client = new DeliveryServiceClient("BasicHttpBinding_IDeliveryService");
        }

        private void button_Pressed(object sender, EventArgs e)
        {
            string itemid = txtID.Text;
            if (sender.Equals(btnUpdate))
            {         
                string name = txtName.Text;
                string description = txtDesc.Text;
                string price = txtPrice.Text;
                string error = validateData(name, description, price);
                if (error == "")
                {
                    double conprice = Convert.ToDouble(price);
                    int conitemid = Convert.ToInt32(itemid);
                    Item item = null;
                    try
                    {
                        item = new Item();
                        item.Name = name;
                        item.Desc = description;
                        item.Price = conprice;
                        item.ItemId = conitemid;
                        int rows = client.UpdateItem(item);
                        lblStatus.ForeColor = Color.Black;
                        lblStatus.Text = rows + " Item Updated !! ";
                        //lblStatus.Text = item.Name + " " + item.Desc + " " + item.Price;

                    }
                    catch (FaultException<Fault> obj)
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = obj.Code + " " + obj.Detail + " because " + obj.Reason;
                    }
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = error;          
                }

            }
            else if (sender.Equals(btnReset))
            {
                txtName.Text = "";
                txtDesc.Text = "";
                txtPrice.Text = "";
                lblStatus.Text = "";

            }
            else if (sender.Equals(btnDelete))
            {
             DialogResult dr = MessageBox.Show("Are u sure u want to delete ?", "WARNING", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(itemid);
                    int rows = client.DeleteItem(id);
                    lblStatus.ForeColor = Color.Black;
                    lblStatus.Text = rows + " Item Deleted !! ";
                }
            }

        }

        private void txtprice_Pressed(object sender, KeyPressEventArgs e)
        {

        }

        private void UpdateItemValues_Load(object sender, EventArgs e)
        {
            
            Item item = updateItem.getLoadedItem();
            txtID.Text = Convert.ToString(item.ItemId);
            txtName.Text = item.Name;
            txtDesc.Text = item.Desc;
            txtPrice.Text = Convert.ToString(item.Price);
        }
        private string validateData(string name, string description, string price)
        {
            string error = "";
            if (name == "")
            {
                error += "NAME REQUIRED !! \n";
            }
            if (description == "")
            {
                error += "Description REQUIRED !! \n";
            }
            if (price == "")
            {
                error += "PRICE REQUIRED !! \n";
            }
            return error;
        }

        private void ontxtbox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (sender.Equals(txtPrice))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                     (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            lblStatus.Text = "";

        }
    }
}
