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
using DeliveryExpressClient.DeliveryService;
using System.Runtime.Serialization;

namespace DeliveryExpressClient
{
    public partial class insertItem : Form
    {
        DeliveryServiceClient client = null;
        public insertItem()
        {
            InitializeComponent();
            client = new DeliveryServiceClient("BasicHttpBinding_IDeliveryService");
        }

        private void btnClicked(object sender, EventArgs e)
        {
            if (sender.Equals(btnSave))
            {
                string name = txtName.Text;
                string description = txtDescription.Text;
                string price = txtPrice.Text;
                string error = validateData(name, description, price);
                if (error == "")
                {
                    double conprice = Convert.ToDouble(txtPrice.Text);
                    Item item = null;
                    try
                    {
                        item = new Item();
                        item.Name = name;
                        item.Desc = description;
                        item.Price = conprice;
                        int rows = client.CreateItem(item);
                        lblStatus.ForeColor = Color.Black;
                        lblStatus.Text = rows +" Item Saved !! ";
                    }
                    catch (FaultException<Fault> obj)
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = obj.Code + " " + obj.Detail + " because " + obj.Reason;
                    }
                }
                else
                {
                    lblStatus.Text = error;
                    lblStatus.ForeColor = Color.Red;
                }


            }
            else if (sender.Equals(btnReset))
            {
                txtName.Text = "";
                txtDescription.Text = "";
                txtPrice.Text = "";
                lblStatus.Text = "";
            }
        }
        private string validateData(string name,string description,string price)
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

        private void ontxtbox_KeyPress(object sender, KeyPressEventArgs e)
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
