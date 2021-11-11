using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class Imp9
    {
        public void solution()
        {

            bool output2 = Solution9();
            Console.WriteLine("SOLUTION 9: {0}", output2);

        }
        ///<summary>
        ///  Given a string, write a method that checks if consists of letters only. Expected input and output
        /// </summary>
        public static bool Solution9()
        {
            Console.WriteLine("Enter the string");
            string a = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                if (!((a[i] >= 65 && a[i] <= 90) || (a[i] >= 97 && a[i] <= 122) || (a[i] == 32)))
                {
                    return false;
                }

            }
            return true;
        }

    }
}
