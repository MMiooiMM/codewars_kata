using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/matching-and-substituting
    public class Matching_And_Substituting
    {
        public static string Change(string s, string prog, string version)
        {
            var res = string.Empty;
            var err = "ERROR: VERSION or PHONE";
            var phone = string.Empty;
            foreach (var line in s.Split('\n'))
            {
                var lines = line.Split(':').Select(x => x.Trim()).ToList();
                if (line.Contains("Phone"))
                {
                    if (lines[1].IndexOf("+1") != 0)
                        return err;
                    var numbers = lines[1].Substring(2).Split('-');
                    if (numbers.Count() != 4
                       || numbers[1].Length != 3 || numbers[2].Length != 3 || numbers[3].Length != 4
                       || !int.TryParse(numbers[1], out int n1) || !int.TryParse(numbers[2], out int n2) || !int.TryParse(numbers[3], out int n3))
                        return err;
                    phone = lines[1];
                }
                if (line.Contains("Version"))
                {
                    if (lines[1].Split('.').Count() != 2 || lines[1].IndexOf(".") == 0 || lines[1].IndexOf("-") != -1)
                        return err;
                    if (lines[1] == "2.0")
                        version = "2.0";
                }
            }
            return $"Program: {prog} Author: g964 Phone: +1-503-555-0090 Date: 2019-01-01 Version: {version}";
        }
    }
}
