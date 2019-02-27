using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/59325dc15dbb44b2440000af
    public static class Are_we_alternate
    {
        public static bool IsAlt(string word)
        {
            string vowels = "aeiou";
            int a = 0, b = 0;
            for (int i = 0; i < word.Length; i++)
            {
                a = (vowels.Contains(word[i])) ? 1 : 2;
                if (a == b && i != 0)
                    return false;
                b = a;
            }
            return true;
        }
    }
}
