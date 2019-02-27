using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/592c1dfb912f22055b000099
    public static class Mr_Safetys_treasures
    {
        public static string Unlock(string str)
        {
            str = str.ToLower();
            str = str.Replace("a", "2").Replace("b", "2").Replace("c", "2");
            str = str.Replace("d", "3").Replace("e", "3").Replace("f", "3");
            str = str.Replace("g", "4").Replace("h", "4").Replace("i", "4");
            str = str.Replace("j", "5").Replace("k", "5").Replace("l", "5");
            str = str.Replace("m", "6").Replace("n", "6").Replace("o", "6");
            str = str.Replace("p", "7").Replace("q", "7").Replace("r", "7").Replace("s", "7");
            str = str.Replace("t", "8").Replace("u", "8").Replace("v", "8");
            str = str.Replace("w", "9").Replace("x", "9").Replace("y", "9").Replace("z", "9");
            return str;
        }

    }

    public static class Clever
    {
        public static string Unlock(string str)
        {
            Dictionary<int, string> letters = new Dictionary<int, string>(){{2,"[abc]"},{3,"[def]"},{4,"[ghi]"},
                        {5,"[jkl]"},{6,"[mno]"},{7,"[pqrs]"},{8,"[tuv]"},{9,"[wxyz]"}};
            string res = str.ToLower();
            foreach (var s in letters)
            {
                Regex rgx = new Regex(s.Value);
                res = rgx.Replace(res, s.Key.ToString());
            }
            return res;
        }
    }
}
