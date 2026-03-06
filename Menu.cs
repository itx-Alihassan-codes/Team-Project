using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Menu
    { 
        private Bank my_bank;

        public Menu(Bank bank)
        {
            my_bank = bank;
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("\n╔════════════════════════════════╗");
            Console.WriteLine("║   BANKING MANAGEMENT SYSTEM    ║");
            Console.WriteLine("╠════════════════════════════════╣");
            Console.WriteLine("║ 1. Create New Account          ║");
            Console.WriteLine("║ 2. Deposit Money               ║");
            Console.WriteLine("║ 3. Withdraw Money              ║");
            Console.WriteLine("║ 4. Check Balance               ║");
            Console.WriteLine("║ 5. View All Accounts           ║");
            Console.WriteLine("║ 6. View Bank Information       ║");
            Console.WriteLine("║ 7. Exit                        ║");
            Console.WriteLine("╚════════════════════════════════╝");
        }

        public void HandleUserChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    {
                        CreateAccount();
                        break;
                    }
                case 2:
                    {
                        DepositMoney();
                        break;
                    }
                case 3:
                    {
                        WithdrawMoney();
                        break;
                    }
                case 4:
                    {
                        CheckBalance();
                        break;
                    }
                case 5:
                    {
                        ViewAllAccounts();
                        break;
                    }
                case 6:
                    {
                        ViewBankInfo();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("\nThank you for using our bank!! Goodbye");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nInvalid choice! Please try again.");
                        break;
                    }
            }
        }

        private void CreateAccount()
        {
            Console.WriteLine("\n--- Create New Account ---");

            Console.Write("Enter Account Number: ");
            string account_number = Console.ReadLine();

            Console.Write("Enter Account Holder Name: ");
            string account_holder_name = Console.ReadLine();

            Console.Write("Enter Starting Balance: PKR ");
            double starting_balance = double.Parse(Console.ReadLine());

            Account new_account = new Account(account_number, account_holder_name, starting_balance);
            my_bank.AddAccount(new_account);

        }
        private void DepositMoney()
        {
            Console.WriteLine("\n--- Deposit Money ---");

            Console.Write("Enter Account Number: ");
            string account_number = Console.ReadLine();

            Account found_account = my_bank.FindAccount(account_number);

            if (found_account != null)
            {
                Console.Write("Enter Amount to Deposit: PKR ");
                double amount = double.Parse(Console.ReadLine());
                found_account.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account not found!");
            }
        }

        private void WithdrawMoney()
        {
            Console.WriteLine("\n--- Withdraw Money ---");

            Console.Write("Enter Account Number: ");
            string account_number = Console.ReadLine();

            Account found_account = my_bank.FindAccount(account_number);

            if (found_account != null)
            {
                Console.Write("Enter Amount to Withdraw: $");
                double amount = double.Parse(Console.ReadLine());
                found_account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Account not found!");
            }
        }

        private void CheckBalance()
        {
            Console.WriteLine("\n--- Check Balance ---");

            Console.Write("Enter Account Number: ");
            string account_number = Console.ReadLine();

            Account found_account = my_bank.FindAccount(account_number);

            if (found_account != null)
            {
                Console.WriteLine($"\nBalance for {found_account.GetAccountHolderName()}: ${found_account.GetBalance()}");
            }
            else
            {
                Console.WriteLine(" Account Not Found !");
            }
        }

        private void ViewAllAccounts()
        {
            my_bank.ShowAllAccounts();
        }

        private void ViewBankInfo()
        {
            my_bank.DisplayBankInfo();
        }
    }
}