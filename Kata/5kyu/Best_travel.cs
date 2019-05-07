using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa
    public class Best_travel
    {
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            if (ls.Count < k)
            {
                return null;
            }
            try
            {
                var count = ls.Count;
                var i = 0;
                var results = Enumerable.Range(0, count).Select(x => new List<int> { x }).ToList();
                while (i + 1 < k)
                {
                    var clonelist = results.Select(x => x).ToList();
                    foreach (var clone in clonelist)
                    {
                        foreach (var item in Enumerable.Range(0, count).Where(x => !clone.Contains(x)))
                        {
                            var items = clone.Select(x => x).ToList();
                            items.Add(item);
                            results.Add(items);
                        }
                    }
                    results = results.Where(x => x.Count == i + 2 && x[i] < x[i + 1]).ToList();
                    i++;
                }
                return results?.Select(x => x.Select(y => ls[y]).Sum()).Where(x => x <= t)?.Max();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

    public static class Best_travel_Best_Practices
    {
        public static int? chooseBestSum(int t, int k, List<int> ls) =>
          ls.Combinations(k)
            .Select(c => (int?)c.Sum())
            .Where(sum => sum <= t)
            .DefaultIfEmpty()
            .Max();

        // Inspired by http://stackoverflow.com/questions/127704/algorithm-to-return-all-combinations-of-k-elements-from-n
        public static IEnumerable<IEnumerable<int>> Combinations(this IEnumerable<int> ls, int k) =>
          k == 0 ? new[] { new int[0] } :
            ls.SelectMany((e, i) =>
              ls.Skip(i + 1)
                .Combinations(k - 1)
                .Select(c => (new[] { e }).Concat(c)));
        // 傳回自身與排序在後的所有元素組合直到 k = 0 時傳回空二維數列
    }

    public class Best_travel_Clever
    {
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            var _ls = ls.Where(x => x <= t);
            return _ls.Count() == 0 ? null : _ls.Select((x, i) => x + (k > 1 ? chooseBestSum(t - x, k - 1, _ls.Skip(i + 1).ToList()) : 0)).Max();
        }
    }
}
