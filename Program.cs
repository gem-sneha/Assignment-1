using System;

namespace Assignement1
{
    class Program
    {
        static void Main(string[] args)
        {

            Imp1 q1 = new Imp1();
            // q1.solution();

            Imp2 q2 = new Imp2();
            //q2.solution2();

            Imp3 q3 = new Imp3();
            //q3.Solution3();

            Imp4 q4 = new Imp4();
            //q4.Solution();

            Imp5 q5 = new Imp5();
           // q5.solution();

            Imp6 q6 = new Imp6();
            // q6.solution();

            Imp7 q7 = new Imp7();
            //q7.solution();

            Imp8 q8 = new Imp8();
            // q8.solution();

            Imp9 q9 = new Imp9();
            // q9.solution();

            Imp10 q10 = new Imp10();
            q10.solution();



            //................................................//

            //Console.WriteLine("Enter First Number");
            //int Num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //int Num2 = Convert.ToInt32(Console.ReadLine());
            //obj1.Solution2(Num1, Num2);

            //...............................................//


            //Console.WriteLine("Input First Number");
            //int X = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input Second Number");
            //int Y = Convert.ToInt32(Console.ReadLine());
            //obj1.Solution3(X, Y);

            //...............................................//


            //Console.WriteLine("Input a First Number");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input a Second Number");
            //int b = Convert.ToInt32(Console.ReadLine());
            //obj1.Solution4(a, b);


            //...............................................//

            //Console.WriteLine("Input First Number");
            //int val1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input Second Number");
            //int val2 = Convert.ToInt32(Console.ReadLine());
            //int result = obj1.Solution5(val1, val2);
            //Console.WriteLine("SOLUTION 5: {0}", result);

            //...............................................//


            //string status = obj1.Solution6();
            //Console.WriteLine("SOLUTION 6: {0}", status);

            //...............................................//


            //obj1.Solution7();


            //...............................................//

            //Console.WriteLine("Enter the string");
            //string s = Console.ReadLine();
            //bool output = obj1.Solution8(s);
            //Console.WriteLine("SOLUTION 8: {0}", output);


            //...............................................//


            //bool output2 = obj1.Solution9();
            //Console.WriteLine("SOLUTION 9: {0}", output2);

            //...............................................//

            //Console.WriteLine("Input First Number");
            //int var1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input Second Number");
            //int var2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input First Operator");
            //char op1 = Convert.ToChar(Console.ReadLine());
            //int temp1 = obj1.Solution10(var1, var2, op1);


            //Console.WriteLine("Input Third Number");
            //int var3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input Fourth Number");
            //int var4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input Second Operator");
            //char op2 = Convert.ToChar(Console.ReadLine());
            //int temp2 = obj1.Solution10(var3, var4, op2);

            //if (temp1 == temp2)
            //{
            //    Console.WriteLine("SOLUTION 10: true");
            //}
            //else
            //{
            //    Console.WriteLine("SOLUTION 10: false");
            //}

        }
    }
}

//    public class Implementations
//    {
//        /// <summary>
//        /// Write a C# Sharp program to print Hello and your name in a separate line
//        /// </summary>
//        public void Solution1()
//        {
//            Console.Write("SOLUTION 1: ");
//            Console.WriteLine("Hello");
//            Console.WriteLine("Sneha Goel");
//            Console.WriteLine("-------------------------------------------------");
//        }

//        ///// <summary>
//        ///// Write a C# Sharp program to print the sum of two numbers.
//        ///// </summary>
//        //public void Solution2(int num1, int num2)
//        //{
//        //    int result = num1 + num2;
//        //    Console.WriteLine("SOLUTION 2: The sum of the given numbers is {0}", result);
//        //    Console.WriteLine("-------------------------------------------------");
//        //}


//        /// <summary>
//        /// Write a C# Sharp program to swap two numbers.
//        /// </summary>
//        public void Solution3(int x, int y)
//        {
//            int temp = 0;
//            temp = x;
//            x = y;
//            y = temp;
//            Console.WriteLine("SOLUTION 3: First number: {0} \n Second number: {1}", x, y);
//            Console.WriteLine("-------------------------------------------------");
//        }

