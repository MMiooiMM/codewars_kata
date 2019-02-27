using System.Collections.Generic;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5898b4b71d298e51b600014b
    public static class Srot_the_inner_ctonnet_in_dsnnieedcg_oredr
    {
        public static string SortTheInnerContent(string words)
        {
            var w = words.Split();
            List<string> ls = new List<string>();
            foreach (string ww in w)
            {
                List<int> a = new List<int>();
                if (ww.Length > 3)
                {
                    string t = ww.Substring(1, ww.Length - 2);
                    a.AddRange(t.Select(x => (int)x));
                    a.Sort();
                    a.Reverse();
                    string b = "";
                    foreach (var aa in a)
                    {
                        b += (char)aa;
                    }
                    ls.Add(ww.Substring(0, 1) + b + ww.Substring(ww.Length - 1, 1));
                }
                else
                {
                    ls.Add(ww);
                }
            }
            return ls.Aggregate((x, y) => x + " " + y);
        }
    }
}
