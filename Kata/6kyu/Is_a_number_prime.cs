using System;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5262119038c0985a5b00029f
    public class Is_a_number_prime
    {
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static bool IsPrime_Linq(int n)
        {
            return (n < 2) ? false : Enumerable.Range(2, (int)Math.Sqrt(n)).All(x => n % x != 0) || n == 2;
        }
    }
}
