using System.Collections.Generic;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/550554fd08b86f84fe000a58
    public class Which_are_in
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> result = new List<string>();
            foreach (var str in array1)
            {
                foreach (var str2 in array2)
                {
                    if (str2.Contains(str))
                    {
                        result.Add(str);
                        break;
                    }
                }
            }
            result.Sort();
            return result.ToArray();
        }
    }
}