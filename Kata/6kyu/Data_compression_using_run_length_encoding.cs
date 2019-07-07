using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/578bf2d8daa01a4ee8000046
    public class Data_compression_using_run_length_encoding
    {
        public static string Encode(string input)
        {
            var result = string.Empty;
            var tmp = new List<char>();
            foreach (var c in input)
            {
                if (!tmp.Contains(c) && tmp.Count > 0)
                {
                    result += $"{tmp.Count}{tmp[0]}";
                    tmp.Clear();
                }
                tmp.Add(c);
            }
            result += $"{tmp.Count}{tmp[0]}";
            return result;
        }

        public static string Decode(string input)
        {
            var result = string.Empty;

            foreach (var match in Regex.Matches(input, @"\d+[a-z,A-Z]+"))
            {
                var count = int.Parse(Regex.Match(match.ToString(), @"\d+").Value);
                var value = Regex.Match(match.ToString(), @"[a-z,A-Z]+").Value.ToString();

                while (count-- > 0)
                    result += value;
            }
            return result;
        }
    }

    public class Data_compression_using_run_length_encoding_Clever
    {
        public string Encode(string input)
            => new Regex(@"(\w)\1*").Replace(input, 
                e => $"{e.Length}{e.Value[0]}");

        public string Decode(string input)
            => new Regex(@"(\d)+\w").Replace(input, 
                e => $"{new string(e.Value[e.Value.Length - 1], int.Parse("" + e.Value.Substring(0, e.Value.Length - 1)))}");
    }
}