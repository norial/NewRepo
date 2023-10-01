//  +  Створити клас User, що містить інформацію про користувача (логін, ім'я, прізвище, вік, дату заповнення анкети).
//  +  Поле дата заповнення анкети має бути проініціалізоване лише один раз (при створенні екземпляра цього класу) без можливості його подальшої зміни.

namespace UserInfo
{
    internal class User
    {
        string login;
        string name;
        string lastname;
        int age;
        DateTime formCompletionDate;
        public string GetLogin { get; set; }
        public string GetName { get; set; }
        public string GetLastname { get; set; }
        public int GetAge { get; set; }
        public string GetFormCompletionDate
        {
            get { return GetData(formCompletionDate); }
        }

        public User() 
        {
            GetLogin = GetData(nameof(login));
            GetName = GetData(nameof(name));
            GetLastname = GetData(nameof(lastname));
            GetAge = GetData(GetAge, nameof(age));
        }

        private string GetData(string input)
        {
            Console.Write($"Enter your {input} ");
            input = Console.ReadLine();
            return input; 
        }
        private int GetData(int input, string nameOfData)
        {
            Console.Write($"Enter your {nameOfData} ");
            string Userinput = Console.ReadLine();
            int.TryParse(Userinput, out input);
            return input;
        }
        private string GetData(DateTime dataTime)
        {
            Random rand = new Random();
            dataTime = DateTime.Now;
            dataTime = dataTime.AddDays(rand.Next(-20, 0));
            dataTime = dataTime.AddMonths(rand.Next(-5, 0));
            return dataTime.ToString();
        }
    }
}
