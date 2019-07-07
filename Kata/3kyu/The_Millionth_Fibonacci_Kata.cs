using System.Numerics;

namespace Kata._3kyu
{
    //https://www.codewars.com/kata/53d40c1e2f13e331fc000c26
    public class The_Millionth_Fibonacci_Kata
    {
        public static BigInteger fib(int n)
        {
            if (n < -1000000)
            {
                return new BigInteger(n);
            }
            if (n > 100000)
            {
                BigInteger[] bigAry = new BigInteger[] { 1, 1, 1, 0 };
                BigInteger[] sampleAry = new BigInteger[] { 1, 1, 1, 0 };

                while (n > 0)
                {
                    if (n % 2 == 0)
                    {
                        sampleAry = aryMulti(sampleAry, sampleAry);
                        n /= 2;
                    }
                    else
                    {
                        bigAry = aryMulti(bigAry, sampleAry);
                        sampleAry = aryMulti(sampleAry, sampleAry);
                        --n;
                        n /= 2;
                        if (n == 0) break;
                    }
                    bigAry = aryMulti(bigAry, sampleAry);
                    --n;
                }

                return bigAry[3];
            }
            BigInteger left = 0;
            BigInteger right = 1;

            while (n > 0)
            {
                right = left + right;
                left = right - left;
                --n;
            }

            while (n < 0)
            {
                right = left - right;
                left = left - right;
                ++n;
            }
            return left;

            BigInteger[] aryMulti(BigInteger[] Ary1, BigInteger[] Ary2)
            {
                return new BigInteger[]{
                    Ary1[0] * Ary2[0] + Ary1[1] * Ary2[2],
                    Ary1[0] * Ary2[1] + Ary1[1] * Ary2[3],
                    Ary1[2] * Ary2[0] + Ary1[3] * Ary2[2],
                    Ary1[2] * Ary2[1] + Ary1[3] * Ary2[3]
                };
            }
        }
    }
}