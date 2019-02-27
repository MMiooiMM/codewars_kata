using System;
using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/578aa45ee9fd15ff4600090d
    public static class Sort_the_odd
    {
        public static int[] SortArray(int[] array)
        {
            if (array.Count() == 0)
                return array;
            var odd = array.Where(x => x % 2 == 1).ToArray();
            Array.Sort(odd);
            int count = 0;
            return array.Select(x => (x % 2 == 1) ? odd[count++] : x).ToArray();
        }
    }
}
