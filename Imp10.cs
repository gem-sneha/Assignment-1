using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class Imp10
    {
        public void solution()
        {
            Console.WriteLine("Input First Number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second Number");
            int var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input First Operator");
            char op1 = Convert.ToChar(Console.ReadLine());
            int temp1 = Solution10(var1, var2, op1);


            Console.WriteLine("Input Third Number");
            int var3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Fourth Number");
            int var4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second Operator");
            char op2 = Convert.ToChar(Console.ReadLine());
            int temp2 = Solution10(var3, var4, op2);

            if (temp1 == temp2)
            {
                Console.WriteLine("SOLUTION 10: true");
            }
            else
            {
                Console.WriteLine("SOLUTION 10: false");
            }

        }


        /// <summary>
        /// Given two different arithmetic operations (addition, substraction,  multiplication, division), write a method that checks if they return the same result
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="op"></param>
        /// <returns></returns>
        public static int Solution10(int val1, int val2, char op)
        {

            if (op == '+')
            {
                return val1 + val2;
            }
            else if (op == '-')
            {
                return val1 - val2;
            }
            else if (op == '/')
            {
                return val1 / val2;
            }
            else
            {
                return val1 * val2;
            }
        }

    }
}
