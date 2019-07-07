using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5264d2b162488dc400000001
    public class Stop_gninnipS_My_sdroW
    {
        public static string SpinWords(string sentence)
        {
            return string.Join(" ",
                sentence
                .Split(' ')
                .Select((x) =>
                {
                    return x.Length >= 5 ? x.Aggregate("", (y, o) => o + y) : x;
                }));
        }
    }
}