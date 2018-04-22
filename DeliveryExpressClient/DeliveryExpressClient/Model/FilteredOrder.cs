using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryExpressClient.Model
{
    class FilteredOrder
    {
        public int OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public string OrderNo { get; set; }
        public string Total { get; set; }
        public string Tax { get; set; }
        public string Subtotal { get; set; }
        public String CustomerName { get; set; }
        public String Status { get; set; }
        
       
    }
}
