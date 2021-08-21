using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzAbdulKBusiness;

namespace FizzBuzzAbdulK
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop indefinitely
            {
                Console.WriteLine("Enter Number to Input (Type 'exit' to Exit): ");
                string GetUserInput = Console.ReadLine(); //Get Input
                int a = 0;
                if (int.TryParse(GetUserInput,out a))
                {
                    if (GetUserInput == "exit") // Check 'exit' to Exit from Progrm
                    {
                        break;
                    }

                    FizzBuzzInput(GetUserInput);
                
                }
                else
                {
                    Console.WriteLine("Invalid Input.  Please try again");
                }
                
               
            }

        }

        public static void FizzBuzzInput(string num)
        {

            IFizzBuzz fb = new FizzBuzz();

            Console.Write("Output is: " + fb.GenerateFizzBuzz(Convert.ToInt32(num)) + "\n\n");


        }

    }//end class...

}//end ns...
