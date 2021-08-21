using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodelityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = solution(new int[] { 3, 5, 6, 3, 3, 5 });

            Console.WriteLine("This element not found it's paired: " + test);


            // int[] A = new int[] {5,3,6,3,4,2 };

            /*
            int best = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int c = find(top, A[i]) - i;

                if (c > best) best = c;

                if (best >= A.Length - i)
                    Console.WriteLine(best);
            }
            */

            Console.ReadKey();
        }

        public static int solution(int[] A)
        {
            int[] top = new int[A.Length];
            int max = -int.MaxValue;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] > max) max = A[i];
                top[i] = max;
            }

            int best = 0;
            int curMaxIndex = 0;
            for (int i = 0; i < A.Length; i++)
            {
                while (curMaxIndex < top.Length && top[curMaxIndex] >= A[i])
                    curMaxIndex++;
                if ((curMaxIndex - 1 - i) > best)
                    best = curMaxIndex - 1 - i;
            }

            return best;
            /*
            int result = 0;
            int N = A.Length;
            int[] prefix = new int[N + 1];
            for (int i = 1; i < prefix.Length; i++)
            {
                prefix[i] = prefix[i - 1] + A[i - 1];
            }
            double avg = double.MaxValue;
            for (int i = 1; i < N; i++)
            {
                for (int j = i + 1; j <= N; j++)
                {
                    double temp = (double)(prefix[j] - prefix[i - 1]) / (double)(j - i + 1);
                    if (temp < avg)
                    {
                        avg = temp;
                        result = i - 1;
                    }
                }
            }
            return result;
           
            int[] top = new int[A.Length];
            int max = -int.MaxValue;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] > max) max = A[i];
                top[i] = max;
            }

            int best = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int c = find(top, A[i]) - i;
                if (c > best) best = c;
                if (best >= A.Length - i) return best;
            }

            return best; */
        }

        private static int find(int[] t, int min)
        {
            int s = 0;
            int e = t.Length - 1;

            if (t[e] >= min) return e;

            while (true)
            {
                int x = (s + e) / 2;
                if (x == t.Length - 1) return t.Length - 1;
                if (t[x] >= min && t[x + 1] < min) return x;

                if (t[x] < min) e = x;
                else s = x;
            }
        }
    }
}
