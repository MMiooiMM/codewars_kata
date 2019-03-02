using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/number-of-trailing-zeros-of-n
    public static class Number_of_trailing_zeros_of_N
    {
        public static int TrailingZeros(int n)
        {
            var max5 = Math.Log(n, 5);
            var count = 0;
            var numbers = Enumerable.Range(1, n);
            for (int i = 1; i <= max5; i++)
            {
                numbers = numbers.Where(x => x % Math.Pow(5, i) == 0);
                count += numbers.Count();
            }
            return count;
        }
    }
}