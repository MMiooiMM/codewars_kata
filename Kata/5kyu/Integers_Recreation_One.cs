using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/55aa075506463dac6600010d
    public class Integers_Recreation_One
    {
        public static string listSquared(long m, long n)
        {
            Dictionary<long, long> result = new Dictionary<long, long>();
            for (long i = m; i <= n; i++)
            {
                long sum = 0;
                for (long j = 1; j <= i; j++)
                    sum += (i % j == 0) ? (long)Math.Pow(j, 2) : 0;
                if (Math.Sqrt(sum) % 1 == 0)
                    result.Add(i, sum);
            }
            if (result.Count == 0)
                return "[]";
            return "[" + result.Select(x => "[" + x.Key + ", " + x.Value + "]").Aggregate((x, y) => x + ", " + y) + "]";
        }
    }
}