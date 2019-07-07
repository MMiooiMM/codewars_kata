using System.Collections.Generic;
using System.Linq;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/55c4eb777e07c13528000021
    public class Factorial_tail
    {
        public static int zeroes(int b, int number)
        {
            var pk = Primes(b);
            var p = pk.Distinct();
            List<int> result = new List<int>();

            foreach (var item in p)
            {
                int z = 0, i = item;
                while (number / i >= 1)
                {
                    z += number / i;
                    i *= item;
                }
                result.Add(z / pk.Count(x => x == item));
            }
            return result.Min();
        }

        public static List<int> Primes(int number)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    primes.Add(i);
                    number = number / i;
                }
            }
            return primes;
        }
    }
}