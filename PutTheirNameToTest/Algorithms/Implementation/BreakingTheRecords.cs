using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class BreakingTheRecords
    {
        static int[] breakingRecords(int[] score)
        {
            /*
             * Write your code here.
             */
            int comp = score[0];
            int scomp = score[0];
            int[] highScore = new int[score.Length];
            int[] lowestScore = new int[score.Length];
            int[] res = new int[2];
            int m = 0;
            int n = 0;
            for (int i = 0; i <= score.Length - 1; i++)
            {

                if (score[i] > comp)
                {
                    comp = score[i];
                    m++;
                }
                highScore[i] = comp;

                if (score[i] < scomp)
                {
                    scomp = score[i];
                    n++;
                }
                lowestScore[i] = scomp;

            }
            res[0] = m;
            res[1] = n;
            return res;
        }

        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] score = Array.ConvertAll(Console.ReadLine().Split(' '), scoreTemp => Convert.ToInt32(scoreTemp))
            ;
            int[] result = breakingRecords(score);

            tw.WriteLine(string.Join(" ", result));

            tw.Flush();
            tw.Close();
        }
    }
}
