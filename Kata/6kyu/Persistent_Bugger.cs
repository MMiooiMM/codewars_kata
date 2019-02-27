using System;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec
    public static class Persistent_Bugger
    {
        public static int Persistence(long n)
        {
            // your code
            int result = 0;
            while (n >= 10)
            {
                int tmp = 1;
                int length = (int)(Math.Log10(n));
                for (int i = 0; i <= length; i++)                
                    tmp *= Int32.Parse(n.ToString()[i].ToString());                
                n = tmp;
                result++;
            }
            return result;
        }
    }
}
