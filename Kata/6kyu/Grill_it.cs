using System;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/595b3f0ad26b2d817400002a
    public static class Grill_it
    {
        public static string Grille(string message, int code)
        {
            string result = "";
            string bin = Convert.ToString(code, 2).PadLeft(message.Length, '0');
            message = message.PadLeft(bin.Length, ' ');
            for (int i = 0; i < message.Length; i++)
            {
                if (bin[i] == '1')
                    result += message[i];
            }
            return result.Trim();
        }
    }
}
