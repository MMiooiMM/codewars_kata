using System.Collections.Generic;
using System.Linq;

using System;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/54d496788776e49e6b00052f
    public class Sum_by_Factors
    {
        public static string sumOfDivided(int[] lst)
        {
            List<int> plist = new List<int>();
            var tmplst = lst.ToList().Select(x => (x < 0) ? x * -1 : x);
            var max = tmplst.Max();
            for (int j = 2; j <= max; j++)
            {
                if (CheckFactor(tmplst, j) && CheckPrime(plist, j))
                {
                    plist.Add(j);
                }
            }
            return string.Join("", plist.OrderBy(x => x).Select(x => "(" + x + " " + lst.Where(o => CheckFactor(o, x)).Sum() + ")"));
        }
        public static bool CheckPrime(IEnumerable<int> lst, int p)
        {
            return (p == 2) ? true : Enumerable.Range(2, p - 1).Where(x => !CheckFactor(x, lst)).Any(o => o == p);
        }
        public static bool CheckFactor(int i, int f)
        {
            return i % f == 0;
        }
        public static bool CheckFactor(IEnumerable<int> lst, int f)
        {
            return lst.Any(x => x % f == 0);
        }
        public static bool CheckFactor(int f, IEnumerable<int> lst)
        {
            return lst.Any(x => f % x == 0);
        }
    }

    public class Sum_by_Factors_Best_Practices
    {
        public static string sumOfDivided(int[] l)
        {
            string result = "";
            List<int> primes = new List<int>();
            for (int i = 2; i <= l.Max(Math.Abs); i++)
                if (primes.All(e => i % e != 0) && l.Any(e => e % i == 0))
                {
                    primes.Add(i);
                    result += $"({i} {l.Where(e => Math.Abs(e) % i == 0).Sum() })";
                }
            return result;
        }
    }
}
