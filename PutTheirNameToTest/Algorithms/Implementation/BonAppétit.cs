using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class BonAppétit
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] bill = Array.ConvertAll(ar_temp, Int32.Parse);
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + bill[i];
            }
            sum = sum - bill[k];
            sum = sum / 2;
            if (sum == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                sum = b - sum;
                Console.WriteLine(sum);
            }
        }
    }
}
