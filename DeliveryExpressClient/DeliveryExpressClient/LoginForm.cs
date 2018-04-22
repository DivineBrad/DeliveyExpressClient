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
    public partial class LoginForm : Form
    {
        DeliveryServiceClient client = null;
        public LoginForm()
        {
            InitializeComponent();
            client = new DeliveryServiceClient("BasicHttpBinding_IDeliveryService");
        }

        private void txtbox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string type = cbTypes.Text;
            //if(type.Equals)
            string name = txtUsername.Text;
            string pass = txtPassword.Text;
            string key = ((KeyValuePair<string, string>)cbTypes.SelectedItem).Key;
            string value = ((KeyValuePair<string, string>)cbTypes.SelectedItem).Value;
            string error = Validate(name, pass);
            if (error == "")
            {
                if (value.Equals("employee"))
                {
                    bool status = client.Authenticate(name, pass, Convert.ToInt32(key));
                    if (status)
                    {
                     
                        
                        lblMessage.Text = "";
                        FrmContainer parent = (FrmContainer)this.MdiParent;
                        parent.User = "employee";
                        parent.MainMenuStrip.Visible = true;
                        var viStrip = parent.MainMenuStrip.Items.Find("ViewItemsStrip", true).First();
                        viStrip.Visible = false;
                        var upStrip = parent.MainMenuStrip.Items.Find("UpdateItemStrip", true).First();
                        upStrip.Visible = false;
                        var newStrip = parent.MainMenuStrip.Items.Find("NewItemStrip", true).First();
                        newStrip.Visible = false;
                        FrmViewOrders frmOrders = new FrmViewOrders();
                        frmOrders.MdiParent = this.MdiParent;
                        frmOrders.Show();
                        this.Close();
                        
                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "INVALID LOGIN DETAILS";
                    }

                }
                else if (value.Equals("manager"))
                {
                    bool status = client.Authenticate(name, pass, Convert.ToInt32(key));
                    if (status)
                    {
                        viewItems vItems = new viewItems();
                        vItems.MdiParent = this.MdiParent;
                        vItems.Show();
                      
                        lblMessage.Text = "";
                        FrmContainer parent = (FrmContainer)this.MdiParent;
                        parent.User = "manager";
                        parent.MainMenuStrip.Visible = true;
                        this.Close();
                      
                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "INVALID LOGIN DETAILS";
                    }
                }
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = error;
            }        
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            List<UserType> typelist = client.getTypes().ToList();
            Dictionary<string, string> dict = new Dictionary<string,string>();
            foreach (UserType type  in typelist)
            {
                //cbTypes.Items.Add(type.Type,type.TypeId);
                dict.Add(Convert.ToString(type.TypeId), type.Type);
            }
            cbTypes.DataSource = new BindingSource(dict, null);
            cbTypes.DisplayMember = "Value";
            cbTypes.ValueMember = "Key";
        }
        private string Validate(string name,string pass)
        {
            string error = "";
                if (name.Equals(""))
            {
                error += "Enter Username!! \n";

            }
            if (pass.Equals(""))
            {
                error += "Enter pass!! \n";
            }
            return error;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
