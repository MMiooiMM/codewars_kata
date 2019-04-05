using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata._4kyu {
    public class Getting_along_with_Integer_Partitions {
        public static string Part (long n) {
            var value = Prod(n);
            var median = (value[(int)Math.Ceiling(value.Count / 2.0) - 1] + value[(int)Math.Floor(value.Count / 2.0 + 1) - 1]) / 2.0;
            return $"Range: {value[value.Count - 1] - value[0]} Average: {Math.Round(value.Sum() * 1.0 / value.Count, 2) : 0.00} Median: {median}";
        }

        private static List<long> Prod(long n)
        {
            var result = new List<List<long>> { new List<long> { 1 } };
            foreach(var i in Enumerable.Range(1 , (int)n))
            {
                var tmp = new List<long>();
                foreach (var num in result.Select((x, index) => new { x, index }))
                {
                    foreach (var value in num.x)
                    {
                        tmp.Add((i - num.index) * value);
                    }
                }
                result.Add(tmp.OrderBy(x => x).Distinct().ToList());
            }
            return result.Last();
        }
    }
}