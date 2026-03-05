using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        { 
                Bank my_bank = new Bank("Habib Bank Limited (HBL)");

                Console.WriteLine("\n╔════════════════════════════════╗");
                Console.WriteLine("║        WELCOME TO BANK!        ║");
                Console.WriteLine("╚════════════════════════════════╝");

                Menu bank_menu = new Menu(my_bank);

                bool is_running = true;

                while (is_running)
                {

                    bank_menu.ShowMainMenu();

                    Console.Write("Enter your choice (1-7): ");
                    int input = int.Parse(Console.ReadLine());
                    if (input != 0)
                    { 
                        bank_menu.HandleUserChoice(input);

                        if (input == 7)
                        {
                            is_running = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
        }

    }
}