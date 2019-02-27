using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/561e9c843a2ef5a40c0000a4
    public static class Gap_in_Primes
    {
        public static long[] Gap(int g, long m, long n)
        {
            List<long> Primes = new List<long>();
            long prev = -1;
            double sqrtn = System.Math.Sqrt(n);
            for (long next = 2; next <= sqrtn; next++)
            {
                if (!Primes.Any(x => next % x == 0))
                {
                    Primes.Add(next);
                }
            }
            for (long next = m; next <= n; next++)
            {
                if (!Primes.Any(x => next % x == 0))
                {
                    if (next >= m)
                    {
                        if (next - prev == g)
                            return new long[] { prev, next };
                        prev = next;
                    }
                }
            }
            return null;
        }
    }
}
