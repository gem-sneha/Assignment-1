using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignement1
{
    class Imp2
    {

        public void solution2()
        {
            Console.WriteLine("Enter First Number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Solution(Num1, Num2);
        }

        /// <summary>
        /// Write a C# Sharp program to print the sum of two numbers.
        /// </summary>
        public static void Solution(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("SOLUTION 2: The sum of the given numbers is {0}", result);
            Console.WriteLine("-------------------------------------------------");
        }

    }
}
