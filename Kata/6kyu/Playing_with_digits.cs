using System;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5552101f47fc5178b1000050
    public class Playing_with_digits
    {
        public static long digPow(int n, int p)
        {
            double a = Math.Log10(n);
            double result;
            long Sum = 0;
            for (int i = 0; i <= a; i++)
            {
                var s = n.ToString()[i].ToString();
                Sum += (long)Math.Pow(double.Parse(s), (double)i + p);
            }
            result = Sum / (double)n;
            if (result != (long)result)
                return -1;
            return (long)result;
        }
    }
}