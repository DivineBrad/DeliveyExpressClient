using DeliveryExpressClient.DeliveryService;
using DeliveryExpressClient.Model;
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
    public partial class FrmViewOrders : Form
    {
        public List<Order> Orders { get; set; }
        public FrmViewOrders()
        {
            InitializeComponent();
        }

        private void FrmViewOrders_Load(object sender, EventArgs e)
        {
           DeliveryServiceClient client = new DeliveryServiceClient("BasicHttpBinding_IDeliveryService");
            this.Orders = client.GetOrders().ToList();
            List<FilteredOrder> filtered = new List<FilteredOrder>();
            
            foreach (Order o in Orders){
               FilteredOrder fo =  new FilteredOrder();
                fo.CustomerName = o.Customer.Name;
                fo.DateTime = o.DateTime;
                fo.OrderNo = o.OrderNo;
                fo.OrderId = o.OrderId;
                fo.Status = o.Status.Desc;
                fo.Total = "$"+Convert.ToString(o.Total);
                fo.Tax = "$" + Convert.ToString(o.Tax);
                fo.Subtotal = "$" + Convert.ToString(o.Subtotal);
                filtered.Add(fo);
            }
            dgvOrders.DataSource = filtered;
           
            
           
        }
    }
}
