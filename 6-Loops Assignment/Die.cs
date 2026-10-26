using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes
{
    public class Die
    {
        // MUST INCLUDE (_underscore)
        private int _sides; // Private field to store the number of sides on the die
        private int _roll;
        private static Random _generator = new Random();

        public Die()
        {
            _sides = 6;
            _roll = _generator.Next(1, _sides + 1);
        }

        //public Die(int sides)
        //{
        //    _generator = new Random();
        //    _sides = sides; // Set the number of sides based on the parameter
        //    _roll = _generator.Next(1, _sides + 1); // Roll the die to get an initial value
        //}

        //Accessor Properties
        public int Roll
        {
            get { return _roll; }
            //  set { _roll = value; }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            _roll = _generator.Next(1, _sides + 1); // Roll the die to get a new value
        }

        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.WriteLine("|   |");
                Console.WriteLine("| 0 |");
                Console.WriteLine("|   |");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("| 0  |");
                Console.WriteLine("|    |");
                Console.WriteLine("|  0 |");
            }
            else if (_roll == 3)
            {
                Console.WriteLine("|0   |");
                Console.WriteLine("|  0 |");
                Console.WriteLine("|   0|");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("|0  0|");
                Console.WriteLine("|    |");
                Console.WriteLine("|0  0|");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("|0  0|");
                Console.WriteLine("|  0 |");
                Console.WriteLine("|0  0|");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("|0  0|");
                Console.WriteLine("|0  0|");
                Console.WriteLine("|0  0|");
            }


        }

    }
}