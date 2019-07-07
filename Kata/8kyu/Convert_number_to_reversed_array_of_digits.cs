using System.Linq;

namespace Kata._8kyu
{
    //https://www.codewars.com/kata/5583090cbe83f4fd8c000051
    public class Convert_number_to_reversed_array_of_digits
    {
        public static long[] Digitize(long n) => n.ToString()
            .Select(x => long.Parse(x.ToString()))
            .Reverse()
            .ToArray();
    }
}