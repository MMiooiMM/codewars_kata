using System.Collections.Generic;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/56b5afb4ed1f6d5fb0000991
    internal class Reverse_or_rotate
    {
        public static string RevRot(string strng, int sz)
        {
            if (sz <= 0 || string.IsNullOrEmpty(strng))
                return "";
            var result = string.Empty;
            foreach (var s in Split(strng, sz))
            {
                if (s.Select(x => int.Parse(x.ToString())).Sum() % 2 == 0)
                    result += string.Join("", s.Reverse());
                else
                    result += s.Substring(1, sz - 1) + s.Substring(0, 1);
            }
            return result;
        }

        private static IEnumerable<string> Split(string str, int sz)
        {
            var index = 0;
            var Max = str.Length - sz;
            while (index <= Max)
            {
                yield return str.Substring(index, sz);
                index += sz;
            }
            yield break;
        }
    }
}