//        /// <summary>
//        /// Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
//        /// </summary>
//        public void Solution4(int a, int b)
//        {
//            if (a >= -10 && a <= 10 || b >= -10 && b <= 10)
//            {
//                Console.WriteLine("SOLUTION 4: True");

//            }
//            else
//            {
//                Console.WriteLine("SOLUTION 4: False");
//            }
//            Console.WriteLine("-------------------------------------------------");
//        }


//        /// <summary>
//        /// Write a C# Sharp program to compute the sum of the two given integer values.If the two values are the same, then return triple their sum.
//        /// </summary>
//        public int Solution5(int val1, int val2)
//        {
//            if (val1 == val2)
//            {
//                return 3 * (val1 + val2);
//            }
//            else
//            {
//                return val1 + val2;
//            }
//        }

//        /// <summary>
//        /// Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
//        /// </summary>
//        public string Solution6()
//        {
//            string UserId = "Sneha_Goel";
//            string Password = "Sneha@17";
//            int n = 3;
//            while (n > 0)
//            {
//                Console.WriteLine("Enter User_Id");
//                string userId = Console.ReadLine();
//                Console.WriteLine("Enter Password");
//                string password = Console.ReadLine();


//                if (UserId == userId && Password == password)
//                {
//                    return "User is successfully logged in";
//                    Console.WriteLine("-------------------------------------------------");
//                }

//                else
//                {
//                    Console.WriteLine("Incorrect userId or password");
//                    Console.WriteLine();
//                    n--;
//                }
//            }
//            return "Either UserId or Password are incoorrect You can't log in!!";
//            Console.WriteLine("-------------------------------------------------");
//        }



//        /// <summary>
//        /// Write a C# Sharp program that takes three letters as input and display them in reverse order.
//        /// </summary>
//        /// <returns></returns>
//        public void Solution7()
//        {
//            char[] arr = new char[3];
//            for (int i = 0; i < 3; i++)
//            {
//                Console.WriteLine("Enter Letter {0}", i + 1);
//                arr[i] = Convert.ToChar(Console.ReadLine());

//            }

//            Console.Write("SOLUTION 7: ");
//            for (int i = arr.Length - 1; i >= 0; i--)
//            {
//                Console.Write(arr[i] + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine("-------------------------------------------------");

//        }

//        /// <summary>
//        /// . Given a 3 characters long string, write a method that checks if it consists only  of uppercase letters
//        /// </summary>
//        public bool Solution8(string s)
//        {
//            for (int i = 0; i < s.Length; i++)
//            {
//                if (!(s[i] >= 65 && s[i] <= 90))
//                {
//                    return false;
//                }

//            }
//            return true;
//        }

//        /// <summary>
//        ///  Given a string, write a method that checks if consists of letters only. Expected input and output
//        /// </summary>
//        public bool Solution9()
//        {
//            Console.WriteLine("Enter the string");
//            string a = Console.ReadLine();
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (!((a[i] >= 65 && a[i] <= 90) || (a[i] >= 97 && a[i] <= 122) || (a[i] == 32)))
//                {
//                    return false;
//                }

//            }
//            return true;
//        }

//        /// <summary>
//        /// Given two different arithmetic operations (addition, substraction,  multiplication, division), write a method that checks if they return the same result
//        /// </summary>
//        /// <param name="val1"></param>
//        /// <param name="val2"></param>
//        /// <param name="op"></param>
//        /// <returns></returns>
//        public int Solution10(int val1, int val2, char op)
//        {

//            if (op == '+')
//            {
//                return val1 + val2;
//            }
//            else if (op == '-')
//            {
//                return val1 - val2;
//            }
//            else if (op == '/')
//            {
//                return val1 / val2;
//            }
//            else
//            {
//                return val1 * val2;
//            }
//        }
//    }
//}

