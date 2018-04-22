using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.WeekOfCode37
{
    class TheAverageRatingofTopEmployees
    {
        static void averageOfTopEmployees(int[] rating)
        {
            double sum = 0;
            for (int i = 0; i < rating.Length; i++)
            {
                if (rating[i] >= 90)
                {
                    sum = sum + rating[i];
                }
            }
            double avg = sum / 2;
            avg = avg + 0.001;
            avg = Math.Round(avg, 2);            
            string fom = string.Format("{0:0.00}", avg);
            Console.WriteLine(fom);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] rating = new int[n];

            for (int ratingItr = 0; ratingItr < n; ratingItr++)
            {
                int ratingItem = Convert.ToInt32(Console.ReadLine());
                rating[ratingItr] = ratingItem;
            }

            averageOfTopEmployees(rating);
        }
    }
}
