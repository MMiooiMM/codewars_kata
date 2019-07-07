using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/5726f813c8dcebf5ed000a6b
    public class K_Primes
    {
        public static long[] CountKprimes(int k, long start, long end)
        {
            List<long> result = new List<long>();
            while (start <= end)
            {
                result.Add(start);
                start++;
            }
            return result.Where(x => Find_k(x) == k).ToArray();
        }

        public static int Puzzle(int s)
        {
            var a = CountKprimes(1, 0, s);
            var b = CountKprimes(3, 0, s);
            var c = CountKprimes(7, 0, s);
            var result = 0;
            foreach (var aa in a)
            {
                foreach (var bb in b)
                {
                    foreach (var cc in c)
                    {
                        if (aa + bb + cc == s)
                            result++;
                    }
                }
            }
            return result;
        }

        public static int Find_k(long n)
        {
            var res = 0;
            var i = 2;
            while (i * i <= n)
            {
                while (n % i == 0)
                {
                    n /= i;
                    res += 1;
                }
                i += 1;
            }
            if (n > 1) res += 1;
            return res;
        }
    }
}