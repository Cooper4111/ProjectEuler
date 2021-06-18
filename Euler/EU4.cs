using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
/*
A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
*/

    class EU4
    {
        int IntPow(int x, uint pow)
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

        public bool isPal(int num)
        {
            List<int> digits = new List<int>();
            int rem = 0;
            while(num > 0)
            {
                num = Math.DivRem(num, 10, out rem);
                digits.Add(rem);
            }
            //foreach (int digit in digits)
                //Console.Write(digit);
           //Console.WriteLine();

            int begIdx = 0;
            int endIdx = digits.Count-1;
            bool isPalindrome = true;
            while (isPalindrome && endIdx > begIdx)
            {
                //Console.WriteLine($"{digits[begIdx]} vs {digits[endIdx]}");
                isPalindrome = isPalindrome && (digits[begIdx] == digits[endIdx]);
                begIdx++;
                endIdx--;
            }
            return isPalindrome;
        }

        public List<(int,int)> getMaxPals(uint numOfDigs)
        {
            List<(int, int)> results = new List<(int, int)>();
            int num1 = 10.Pow(numOfDigs) - 1;
            int num2 = num1;
            //var flag = true;
            while (num1 / num2 < 2)
            {
                for(int i = num1; i >= num2; i--)
                {
                    if (isPal(num2 * i))
                    {
                        results.Add((num2, i));
                    }
                }
                num2--;
            }
            return results;
        }

        public int GetMaxPal(uint numOfDigs)
        {
            List<int> results = new List<int>();
            int num1 = 10.Pow(numOfDigs) - 1;
            int num2 = num1;
            //var flag = true;
            while (num1 / num2 < 2)
            {
                for (int i = num1; i >= num2; i--)
                {
                    if (isPal(num2 * i))
                    {
                        results.Add(num2 * i);
                    }
                }
                num2--;
            }
            results.Sort();
            return results[results.Count-1];
        }
    }
}
