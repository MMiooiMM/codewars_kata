using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Other
{
    public static class LinqExtension
    {
        /// <summary>
        /// 傳回自身與排序在後的所有元素組合直到 k = 0 時傳回空二維數列，使用於 Best_travel。
        /// http://stackoverflow.com/questions/127704/algorithm-to-return-all-combinations-of-k-elements-from-n
        /// </summary>
        /// <param name="ls">陣列</param>
        /// <param name="k">取出數目</param>
        /// <returns>陣列內容的排列組合</returns>
        public static IEnumerable<IEnumerable<int>> Combinations(this IEnumerable<int> ls, int k) =>
          k == 0 ? new[] { new int[0] } :
            ls.SelectMany((e, i) =>
              ls.Skip(i + 1)
                .Combinations(k - 1)
                .Select(c => (new[] { e }).Concat(c)));
    }
}
