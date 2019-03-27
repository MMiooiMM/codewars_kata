using System;
using System.Linq;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/next-smaller-number-with-the-same-digits
    //https://www.codewars.com/kata/next-bigger-number-with-the-same-digits
    public class Next_smaller_number_with_the_same_digits_Clever
    {
        public static long NextSmaller(long n)
        {
            if (n > 0 & (n + "").Length == 1) return -1;
            string s = n + "";
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (s.Substring(i) != string.Concat(s.Substring(i).OrderBy(x => x)))
                {
                    var t = string.Concat(s.Substring(i).OrderByDescending(x => x));
                    var c = t.First(x => x < s[i]);
                    return i == 0 & c == '0' ? -1 : long.Parse(s.Substring(0, i) + c + string.Concat(t.Where((x, y) => y != t.IndexOf(c))));
                }
            }
            return -1;
        }
    }

    public class Next_bigger_number_with_the_same_digits
    {
        public static long NextSmaller(long n)
        {
            if (n > 0 & (n + "").Length == 1) return -1;
            string s = n + "";
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (s.Substring(i) != string.Concat(s.Substring(i).OrderByDescending(x => x)))
                {
                    var t = string.Concat(s.Substring(i).OrderBy(x => x));
                    var c = t.First(x => x > s[i]);
                    return i == 0 & c == '0' ? -1 : long.Parse(s.Substring(0, i) + c + string.Concat(t.Where((x, y) => y != t.IndexOf(c))));
                }
            }
            return -1;
        }
    }

    public class Next_smaller_number_with_the_same_digits_Best_Practices
    {
        public static long NextSmaller(long n)
        {
            int[] a = new int[n.ToString().Length];
            int j = 0;
            // Loading digits into array so easier to work with
            while (n > 0)
            {
                a[j++] = (int)(n % 10);
                n /= 10;
            }

            // Strategy = go from right to left and find the first digit with a number greater to the left
            // eg 285123 - find the '1' because there's a greater number beside
            // Find the biggest number to the right, and switch the two
            // eg 285123 - switch the 5 and the 3 = 283125
            // Then, sort everything to the right of the index in descending order
            // eg 283125 -> 283521

            // find int to move
            int index = 0;
            int highest = 0;
            for (index = 1; index < a.Length; index++)
            {
                if (a[index] > a[index - 1]) break;
            }
            // find biggest digit to the right of it
            if (index >= a.Length) return -1;
            highest = index - 1;
            for (int k = 0; k < index; k++)
            {
                if (a[k] > a[highest] && a[index] > a[k]) highest = k;
            }

            // switch index with highest
            int temp = a[index];
            a[index] = a[highest];
            a[highest] = temp;

            // take array of everything to the right of the index
            int[] b = new int[index];
            for (int i = 0; i < index; i++)
            {
                b[i] = a[i];
            }
            // sort it and copy back
            Array.Sort(b);
            for (int i = 0; i < index; i++)
            {
                a[i] = b[i];
            }

            long output = 0;
            long pos = 1;
            // convert array back into long
            for (int i = 0; i < a.Length; i++)
            {
                output += pos * a[i];
                pos *= 10;
            }
            // if we needed to move a zero to the very left, then the long will be shorter, return -1
            if (output.ToString().Length < a.Length) return -1;

            return output;

        }
    }
}
