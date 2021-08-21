using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {


        public static void Main(string[] args)
        {
            //int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            string[] array = { "apple", "banana", "strawberry", "apple" };

            var test = FindDuplicateArry(array, "apple");

            Console.WriteLine(test);
            Console.ReadKey();
        }


        public static int FindDuplicateArry(string[] s, string fruit)
        {
            int nooffruitfound = 0;
            List<string> found = new List<string>();

            foreach (var item in s)
            {
                    if (found.Contains(fruit))
                    {
                        nooffruitfound++;
                        continue;
                    }


                    found.Add(item);


            }

            return nooffruitfound;

        }

    }
    public class MatryoshkaDoll
    {
        private readonly MatryoshkaDoll containedDoll;
        private int noofsmallerdolls;
        public MatryoshkaDoll() { }

        public MatryoshkaDoll(MatryoshkaDoll containedDoll)
        {
            this.containedDoll = containedDoll;
        }

        public int NumberOfSmallerDolls
        {
            get
            {
                noofsmallerdolls = 1;
                return noofsmallerdolls;
            }
        }
    }
}
