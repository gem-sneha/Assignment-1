using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class Imp6
    {
        public void solution()
        {
            string status = Solution6();
            Console.WriteLine("SOLUTION 6: {0}", status);

        }

        /// <summary>
        /// Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
        /// </summary>
        public static string Solution6()
        {
            string UserId = "Sneha_Goel";
            string Password = "Sneha@17";
            int n = 3;
            while (n > 0)
            {
                Console.WriteLine("Enter User_Id");
                string userId = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();


                if (UserId == userId && Password == password)
                {
                    return "User is successfully logged in";
                    Console.WriteLine("-------------------------------------------------");
                }

                else
                {
                    Console.WriteLine("Incorrect userId or password");
                    Console.WriteLine();
                    n--;
                }
            }
            return "Either UserId or Password are incoorrect You can't log in!!";
            Console.WriteLine("-------------------------------------------------");
        }


    }
}
