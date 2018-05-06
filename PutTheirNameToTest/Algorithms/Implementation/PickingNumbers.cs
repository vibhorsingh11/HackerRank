using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class PickingNumbers
    {
        static int pickingNumbers(int[] a)
        {
            // Complete this function
            int max = 0;
            int count;
            for (int j = 0; j < a.Length; j++)
            {
                count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (Math.Abs(a[j] - a[i]) == 0 || a[j] - a[i] == -1)
                    {
                        count++;
                    }
                }
                if (count > max)
                {
                    max = count;
                }
            }
            return max;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int result = pickingNumbers(a);
            Console.WriteLine(result);
        }
    }
}
