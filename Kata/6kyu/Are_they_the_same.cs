using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/550498447451fbbd7600041c
    public class Are_they_the_same
    {
        public static bool comp(int[] a, int[] b)
        {
            return !(a == null || b == null)
               && a.Count() == b.Count()
               && a.Select(x => x * x).All(x => b.Contains(x))
               && b.All(x => a.Any(y => y * y == x))
               && a.Select(x => x * x).Sum() == b.Sum();
        }
    }
    public class Are_they_the_same_Best_Practices
    {
        public static bool comp(int[] a, int[] b)
        {
            return !(a == null || b == null) 
                && a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        }
    }
}
