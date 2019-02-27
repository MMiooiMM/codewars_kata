using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5934d648d95386bc8200010b
    public static class Ka_Ka_Ka_cypher_words_only_vol_1
    {
        public static string KaCokadekaMe(string word)
        {
            string vowel = "aeiouAEIOU";
            string result = "ka";
            for (int i = 0; i < word.Length - 1; i++)
            {
                result += word[i];
                bool match = vowel.Contains(word[i]);
                if (match)
                {
                    match = vowel.Contains(word[i + 1]);
                    if (!match)                    
                        result += "ka";                    
                }
            }
            result += word.Substring(word.Length - 1, 1);
            return result;
        }
    }
}
