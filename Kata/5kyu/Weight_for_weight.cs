using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/55c6126177c9441a570000cc
    public class Weight_for_weight
    {
        public static string orderWeight(string strng)
        {
            return string.Join(" ", strng.Split(' ')
                .OrderBy(x => x.Select(y => int.Parse(y.ToString())).Sum())
                .ThenBy(x => x));
        }
    }
}
