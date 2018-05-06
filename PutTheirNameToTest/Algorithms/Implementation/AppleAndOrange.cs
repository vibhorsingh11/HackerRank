using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class AppleAndOrange
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            /*
             * Write your code here.
             */
            int resApp = 0;
            int resOr = 0;
            int appCount = 0;
            int orCount = 0;
            for (int i = 0; i <= apples.Length - 1; i++)
            {
                resApp = a + (apples[i]);
                if (resApp >= s && resApp <= t)
                {
                    appCount++;
                }
            }
            for (int j = 0; j <= oranges.Length - 1; j++)
            {
                resOr = b + (oranges[j]);
                if (resOr >= s && resOr <= t)
                {
                    orCount++;
                }
            }
            Console.WriteLine(appCount);
            Console.WriteLine(orCount);
        }

        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apple = Array.ConvertAll(Console.ReadLine().Split(' '), appleTemp => Convert.ToInt32(appleTemp))
            ;

            int[] orange = Array.ConvertAll(Console.ReadLine().Split(' '), orangeTemp => Convert.ToInt32(orangeTemp))
            ;
            countApplesAndOranges(s, t, a, b, apple, orange);
        }
    }
}
