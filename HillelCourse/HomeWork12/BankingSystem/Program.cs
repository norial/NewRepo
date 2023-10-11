namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankSavingsAccount = new SavingsAccount("Me", 1500, 0.05);

            bankSavingsAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankSavingsAccount.Withdraw(1000);
            bankSavingsAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankSavingsAccount.Deposit(8000);
            bankSavingsAccount.DisplayAccountInfo();
            Console.WriteLine();

            BankAccount bankSavingsAccount_2 = new SavingsAccount("You", 8000, 0.05);
            bankSavingsAccount_2.DisplayAccountInfo();

            BankAccount bankCheckingAccount = new CheckingAccount("Tom", 2000, 15000);
            Console.WriteLine();
            bankCheckingAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankCheckingAccount.Withdraw(1000);
            bankCheckingAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankCheckingAccount.Withdraw(1500);
            bankCheckingAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankCheckingAccount.Deposit(3000);
            bankCheckingAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankCheckingAccount.Withdraw(12500);
            bankCheckingAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankCheckingAccount.Deposit(20000);
            bankCheckingAccount.DisplayAccountInfo();
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}