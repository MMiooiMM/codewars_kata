using System;
using System.Collections.Generic;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/59e4b634f703c4c95c000097
    //https://ithelp.ithome.com.tw/questions/10192780
    public static class Creating_a_new_LINQ_operator_SelectConsecutive
    {
        public static IEnumerable<TResult> SelectConsecutive<TSource, TResult>(
             this IEnumerable<TSource> source, Func<TSource, TSource, TResult> selector)
        {
            if (source == null || selector == null)
                throw new ArgumentNullException();
            return SelectConsecutiveIterator(source, selector);
        }

        private static IEnumerable<TResult> SelectConsecutiveIterator<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TSource, TResult> selector)
        {
            using (var iterator = source.GetEnumerator())
            {
                iterator.MoveNext();
                //第一個item
                var prev = iterator.Current;
                while (iterator.MoveNext())
                {
                    var current = iterator.Current;
                    yield return selector(prev, current);
                    prev = current;
                }
            }
        }
    }
}
