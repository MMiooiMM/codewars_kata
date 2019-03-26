using System.Collections.Generic;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/57b6f5aadb5b3d0ae3000611
    public class Length_of_missing_array
    {
        public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
        {
            if (arrayOfArrays == null || arrayOfArrays.Length == 0 || arrayOfArrays.Where(x => x == null).Count() > 0)
                return 0;
            List<int> res = arrayOfArrays.Select(x => x.Count()).OrderBy(x => x).ToList();
            if (res.Count() <= 1)
                return 0;
            int miss = ((res.Max() + res.Min()) * (res.Max() - res.Min() + 1) / 2) - res.Sum();
            if (miss < res.Min() || miss > res.Max())
                return 0;
            if (res.Where(x => x == miss).Count() > 0 || res.Where(x => x == 0).Count() > 0)
                return 0;
            return miss;
        }
    }
}
