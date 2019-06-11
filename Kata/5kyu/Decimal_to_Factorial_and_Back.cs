using System.Text;

namespace Kata._5kyu
{
    public class Decimal_to_Factorial_and_Back
    {
        //https://www.codewars.com/kata/54e320dcebe1e583250008fd
        public static string dec2FactString(long nb)
        {
            var result = "";
            long max = 1;
            long index = 2;
            while (max * index <= nb)
            {
                max *= index++;
            }
            --index;
            while (index != 0)
            {
                var val = nb / max;
                result += $"{(val >= 10 ? ((char)(val + 55)).ToString() : val.ToString())}";
                nb %= max;
                max /= index--;
            }
            return result += "0";
        }
        public static long factString2Dec(string str)
        {
            long result = 0;
            var count = str.Length - 1;
            long max = 1;
            for(long i = 1; i <= count; i++)
            {
                max *= i;
            }
            foreach (var c in str)
            {
                var val = 0;
                if(c >= 65)
                {
                    val = c - 55;
                }
                else
                {
                    val = c - 48;
                }
                if (count == 0) break;
                result += val * max;
                max /= count--;
            }
            return result;
        }
    }
    public class Decimal_to_Factorial_and_Back_Best_Practices
    {
        private const string _CharList = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string dec2FactString(long n)
        {
            StringBuilder builder = new StringBuilder("0");
            long i = 2L;

            while (n != 0L)
            {
                builder.Insert(0, _CharList[(int)(n % i)]);
                n /= i;
                i++;
            }

            return builder.ToString();
        }

        public static long factString2Dec(string str)
        {
            long result = 0L;

            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    result += (long)_CharList.IndexOf(str[i]);

                    long factorial = str.Length - i - 1;
                    if (factorial > 0L)
                        result *= factorial;
                }
            }

            return result;
        }
    }
    }
