using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class CountingValleys
    {
        static int countingValleys(int n, string s)
        {
            // Complete this function
            char[] charArry = s.ToCharArray();
            int mountain = 0; int valley = 0; int count = 0;
            for (int i = 0; i < charArry.Length; i++)
            {
                if (charArry[i] == 'U')
                {
                    if (valley != 0)
                    {
                        valley--;
                        if (valley == 0)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        mountain++;
                    }
                }
                else
                {
                    if (mountain != 0)
                    {
                        mountain--;
                    }
                    else
                    {
                        valley++;
                        if (valley == 0)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int result = countingValleys(n, s);
            Console.WriteLine(result);
        }
    }
}
