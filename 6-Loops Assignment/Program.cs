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
            Console.ReadLine();
            Console.Clear();

            //Do MENU Later

            Prompter();
            BankingMachine();
            DoublesRoller();


        }




        static void Prompter()
        {

            //Each Program must contain error checking
            //Create a prompter that prompts the user for two numbers.
            //the first number number is a min value and the second is a 
            //max value. Prompter then prompts the user for a number within 
            //the min and max numbers entered. The user should be continually prompted
            //until a number within the range is entered. Be sure to include the min and max
            //numbers in the prompt.
            //MAKE SURE THERE IS NO WAY TO GET STUCK INSIDE AN INFINITE LOOP!

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Part 1: Prompter");
            Console.WriteLine();

            int min = 0;
            int max = 0;
            int number = 0;

            bool valid = false;

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

            while (!valid)
            {
                Console.Write("Enter the maximum value: ");

                if (int.TryParse(Console.ReadLine(),out max))
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


                valid = false;

                




            }





        }

        static void BankingMachine()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("Part 2: Simple Banking Machine");
            Console.WriteLine();




        }


        static void DoublesRoller()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Part 3: Double Roller");
            Console.WriteLine();





        }

    }
}
