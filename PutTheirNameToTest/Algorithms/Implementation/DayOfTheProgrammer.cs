using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class DayOfTheProgrammer
    {
        static string solve(int year)
        {
            string res = "";
            // Complete this function
            if (year < 1918)
            {
                if (year % 4 == 0)
                {
                    res = "12.09." + year;
                }
                else
                {
                    res = "13.09." + year;
                }
            }
            else if (year == 1918)
            {
                res = "26.09." + year;
            }
            else if (year > 1918)
            {
                if (year % 400 == 0)
                {
                    res = "12.09." + year;
                }
                else if (year % 4 == 0 && year % 100 != 0)
                {
                    res = "12.09." + year;
                }
                else
                {
                    res = "13.09." + year;
                }
            }
            return res;
        }

        static void Main(String[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string result = solve(year);
            Console.WriteLine(result);
        }
    }
}
