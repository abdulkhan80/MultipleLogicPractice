using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OtherTest
{
    class Program
    {
        private readonly string message;
        private readonly int seconds;

       /* public Reminder (int seconds, string message)
        {
            this.seconds = seconds;
            this.message = message;
        }
        public void Run()
        {
            Thread.Sleep(second * 1000);
            Console.Write(message + " ");
        }*/
        static void Main(string[] args)
        {
           /* Thread t1 = new Thread(new Reminder(1, "1").Run);
            Thread t2 = new Thread(new Reminder(1, "1").Run);
            Thread t3 = new Thread(new Reminder(1, "1").Run);

            t3.Start();
            t1.Start();
            t3.Join();
            t2.Start();
            t1.Join();
            t2.Join();*/
        }

        public static int factorial(int num)
        {
            if (num == 0)
                return 1;

            return num * factorial(num - 1);
        }

        public static bool plindrom(string text)
        {
            string test=string.Empty;

            for(int i=text.Length-1;i>=0;i--)
            {
                test = test + text[i];
            }

            if (test.Equals(text))
                return true;
            else
                return false;

        }

        public static int[] randomIntArray()
        {
            Random random = new Random();
            int maxsize = 10;
            int[] randomNos = new int[maxsize];
            int rndIntArr = 0;

            while (rndIntArr < randomNos.Length)
            {

                bool repeated = false;

                int nextRndNo = random.Next(1, maxsize + 1);

                for (int j = 0; j < rndIntArr; j++)
                {
                    if (randomNos[j] == nextRndNo)
                    {

                        repeated = true;
                        break;
                    }
                }

                if (!repeated)
                {
                    randomNos[rndIntArr] = nextRndNo;
                }
                else
                {

                    rndIntArr--;

                }

                rndIntArr++;
            }

            return randomNos;
        }

    }
}
