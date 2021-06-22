using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    static class Tools
    {
        /// <summary>
        /// Fast O(log(n)) int power: foo.Pow(bar), where foo is any int, and bar is uint
        /// </summary>
        /// <param name="x"></param>
        /// <param name="pow"></param>
        /// <returns></returns>
        public static int Pow(this int x, uint pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }

        /// <summary> Returns array of prime numbers from 2 to N</summary>
        public static List<int> GetPrimesUp2(int N)
        {
            var primes = new List<int>();
            primes.Add(2);
            var num = 3;
            bool isPrime;
            int i;
            while (num <= N)
            {
                isPrime = true;
                i = 0;
                while (isPrime && i < primes.Count)
                {
                    isPrime = num % primes[i] != 0;
                    i++;
                }
                if (isPrime)
                    primes.Add(num);
                num += 2;
            }
            return primes;
        }

        /// <summary>
        /// Returns array of N prime numbers starting from 2
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static List<int> GetNPrimes(int N)
        {
            var primes = new List<int>();
            primes.Add(2);
            var num = 3;
            bool isPrime;
            int i;
            while (primes.Count < N)
            {
                isPrime = true;
                i = 0;
                while (isPrime && i < primes.Count)
                {
                    isPrime = num % primes[i] != 0;
                    i++;
                }
                if (isPrime)
                    primes.Add(num);
                num += 2;
            }
            return primes;
        }
    }
}
