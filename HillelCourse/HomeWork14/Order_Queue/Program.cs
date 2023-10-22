namespace Order_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcess orderProcess = new OrderProcess();
            orderProcess.AddOrder(new Order(1, "Carl", 12.3));
            orderProcess.AddOrder(new Order(2, "Ludvig", 2.3));
            orderProcess.AddOrder(new Order(3, "Nika", 1.0));
            orderProcess.AddOrder(new Order(4, "Oleh", 123.4));
            orderProcess.AddOrder(new Order(5, "Steve", 11.04));

            while (true)
            {
                Console.WriteLine("Select action:");
                Console.WriteLine("1. Issue the current order");
                Console.WriteLine("2. Print all orders");
                Console.WriteLine("3. Print all info");
                Console.WriteLine("4. End the program");
                Console.Write("Enter action number: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(orderProcess.IssueOrder());
                            break;
                        case 2:
                            orderProcess.ShowAllOrders();
                            break;
                        case 3:
                            Console.WriteLine(orderProcess.OutInfo());
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please select an action from the list.");
                            break;
                    }
                }
            }
        }
    }
}