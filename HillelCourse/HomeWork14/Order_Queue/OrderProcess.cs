using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Queue
{
    internal class OrderProcess
    {
        private Queue<Order> orders;

        public OrderProcess()
        {
            orders = new Queue<Order>();
        }
        public static int OrdersAmount { get; set; }
        public double TotalOrdersAmount { get; set; }
        
        //Method to add new order
        public void AddOrder(Order order)
        {
            TotalOrdersAmount += order.TotalAmount;
            orders.Enqueue(order);
        }
        
        //Method to remove order by FIFO
        public string IssueOrder()
        {
            OrdersAmount++;
            return $"Order for {orders.Dequeue().CustomerName} is issued";
        }

        //Method to show all the orders
        public void ShowAllOrders()
        {
            Console.WriteLine("All orders:");
                foreach (Order order in orders)
                {
                    Console.WriteLine($"Order number {order.OrderNumber}, customer name is: {order.CustomerName}, price: {order.TotalAmount}");
                }
        }

        //Method to show info about total amount and amount of orders
        public string OutInfo()
        {
            return $"total amount of orders: {TotalOrdersAmount} \nTotal orders amount: {OrdersAmount}";
        }
    }
}
