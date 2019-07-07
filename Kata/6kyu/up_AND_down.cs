using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/56cac350145912e68b0006f0
    public class up_AND_down
    {
        public static string Arrange(string strng)
        {
            var ls = strng.Split(' ');
            for (int i = 0; i < ls.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (ls[i].Length > ls[i + 1].Length)
                    {
                        var tmp = ls[i];
                        ls[i] = ls[i + 1];
                        ls[i + 1] = tmp;
                    }
                    ls[i] = ls[i].ToLower();
                }
                else
                {
                    if (ls[i].Length < ls[i + 1].Length)
                    {
                        var tmp = ls[i];
                        ls[i] = ls[i + 1];
                        ls[i + 1] = tmp;
                    }
                    ls[i] = ls[i].ToUpper();
                }
            }
            ls[ls.Length - 1] = ((ls.Length - 1) % 2 == 0) ? ls[ls.Length - 1] = ls[ls.Length - 1].ToLower() : ls[ls.Length - 1] = ls[ls.Length - 1].ToUpper();
            return string.Join(" ", ls);
        }

        public static string Arrange_Linq(string strng)
        {
            var ls = strng.Split(' ');
            for (int i = 0; i < ls.Length - 1; i++)
            {
                if (i % 2 == 0 ? (ls[i].Length > ls[i + 1].Length) : (ls[i].Length < ls[i + 1].Length))
                {
                    Swap(i);
                }
            }
            return string.Join(" ", ls.Select((x, index) =>
            {
                if (index % 2 == 0)
                    return x.ToLower();
                else
                    return x.ToUpper();
            }));

            void Swap(int index)
            {
                string buffer = ls[index];
                ls[index] = ls[index + 1];
                ls[index + 1] = buffer;
            }
        }
    }
}