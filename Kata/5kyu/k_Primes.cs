using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._5kyu
{
    public static class K_Primes
    {
        public static long[] CountKprimes(int k, long start, long end)
        {
            
            List<long> results = new List<long>();
            while(start <= end)
            {
                results.Add(start);
                start++;
            }
            return PrimeFactorsCount(results).Where(x => x.Count == k).Select(x => x.Value).ToArray();
        }

        private static IEnumerable<Pair> PrimeFactorsCount(List<long> value)
        {
            var pairs = value.Select(x => new Pair() { Value = x, Count = 0, Temp = x }).ToList();

            var enumerator = GetPrimes().GetEnumerator();
            enumerator.MoveNext();


            while (pairs.Any(x => x.Temp != 1))
            {
                foreach(var pair in pairs)
                {
                    while(pair.Temp % enumerator.Current == 0)
                    {
                        pair.Temp /= enumerator.Current;
                        pair.Count++;
                    }
                }
                enumerator.MoveNext();
            }
            return pairs;
        }

        private static IEnumerable<int> GetPrimes()
        {
            yield return 2;
            yield return 3;
            List<int> primes = new List<int>() { 2, 3 };
            int value = 4;
            while (true)
            {
                if(primes.All(x=>value % x != 0))
                {
                    primes.Add(value);
                    yield return value;
                }
                value++;
            }
        }

        public static int Puzzle(int s)
        {
            return 0;
        }
    }
    public class Pair
    {
        public long Value { get; set; }

        public int Count { get; set; }

        public long Temp { get; set; }
    }
}
