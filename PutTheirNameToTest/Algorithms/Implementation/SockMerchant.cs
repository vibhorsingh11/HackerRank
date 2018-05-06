using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class SockMerchant
    {
        static int sockMerchant(int n, int[] ar)
        {
            // Complete this function
            HashSet<int> hash = new HashSet<int>();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (!hash.Contains(ar[i]))
                {
                    hash.Add(ar[i]);
                }
                else
                {
                    count++;
                    hash.Remove(ar[i]);
                }
            }
            return count;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
    }
}
