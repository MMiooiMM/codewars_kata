using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5ce399e0047a45001c853c2b
    public class Sums_of_Parts
    {
        public static int[] PartsSums(int[] ls)
        {
            var total = ls.Sum();
            var result = new int[ls.Length + 1];
            result[0] = total;
            for(int i = 0; i < ls.Length; i++)
            {
                total = total - ls[i];
                result[i + 1] = total;
            }
            return result;
        }
    }
}
