using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/54b81566cd7f51408300022d
    public class Partial_Word_Searching
    {
        public static string[] WordSearch(string query, string[] seq)
        {
            var result = seq.Where(x => x.ToLower().Contains(query.ToLower())).ToArray();
            if (seq.Length == 0 || string.IsNullOrEmpty(query) || result.Length == 0)
                return new string[] { "Empty" };
            return result;
        }
    }
}