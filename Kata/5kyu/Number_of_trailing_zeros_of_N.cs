using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/number-of-trailing-zeros-of-n
    public class Number_of_trailing_zeros_of_N
    {
        public static int TrailingZeros(int n)
        {
            int count = 0;
            while (n > 1)            
                count += (int)(n /= 5);            
            return count;
        }
    }
}