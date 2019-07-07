using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/54b42f9314d9229fd6000d9c
    public class Duplicate_Encoder
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            var s = word.GroupBy(x => x);
            return word.Select(q => (s.Where(x => x.Key == q).Single().Count() > 1) ? ")" : "(").Aggregate((res, next) => res + next);
        }
    }
}