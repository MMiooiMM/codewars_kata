using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/54d7660d2daf68c619000d95
    public class Common_Denominators
    {
        public static string convertFrac(long[,] lst)
        {
            var denoms = Enumerable.Range(0, lst.GetLength(0)).Select(x => lst[x, 1]).ToList();
            var factors = new List<long>() { 1 };
            long num = 2;
            while (!denoms.All(x => x == 1))
            {
                while (denoms.Any(x => x % num == 0))
                {
                    factors.Add(num);
                    denoms = denoms.Select(x => x % num == 0 ? x / num : x).ToList();
                }
                num++;
            }
            var LCM = factors.Aggregate((x, y) => x * y);
            return string.Join("", Enumerable.Range(0, lst.GetLength(0)).Select(x => $"({lst[x, 0] * (LCM / lst[x, 1])},{LCM})").ToList());
        }
    }

    public class Common_Denominators_Clever
    {
        // 兩數相乘除以最大公因數就是最小公倍數
        public static string convertFrac(long[,] lst)
        {
            var indices = Enumerable.Range(0, lst.GetLength(0));
            var d = indices.Aggregate(1L, (a, i) => a * lst[i, 1] / gcd(a, lst[i, 1]));
            return string.Concat(indices.Select(i => $"({d * lst[i, 0] / lst[i, 1]},{d})"));
        }

        private static long gcd(long a, long b) => b == 0 ? a : gcd(b, a % b);
    }
}
