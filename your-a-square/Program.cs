using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace your_a_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an integral number, determine if it's a square number.
             */

            Console.WriteLine(IsSquare(4));
            Console.ReadLine();

        }

        public static bool IsSquare(int n)
        {
            return (Math.Sqrt(n) % 1 == 0);
        }
    }
}
