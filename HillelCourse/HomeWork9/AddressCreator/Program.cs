/*
  +  Створити клас із ім'ям Address. 
  +  У тілі класу потрібно створити поля: index, country, city, street, house, apartment.
  +  Для кожного поля створити властивість з двома методами доступу. 
  +  Створити екземпляр класу Address. 
  +  У поля екземпляра записати інформацію про поштову адресу. 
  +  Виведіть на екран значення полів, що описують адресу.*/

namespace AddressCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address();
            while (true)
            {
                int input = Menu.OptionChoice(true, new UserPickedOption());
                switch (input)
                {
                    case (int)UserPickedOption.AddAddress:
                        Console.Clear();
                        address.UserInput();
                        break;
                    case (int)UserPickedOption.PrintAddress:
                        Console.Clear();
                        if (address.UserAddress != null)
                        {
                            
                            Console.WriteLine($"Saved address is {address.AddressCreator()}");
                        }
                        else
                        {
                            Console.WriteLine("Add address first!\nPress Enter to go back.");

                        }
                        break;
                    case (int)UserPickedOption.Exit:
                        Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}