using System;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5592e3bd57b64d00f3000047
    public class Build_a_pile_of_Cubes
    {
        public static long findNb(long m)
        {
            long count = 0;
            long sum = 0;
            while (sum < m)
            {
                sum += (long)Math.Pow(count++, 3);
                if (sum == m)
                    return --count;
            }
            return -1;
        }
    }
}