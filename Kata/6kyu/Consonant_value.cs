using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/59c633e7dcc4053512000073
    public class Consonant_value
    {
        public static int Solve(string s)
        {
            return s.Split(new char[] { 'a', 'e', 'i', 'o', 'u' }).Select(g => g.Select(item => item - 96).Sum()).Max();
        }
    }
}
