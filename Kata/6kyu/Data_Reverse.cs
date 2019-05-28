using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/569d488d61b812a0f7000015
    public class Data_Reverse
    {
        public static int[] DataReverse(int[] data)
        {
            return data
                .Select((x, index) => new { x, index })
                .GroupBy(x => x.index / 8)
                .OrderByDescending(x => x.Key)
                .SelectMany(x => x.Select(o => o.x))
                .ToArray();
        }
    }
}
