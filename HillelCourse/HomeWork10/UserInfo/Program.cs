// ++  Створити клас User, що містить інформацію про користувача (логін, ім'я, прізвище, вік, дату заповнення анкети).
//  +  Поле дата заповнення анкети має бути проініціалізоване лише один раз (при створенні екземпляра цього класу) без можливості його подальшої зміни.
//  +  Реалізуйте виведення на екран інформації про користувача.

namespace UserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            PrintOut(user1.GetFormCompletionDate,user1);
            Console.WriteLine();
            User user2 = new User();
            PrintOut(user1.GetFormCompletionDate, user2);
            Console.ReadKey();
        }
        public static void PrintOut(string dataTime, User user)
        {
            Console.WriteLine($"Login: {user.GetLogin}, {user.GetName} {user.GetLastname}, age {user.GetAge}, form completion date is: {dataTime}");
        }
    }

}