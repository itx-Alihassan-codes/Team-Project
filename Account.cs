using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Account
    {
        private string account_number;
        private string account_holder_name;
        private double account_balance;

        public Account(string number, string name, double starting_balance)
        {
            account_number = number;
            account_holder_name = name;
            account_balance = starting_balance;

            Console.WriteLine("New account created!");
        }

        public string GetAccountNumber()
        {
            return account_number;
        }

        public string GetAccountHolderName()
        {
            return account_holder_name;
        }

        public double GetBalance()
        {
            return account_balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                account_balance = account_balance + amount;
                Console.WriteLine($"Deposit successful! Amount: PKR{amount}");
            }
            else
            {
                Console.WriteLine("Amount must be greater than 0!");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= account_balance)
            {
                account_balance = account_balance - amount;
                Console.WriteLine($"Withdrawal successful! Amount: PKR{amount}");
            }
            else if (amount > account_balance)
            {
                Console.WriteLine("Not enough money in your account!");
            }
            else
            {
                Console.WriteLine("Amount must be greater than 0!");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("════════════════════════════════");
            Console.WriteLine($"Account Number: {account_number}");
            Console.WriteLine($"Account Holder: {account_holder_name}");
            Console.WriteLine($"Balance: PKR{account_balance}");
            Console.WriteLine("════════════════════════════════");
        }
    }
}