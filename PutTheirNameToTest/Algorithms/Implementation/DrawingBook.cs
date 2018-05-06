using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Algorithms.Implementation
{
    class DrawingBook
    {
        int pageCount(int n, int p)
        {
            /*
             * Write your code here.
             */
            int ans = 0;
            int front = p / 2;
            int back = (n / 2 - p / 2);
            if (front < back) ans = front;
            else ans = back;
            return ans;
        }

    }
}
