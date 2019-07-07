using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/55e86e212fce2aae75000060
    public class Integers_Recreation_Two
    {
        public static List<long[]> Prod2Sum(long a, long b, long c, long d)
        {
            var n = (Math.Pow(a, 2) + Math.Pow(b, 2)) * (Math.Pow(c, 2) + Math.Pow(d, 2));
            var values = Enumerable.Range(0, (int)Math.Sqrt(n) + 1).Select(x => Math.Sqrt(n - Math.Pow(x, 2))).Where(x => x == (int)x).ToList();
            var count = values.Count;
            if (count == 0)
            {
                return null;
            }
            return Enumerable.Range(0, (int)Math.Ceiling(count / 2.0)).Select(x => new long[] { (long)values[count - x - 1], (long)values[x] }).ToList();
        }

        public static bool AreEqual(List<long[]> ll1, List<long[]> ll2)
        {
            return ll1.Select((x, index) => new { x, index }).All(x => x.x[0] == ll2[x.index][0] && x.x[1] == ll2[x.index][1]);
        }
    }
}