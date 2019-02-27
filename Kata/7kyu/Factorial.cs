using System;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc
    public static class Factorial
    {
        public static int _Factorial(int n)
        {
            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (n == 1 || n == 0)
            {
                return 1;
            }
            return n * _Factorial(n - 1);
        }
    }
}
