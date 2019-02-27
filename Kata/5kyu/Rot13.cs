using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/530e15517bc88ac656000716
    class Rot13
    {
        public static string _Rot13(string message) => string.Join("",
            message.Select(x => (x < 65 || x > 122) || (x.ToString().ToUpper() == x.ToString().ToLower()) ? x
            : (x >= 97) ?
            ((x + 13 > 122) ? (char)(x - 13) : (char)(x + 13))
            : (((x + 13) > 90) ? (char)(x - 13) : (char)(x + 13))
            )
            .ToArray());
    }
}
