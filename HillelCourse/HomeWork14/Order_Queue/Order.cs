using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Queue
{
    internal class Order
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }

        public Order(int orderNumber, string customerName, double totalAmount) 
        { 
            OrderNumber = orderNumber;
            CustomerName = customerName;
            TotalAmount = totalAmount;
        }
    }
}
