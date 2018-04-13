using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Codes
{
    class RegEx
    {
        class Solution
        {
            static void Main(String[] args)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                string[] sortArr = new string[];
                int a = 0;
                for (int a0 = 0; a0 < N; a0++)
                {
                    string[] tokens_firstName = Console.ReadLine().Split(' ');
                    string firstName = tokens_firstName[0];
                    string emailID = tokens_firstName[1];
                    Regex reg = new Regex(@"@gmail.com");
                    Match match = reg.Match(emailID);
                    if (match.Success)
                    {
                        sortArr[a++] = firstName;
                    }
                }
                Array.Sort(sortArr);

                for (int i = 0; i < sortArr.Length; i++)
                {
                    if (sortArr != null)
                    {
                        Console.WriteLine(sortArr[i]);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
