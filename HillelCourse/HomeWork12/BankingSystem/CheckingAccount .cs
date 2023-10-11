using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class CheckingAccount : BankAccount
    {
        double overdraftLimit;
        double overdraftNow;
        double balanceWithOverdraft;
        double buffer;
        public CheckingAccount(string accountHolder, double balance, double overdraftLimit) : base(accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
            balanceWithOverdraft = balance + overdraftNow;
            overdraftNow = overdraftLimit;
        }
        public override double Deposit(double amount)
        {
            Console.WriteLine($"{amount} deposit to balance");
            if ( overdraftLimit > overdraftNow)
            {
                buffer = (amount + overdraftLimit - overdraftNow) - amount;
                overdraftNow += buffer;
                amount -= buffer;
                return balance += amount;
            }
            return balance += amount;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Balance = {balance + overdraftNow}");
            Console.WriteLine($"AccountHolder = {accountHolder}");
            Console.WriteLine($"AccountNumber = {accountNumber}");
            Console.WriteLine($"Your overdraft now is {overdraftNow}, your limit {overdraftLimit}");
        }

        public override double Withdraw(double amount)
        {
            if (balance >= amount)
            {
                Console.WriteLine($"Withdrowed {amount}");
                return balance -= amount;
            }
            else if (balance < amount && overdraftNow >= amount)
            {
                Console.WriteLine($"Withdrowed {amount}");
                balance -= amount;
                overdraftNow += balance;
                return balance = 0;
            }
            else
            {
                Console.WriteLine("You have insufficient funds in your account or have an overdraft");
                return balance;
            }
        }
    }
}
