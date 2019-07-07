using System;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/526571aae218b8ee490006f4
    public class Bit_Counting
    {
        public static int CountBits(int n)
        {
            int count = 0;
            while (n >= 1)
            {
                count += (n % 2);
                n /= 2;
            }
            return count;
        }

        public static int CountBits_Linq(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}