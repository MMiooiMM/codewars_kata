using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1
    public static class Counting_Duplicates
    {
        public static int DuplicateCount(string str) => str.ToLower().GroupBy(x => x).Where(x => x.Count() >= 2).Count();
    }
}
