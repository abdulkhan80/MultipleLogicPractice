using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Program
    {
        public delegate string myDelegate(int arg1, int arg2);

        public static string FnSum(int arg1, int arg2)
        {
            return (arg1 + arg2).ToString();
        }

        public static string FnMultiple(int arg1, int arg2)
        {
            return (arg1 * arg2).ToString();
        }

        public static int FnSum1(int arg1, int arg2)
        {
            return (arg1 + arg2);
        }

        public static int FnMultiple1(int arg1, int arg2)
        {
            return (arg1 * arg2);
        }
        static void Main(string[] args)
        {

            myDelegate mm;
            int test;

            while (true) // Loop indefinitely
            {
                Console.WriteLine("Enter input for calculation:"); // Prompt
                string cal = Console.ReadLine();

                if (cal.Equals("sum"))
                {
                    Console.WriteLine("Enter number for add:"); // Prompt
                    string nadd = Console.ReadLine();
                    //mm = FnSum;
                    //Console.WriteLine("The Sum is: " + mm(Convert.ToInt32(nadd), 4));
                    test = FnSum1(Convert.ToInt32(nadd), 4);
                    Console.WriteLine("The Sum is: " + test);
                }
                else if (cal.Equals("multi"))
                {
                    string nmuli = Console.ReadLine();
                    //mm = FnMultiple;
                    //Console.WriteLine("The Multiple is: " + mm(Convert.ToInt32(nmuli), 4));
                    test = FnMultiple1(Convert.ToInt32(nmuli), 3);
                    Console.WriteLine("The Multiple is: " + test);
                }

                if (cal == "exit") // Check string
                {
                    break;
                }

                //int test = FnSum1(5, 4);
                //Console.WriteLine("The Sum is: " + test);

                //test = FnMultiple1(5, 3);
                //Console.WriteLine("The Multiple is: " + test);
            }

            //Console.ReadKey();

        }
    }
}
