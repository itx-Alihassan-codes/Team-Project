using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Bank
    {
        private string bank_name;
        private Account[] all_accounts;
        private int accountCount;

        public Bank(string name)
        {
            bank_name = name;
            all_accounts = new Account[100];
            accountCount = 0;
            Console.WriteLine($"{bank_name} Branch 1122");
        }

        public void AddAccount(Account new_account)
        {
            if (accountCount < all_accounts.Length)
            {
                all_accounts[accountCount] = new_account;
                accountCount++;
                Console.WriteLine($"Account added to {bank_name}");
            }
            else
            {
                Console.WriteLine("Bank is full! Cannot add more accounts.");
            }
        }

        public Account FindAccount(string account_number)
        {
            for (int i = 0; i < accountCount; i++)
            {
                if (all_accounts[i].GetAccountNumber() == account_number)
                {
                    return all_accounts[i];
                }
            }
            return null;
        }

        public void ShowAllAccounts()
        {
            if (accountCount == 0)
            {
                Console.WriteLine("No accounts in the bank!");
                return;
            }

            Console.WriteLine($"\n All Accounts in {bank_name}:");
            Console.WriteLine("════════════════════════════════");

            for (int i = 0; i < accountCount; i++)
            {
                Account account = all_accounts[i];
                Console.WriteLine($"{i + 1}. {account.GetAccountHolderName()} - Acc#: {account.GetAccountNumber()} - Balance: ${account.GetBalance()}");
            }

            Console.WriteLine("════════════════════════════════\n");
        }

        public double GetTotalMoney()
        {
            double total_money = 0;

            for (int i = 0; i < accountCount; i++)
            {
                total_money = total_money + all_accounts[i].GetBalance();
            }

            return total_money;
        }

        public void DisplayBankInfo()
        {
            Console.WriteLine("\nBANK INFORMATION");
            Console.WriteLine("════════════════════════════════");
            Console.WriteLine($"Bank Name: {bank_name}");
            Console.WriteLine($"Total Accounts: {accountCount}");
            Console.WriteLine($"Total Money in Bank: ${GetTotalMoney()}");
            Console.WriteLine("════════════════════════════════\n");
        }
    }
}