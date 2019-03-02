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
            return Enumerable.Range(1, n).Where(x => x % 5 == 0).Select(x => Division(x, 5)).Sum();
        }
        public static int Division(int number, int div)
        {
            if (number % div == 0)
                return 1 + Division(number / div, div);
            return 0;
        }
    }
}