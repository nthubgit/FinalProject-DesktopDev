using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DesktopDev.Business
{
    public class Order
    {
        public int OrderID { get; set; }
        public string ClientName { get; set; }
        public string BookTitle { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }

    }
}
