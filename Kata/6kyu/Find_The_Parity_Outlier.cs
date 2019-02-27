using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5526fc09a1bbd946250002dc
    public static class Find_The_Parity_Outlier
    {
        public static int Find(int[] integers)
        {
            if (integers.Where(x => x % 2 == 0).Count() == 1)            
                return integers.Where(x => x % 2 == 0).Single();            
            else            
                return integers.Where(x => x % 2 == 1).Single();            
        }
    }
}
