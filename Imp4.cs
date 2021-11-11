using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class Imp4
    {
        public void Solution()
        {
            Console.WriteLine("Input a First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Solution4(a, b);

        }

                 ///<summary>
                /// Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
                /// </summary>
                public void Solution4(int a, int b)
        {
            if (a >= -10 && a <= 10 || b >= -10 && b <= 10)
            {
                Console.WriteLine("SOLUTION 4: True");

            }
            else
            {
                Console.WriteLine("SOLUTION 4: False");
            }
            Console.WriteLine("-------------------------------------------------");
        }

    }
}
