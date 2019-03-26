using System.Collections.Generic;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/51b6249c4612257ac0000005
    public class Roman_Numerals_Decoder
    {
        public static int Solution(string roman)
        {
            Dictionary<char, int> chlist = new Dictionary<char, int>() {
                { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
            };
            char current = ' ';
            int result = 0, tmp = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (current == ' ')
                {
                    tmp += chlist.Where(x => x.Key == roman[i]).Single().Value;
                }
                else
                {
                    if (chlist.Keys.ToList().IndexOf(current) < chlist.Keys.ToList().IndexOf(roman[i]))
                    {
                        tmp = chlist.Where(x => x.Key == roman[i]).Single().Value - tmp;
                    }
                    else if (chlist.Keys.ToList().IndexOf(current) > chlist.Keys.ToList().IndexOf(roman[i]))
                    {
                        result += tmp;
                        tmp = chlist.Where(x => x.Key == roman[i]).Single().Value;
                    }
                    else
                    {
                        tmp += chlist.Where(x => x.Key == roman[i]).Single().Value;
                    }
                }
                current = roman[i];
            }
            return result + tmp;
        }
    }
}
