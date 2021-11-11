using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class Imp7
    {
        public void solution()
        {
            Solution7();
        }

        ///<summary>
        /// Write a C# Sharp program that takes three letters as input and display them in reverse order.
        /// </summary>
         /// <returns></returns>
        public static void Solution7()
        {
            char[] arr = new char[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Letter {0}", i + 1);
                arr[i] = Convert.ToChar(Console.ReadLine());

            }

            Console.Write("SOLUTION 7: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");

        }
    }
}
