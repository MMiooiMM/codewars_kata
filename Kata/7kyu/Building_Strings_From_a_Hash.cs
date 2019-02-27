using System.Collections.Generic;
using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/51c7d8268a35b6b8b40002f2
    public static class Building_Strings_From_a_Hash
    {
        public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
        {
            return string.Join(",", hash.Select(x => x.Key + " = " + x.Value));
        }
    }
}
