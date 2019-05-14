using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/54d512e62a5e54c96200019e
    public class Primes_in_numbers
    {
        public static String factors(int lst)
        {
            var factors = new List<int>();
            var num = 2;
            while (lst != 1)
            {
                while (lst % num == 0)
                {
                    lst /= num;
                    factors.Add(num);
                }
                num++;
            }
            return string.Join("", factors.GroupBy(prime => prime).Select(x => $"({x.Key}{(x.Count() > 1 ? $"**{x.Count()}" : "")})"));
        }
    }
}
