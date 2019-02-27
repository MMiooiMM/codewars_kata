using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/517abf86da9663f1d2000003
    public static class Convert_string_to_camel_case
    {
        public static string ToCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            var result = str.Split('_', '-')
                .Select(x => char.ToUpper(x[0]) + ((x.Length == 1) ? "" : x.Substring(1, x.Length - 1))).Aggregate((x, y) => x + y);
            result = str[0] + result.Substring(1, result.Length - 1);
            return result;
        }
    }
}
