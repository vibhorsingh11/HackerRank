using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class TheHurdleRace
    {
        static int hurdleRace(int k, int[] height)
        {
            // Complete this function        
            int max = k;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                }
            }
            if (max > k)
            {
                max = max - k;
            }
            else
            {
                max = 0;
            }
            return max;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);
            int result = hurdleRace(k, height);
            Console.WriteLine(result);
        }
    }
}
