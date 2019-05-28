using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/541c8630095125aba6000c00
    public class Sum_of_Digits_Digital_Root
    {
        public static int DigitalRoot(long n)
        {
            while(n > 10)
            {
                long sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                n = sum;
            }
            return (int)n;
        }
    }

    public class Sum_of_Digits_Digital_Root_Clever
    {
        public static int DigitalRoot(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }
    }
}
