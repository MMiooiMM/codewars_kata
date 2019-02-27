using System;
using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/5259b20d6021e9e14c0010d4
    public static class Reverse_words
    {
        public static string ReverseWords(string str)
        {
            var a = str.Split(' ').ToList();
            string result = "";
            foreach (string s in a)
            {
                var t = s.Reverse();
                foreach (char c in t)
                {
                    result += c;
                }
                result += " ";
            }
            return result.TrimEnd();
        }
    }
}
