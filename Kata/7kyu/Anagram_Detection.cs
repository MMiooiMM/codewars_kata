using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/529eef7a9194e0cbc1000255
    public static class Anagram_Detection
    {
        public static bool IsAnagram(string test, string original)
        {
            string a = "";
            foreach (var aa in test.ToLower().OrderBy(x => x))
            {
                a += aa;
            }
            string e = "";
            foreach (var ee in original.ToLower().OrderBy(x => x))
            {
                e += ee;
            }
            return a == e;
        }
    }
}
