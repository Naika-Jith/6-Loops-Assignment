using Making_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Loops_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Loops Assignment";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome To The Loops Assignment!");
            Console.WriteLine();
            Console.WriteLine("Please press ENTER to continue");
            Console.ReadLine();
            Console.Clear();


            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome! Please select a program:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Simple Banking Machine");
                Console.WriteLine("3 - Roll Until Doubles");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                choice = Console.ReadLine().ToLower().Trim();

                Console.WriteLine();

                if (choice == "1")
                {
                    Prompter();

                    Console.WriteLine();
                    Console.WriteLine("Hit ENTER to return to the menu.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    BankingMachine();

                    Console.WriteLine();
                    Console.WriteLine("Hit ENTER to return to the menu.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    DoublesRoller();

                    Console.WriteLine();
                    Console.WriteLine("Hit ENTER to return to the menu.");
                    Console.ReadLine();
                }
                else if (choice == "q")
                {
                    Console.WriteLine("Thank you for using the program!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Press ENTER to try again.");
                    Console.ReadLine();
                }
            }


        }




        static void Prompter()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Part 1: Prompter");
            Console.WriteLine();

            int min = 0;
            int max = 0;
            int number = 0;

            bool valid = false;

            // Get minimum

            while (!valid)
            {
                Console.Write("Enter the minimum value: ");
                valid = int.TryParse(Console.ReadLine(), out min);

                if (!valid)
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }

            valid = false;

            // Get maximum

            while (!valid)
            {
                Console.Write("Enter the maximum value: ");

                if (int.TryParse(Console.ReadLine(), out max))
                {
                    if (max >= min)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Maximum must be greater than or equal to minimum.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }

            valid = false;

            // Get number within range

            while (!valid)
            {
                Console.Write("Enter a number between " + min + " and " + max + ": ");

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= min && number <= max)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Number is outside the range. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }

            Console.WriteLine("Valid number entered: " + number);

        }

        static void BankingMachine()
        {

            // Part 2: Simple Banking Machine

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Part 2: Simple Banking Machine");
            Console.WriteLine();

            double balance = 150.00;
            double amount = 0;
            double fee = 0.75;

            string transaction = "";

            while (transaction != "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdrawal");
                Console.WriteLine("Bill Payment");
                Console.WriteLine("Balance");
                Console.WriteLine("Quit");

                Console.Write("Enter a transaction: ");
                transaction = Console.ReadLine().Trim().ToLower();

                if (transaction == "quit")
                {
                    break;
                }

                // Check if the transaction fee can be paid
                if (balance < fee)
                {
                    Console.WriteLine("Insufficient funds to pay the transaction fee.");
                    Console.WriteLine("Final balance: $" + balance.ToString("F2"));
                    break;
                }

                // Deposit
                else if (transaction == "deposit")
                {
                    Console.Write("Enter amount to deposit: ");

                    if (double.TryParse(Console.ReadLine(), out amount) && amount > 0)
                    {
                        balance = balance + amount - fee;
                        Console.WriteLine("Deposit successful!");
                    }
                    else
                    {
                        balance = balance - fee;
                        Console.WriteLine("Invalid amount. Transaction fee charged.");
                    }
                }

                // Withdrawal
                else if (transaction == "withdrawal")
                {
                    Console.Write("Enter amount to withdraw: ");

                    if (double.TryParse(Console.ReadLine(), out amount) && amount > 0)
                    {
                        if (amount + fee <= balance)
                        {
                            balance = balance - amount - fee;
                            Console.WriteLine("Withdrawal successful!");
                        }
                        else
                        {
                            balance = balance - fee;
                            Console.WriteLine("Insufficient funds. Transaction fee charged.");
                        }
                    }
                    else
                    {
                        balance = balance - fee;
                        Console.WriteLine("Invalid amount. Transaction fee charged.");
                    }
                }

                // Bill Payment
                else if (transaction == "bill payment")
                {
                    Console.Write("Enter bill payment amount: ");

                    if (double.TryParse(Console.ReadLine(), out amount) && amount > 0)
                    {
                        if (amount + fee <= balance)
                        {
                            balance = balance - amount - fee;
                            Console.WriteLine("Bill payment successful!");
                        }
                        else
                        {
                            balance = balance - fee;
                            Console.WriteLine("Insufficient funds. Transaction fee charged.");
                        }
                    }
                    else
                    {
                        balance = balance - fee;
                        Console.WriteLine("Invalid amount. Transaction fee charged.");
                    }
                }

                // Account Balance
                else if (transaction == "balance")
                {
                    balance = balance - fee;
                    Console.WriteLine("Balance updated.");
                }

                // Invalid transaction
                else
                {
                    balance = balance - fee;
                    Console.WriteLine("Invalid transaction. Transaction fee charged.");
                }

                Console.WriteLine("Current balance: $" + balance.ToString("F2"));
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using BoBTM!");
            Console.WriteLine("Final balance: $" + balance.ToString("F2"));
        }


        static void DoublesRoller()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Part 3: Roll Until Doubles");
            Console.WriteLine();

            Die die1 = new Die();
            Die die2 = new Die();

            int rolls = 0;
            bool doubles = false;

            while (!doubles)
            {
                rolls++;

                Console.WriteLine();
                Console.WriteLine("Roll #" + rolls);

                Console.WriteLine("Die 1: " + die1.Roll);
                die1.DrawRoll();

                Console.WriteLine();

                Console.WriteLine("Die 2: " + die2.Roll);
                die2.DrawRoll();

                if (die1.Roll == die2.Roll)
                {
                    doubles = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to roll again.");
                    Console.ReadLine();

                    die1.RollDie();
                    die2.RollDie();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Doubles!");
            Console.WriteLine("Number of rolls required: " + rolls);
        }

    }
}
