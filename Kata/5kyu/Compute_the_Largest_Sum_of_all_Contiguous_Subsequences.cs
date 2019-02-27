using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/56001790ac99763af400008c
    public static class Compute_the_Largest_Sum_of_all_Contiguous_Subsequences
    {
        public static int LargestSum(int[] arr)
        {
            List<int> l = new List<int>();
            int s = 0;
            foreach (int a in arr)
            {
                s += a;
                if (s < 0) s = 0;
                l.Add(s);
            }
            if (l.Count() == 0 || l.Max() <= 0) return 0;
            return l.Max();
        }
    }
}
