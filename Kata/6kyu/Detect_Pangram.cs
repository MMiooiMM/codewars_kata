using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/545cedaa9943f7fe7b000048
    public static class Detect_Pangram
    {
        public static bool IsPangram(string str)
        {
            str = str.ToLower();
            string a_z = "abcdefghijklmnopqrstuvwxyz";
            foreach (char c in a_z)
            {
                if (str.Where(x => x == c).Count() == 0)
                    return false;
            }
            return true;
        }
    }
}
