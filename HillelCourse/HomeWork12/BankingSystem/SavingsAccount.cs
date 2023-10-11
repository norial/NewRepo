
namespace BankingSystem
{
    internal class SavingsAccount : BankAccount
    {
        double interestRate;
        double depositInterest;
        public SavingsAccount(string accountHolder, double balance, double interestRate) : base(accountHolder, balance)
        {
            this.interestRate = interestRate;
        }
        public override double Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"{amount} deposit to balance");
            return balance;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Balance = {balance += depositInterest}");
            Console.WriteLine($"AccountHolder = {accountHolder}");
            Console.WriteLine($"AccountNumber = {accountNumber}");
            Console.WriteLine($"DepositInterest = {depositInterest = balance * interestRate}, your interest rate {interestRate}");
        }

        public override double Withdraw(double amount)
        {
            if (amount <= balance)
            {
                Console.WriteLine($"Withdrowed {amount}");
                balance -= amount;
            }
            else
            {
                Console.WriteLine("amount > balance");
            }
            return balance;
        }
    }
}
