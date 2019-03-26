using System.Collections.Generic;
using System.Linq;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/557f6437bf8dcdd135000010
    public class Large_Factorials
    {
        public static string Factorial(int n)
        {
            if (n < 0)
                return string.Empty;
            if (n <= 1)
                return "1";
            char[] prevAns = Factorial(n - 1).ToCharArray();
            List<int> digits = new List<int>(prevAns.Select(x => n * (x - '0')));
            for (int i = digits.Count - 1; i > 0; i--)
            {
                digits[i - 1] += digits[i] / 10;
                digits[i] %= 10;
            }
            return string.Join("", digits);
        }
    }
}
