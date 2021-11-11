using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class Imp8
    {
        public void solution()
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            bool output = Solution8(s);
            Console.WriteLine("SOLUTION 8: {0}", output);
        }

                 /// <summary>
                /// . Given a 3 characters long string, write a method that checks if it consists only  of uppercase letters
                /// </summary>
       public static bool Solution8(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!(s[i] >= 65 && s[i] <= 90))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
