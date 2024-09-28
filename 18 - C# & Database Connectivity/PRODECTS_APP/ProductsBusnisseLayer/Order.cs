using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsBusnisseLayer
{
    public class clsOrder
    {
        public int OrderID { get; set; }
        public DateTime DateOrder { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string OrderDescription { get; set; }

        public clsOrder()
        {
            OrderID = -1;
            DateOrder = DateTime.Now;
            CustomerID = -1;
            UserID = -1;
            OrderDescription = string.Empty;
        }
        private clsOrder(int OrderID, DateTime DateOrder, int CustomerID, int UserID, string OrderDescription)
        {
            this.OrderID = OrderID;
            this.DateOrder = DateOrder;
            this.CustomerID = CustomerID;
            this.UserID = UserID;
            this.OrderDescription = OrderDescription;
        }

    }
}
