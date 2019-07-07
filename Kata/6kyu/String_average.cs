using System.Collections.Generic;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5966847f4025872c7d00015b
    public class String_average
    {
        public static string AverageString(string str)
        {
            Dictionary<int, string> s = new Dictionary<int, string>
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" }
            };
            var numbers = str.Split();
            int sum = 0;
            foreach (string number in numbers)
            {
                if (s.Where(x => x.Value == number).Count() == 0)
                    return "n/a";
                sum += s.Where(x => x.Value == number).Single().Key;
            }
            if (s.Where(x => x.Key == sum / numbers.Count()).Count() == 0)
                return "n/a";
            return s.Where(x => x.Key == sum / numbers.Count()).Single().Value;
        }
    }
}