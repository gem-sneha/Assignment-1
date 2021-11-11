using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class Imp3
    {
        public void Solution3()
        {
            Console.WriteLine("Input First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second Number");
            int Y = Convert.ToInt32(Console.ReadLine());
            Solution(X, Y);
        }

      /// <summary>
      /// Write a C# Sharp program to swap two numbers.
      /// </summary>
       public static void Solution(int x, int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("SOLUTION 3: First number: {0} \n Second number: {1}", x, y);
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
