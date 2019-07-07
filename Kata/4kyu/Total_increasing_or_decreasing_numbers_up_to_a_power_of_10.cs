using System.Numerics;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/55b195a69a6cc409ba000053
    public class Total_increasing_or_decreasing_numbers_up_to_a_power_of_10
    {
        public static BigInteger TotalIncDec(int x)
        {
            if (x == 0) return 1;
            BigInteger[] bigs = new BigInteger[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            BigInteger Zero = 0;
            for (int i = 1; i < x; i++)
            {
                bigs = Next(bigs);
                Zero += bigs[0];
            }
            BigInteger result = 0;
            for (int i = 0; i < 10; i++)
            {
                result += bigs[i];
            }
            return result * 2 - 10 + Zero - (x - 1) * 10;
        }

        public static BigInteger[] Next(BigInteger[] current)
        {
            BigInteger[] result = new BigInteger[10];
            for (int i = 0; i < 10; i++)
            {
                result[i] = 0;
                for (int j = i; j < 10; j++)
                {
                    result[i] += current[j];
                }
            }
            return result;
        }
    }
}