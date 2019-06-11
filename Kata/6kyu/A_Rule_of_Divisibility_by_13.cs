using System;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/564057bc348c7200bd0000ff
    public class A_Rule_of_Divisibility_by_13
    {
        public static long Thirt(long n)
        {
            var len = n.ToString().Length;
            var div13 = Enumerable.Range(0, len).Select(x => Math.Pow(10, x) % 13).ToList();
            var num = n;
            var prevnum = -1L;
            while (num != prevnum)
            {
                prevnum = num;
                var tmp = num.ToString();
                num = 0;
                for (int i = tmp.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    num += (long)(int.Parse(tmp[i].ToString()) * div13[j]);
                }
            }

            return prevnum;
        }
    }

    public class A_Rule_of_Divisibility_by_13_Best_Practices
    {
        public static long Thirt(long n)
        {
            int[] remainders = { 1, 10, 9, 12, 3, 4 };
            int sum = 0;
            for (int r = 0; n > 0; r++)
            {
                if (r == remainders.Length) r = 0;
                sum += (int)(n % 10 * remainders[r]);
                n /= 10;
            }
            if (sum > 99) return Thirt(sum);
            return sum;
        }
    }

    public class A_Rule_of_Divisibility_by_13_Clever
    {
        public static int[] rl = new int[] { 1, 10, 9, 12, 3, 4 };
        public static long Thirt(long n)
        {
            long rs = n.ToString().Reverse().Select((x, i) => rl[i % 6] * (x - 48)).Sum();
            return rs < 100 ? rs : Thirt(rs);
        }
    }
}