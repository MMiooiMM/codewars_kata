using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Other
{
    public static class LinqExtension
    {
        // Inspired by http://stackoverflow.com/questions/127704/algorithm-to-return-all-combinations-of-k-elements-from-n
        public static IEnumerable<IEnumerable<int>> Combinations(this IEnumerable<int> ls, int k) =>
          k == 0 ? new[] { new int[0] } :
            ls.SelectMany((e, i) =>
              ls.Skip(i + 1)
                .Combinations(k - 1)
                .Select(c => (new[] { e }).Concat(c)));
    }
}
