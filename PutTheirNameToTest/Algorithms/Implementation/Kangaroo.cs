using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class Kangaroo
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            // Complete this function
            int x1jump = 0;
            int x2jump = 0;
            string result = "";
            for (int i = 0; i <= 10000; i++)
            {
                x1 = x1 + v1;
                x1jump++;
                x2 = x2 + v2;
                x2jump++;
                if (x1 == x2)
                {
                    result = "YES";
                    break;
                }
                else
                {
                    result = "NO";
                }
            }
            return result;
        }

        static void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}
