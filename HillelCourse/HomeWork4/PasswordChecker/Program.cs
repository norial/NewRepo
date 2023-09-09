//Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений.
//Правильний пароль нехай буде "root".
//Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!"
namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User, please enter the password: \n\t");
            string password = Console.ReadLine();
            if (password != "root")
            {
                while (password != "root")
                {
                    Console.Write("Access denied, enter password again!\n\t");
                    password = Console.ReadLine();
                }
            }
            Console.WriteLine("Access is allowed, wellcome! :-)");
            Console.ReadKey();
        }
    }
}