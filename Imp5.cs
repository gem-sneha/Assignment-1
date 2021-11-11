using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class Imp5
    {
        public void solution()
        {
            Console.WriteLine("Input First Number");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second Number");
            int val2 = Convert.ToInt32(Console.ReadLine());
            int result = Solution5(val1, val2);
            Console.WriteLine("SOLUTION 5: {0}", result);
        }


        /// <summary>
        /// Write a C# Sharp program to compute the sum of the two given integer values.If the two values are the same, then return triple their sum.
        /// </summary>
        public int Solution5(int val1, int val2)
        {
            if (val1 == val2)
            {
                return 3 * (val1 + val2);
            }
            else
            {
                return val1 + val2;
            }
        }
    }
}
