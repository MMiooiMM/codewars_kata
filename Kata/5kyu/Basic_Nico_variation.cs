using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/5968bb83c307f0bb86000015
    public static class Basic_Nico_variation
    {
        public static string Nico(string key, string message)
        {
            var count = (int)Math.Ceiling(message.Length / (key.Length * 1.0));
            char[,] c = new char[count, key.Length];
            var l = 0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    c[i, j] = message[l];
                    l++;
                    if (l >= message.Length) break;
                }
            }
            string result = "";
            List<int> ls = new List<int>();
            ls.AddRange(key.OrderBy(x => x).Select(o => key.IndexOf(o)));
            for (int i = 0; i < count; i++)
            {
                foreach (var v in ls)
                {
                    result += c[i, v];
                }
            }
            return result.Replace("\0", " ");
        }
    }
}
