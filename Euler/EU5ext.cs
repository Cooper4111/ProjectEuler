using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{

    // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    // 16 * 9 * 5 * 7 * 11 * 13 * 17 * 19 = 232792560
    // Task is elementary and needs only a calculator to be solved. Let's do it at least for any given number.

    class EU5ext
    {
        int GetAnswer(int limit = 20)
        {
            var primes = Tools.GetPrimesUp2(limit);
            int partAsize = (int)Math.Sqrt(limit);
            List<int> powers = new List<int>();
            int i = 0;
            while(i <= partAsize)
            {
                
            }
                

            return 0;
        }
    }
}
