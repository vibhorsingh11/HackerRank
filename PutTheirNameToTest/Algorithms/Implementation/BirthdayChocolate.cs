using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class BirthdayChocolate
    {
        static int solve(int n, int[] s, int d, int m)
        {

            // Complete this function
            int sum = 0;
            int r = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
                // M is never less than 1
                if (i > m - 1) sum -= s[i - m];
                if (i >= m - 1 && sum == d) r++;
            }
            return r;
        }


        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solve(n, s, d, m);
            Console.WriteLine(result);
        }
    }
}
