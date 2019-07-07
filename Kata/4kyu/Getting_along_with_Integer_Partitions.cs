using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/getting-along-with-integer-partitions/
    public class Getting_along_with_Integer_Partitions
    {
        public static string Part(long n)
        {
            var value = Prod(n);
            var median = (value[(int)Math.Ceiling(value.Count / 2.0) - 1] + value[(int)Math.Floor(value.Count / 2.0 + 1) - 1]) / 2.0;
            return $"Range: {value[value.Count - 1] - value[0]} Average: {Math.Round(value.Sum() * 1.0 / value.Count, 2): 0.00} Median: {median}";
        }

        private static List<long> Prod(long n)
        {
            var result = new List<List<long>> { new List<long> { 1 } };
            foreach (var i in Enumerable.Range(1, (int)n))
            {
                var tmp = result
                    .Select((x, index) => x.Select(o => (i - index) * o))
                    .SelectMany(x => x)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();
                result.Add(tmp);
            }
            return result.Last();
        }
    }
}