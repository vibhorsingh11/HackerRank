using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class MigratoryBirds
    {
        static int migratoryBirds(int n, int[] ar)
        {
            int[] num = new int[ar.Length];
            // Complete this function
            for (int i = 0; i < n; i++)
            {
                num[ar[i]]++;
            }
            int max = 0;
            int res = 0;
            for (int j = 0; j < n; j++)
            {
                if (max < num[j])
                {
                    max = num[j];
                    res = j;
                }
            }
            return res;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
        }
    }
}
