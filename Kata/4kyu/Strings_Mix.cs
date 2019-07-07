using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/5629db57620258aa9d000014
    public class Strings_Mix
    {
        public static string Mix(string s1, string s2)
        {
            string s1str = "", s2str = "";
            string pattern = @"[a-z]";
            foreach (Match match in Regex.Matches(s1, pattern))
            {
                s1str += match.ToString();
            }
            foreach (Match match in Regex.Matches(s2, pattern))
            {
                s2str += match.ToString();
            }
            var s1Group = s1str.GroupBy(x => x).Where(x => x.Count() > 1).OrderBy(x => x.Key);
            var s2Group = s2str.GroupBy(x => x).Where(x => x.Count() > 1).OrderBy(x => x.Key);

            List<string> res = new List<string>();
            List<char> allkey = s1Group.Select(x => x.Key).ToList();
            allkey.AddRange(s2Group.Select(x => x.Key).ToList());
            allkey = allkey.Distinct().ToList();
            foreach (var key in allkey)
            {
                string result = "";
                int s1count = s1.Where(x => x == key).Count();
                int s2count = s2.Where(x => x == key).Count();
                if (s1count > s2count)
                {
                    result = "1:";
                    for (int i = 0; i < s1count; i++)
                        result += key;
                    res.Add(result);
                }
                else if (s1count < s2count)
                {
                    result = "2:";
                    for (int i = 0; i < s2count; i++)
                        result += key;
                    res.Add(result);
                }
                else if (s1count == s2count)
                {
                    result = "=:";
                    for (int i = 0; i < s2count; i++)
                        result += key;
                    res.Add(result);
                }
            }
            if (res.Count == 0)
                return string.Empty;
            return res.OrderByDescending(x => x.Count()).ThenBy(x => x[0]).ThenBy(x => x[2]).Aggregate((x, y) => x + "/" + y);
        }
    }
}