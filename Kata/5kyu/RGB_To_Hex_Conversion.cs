using System;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/513e08acc600c94f01000001
    public class RGB_To_Hex_Conversion
    {
        public static string Rgb(int r, int g, int b)
        {
            return ConvertHex(r) + ConvertHex(g) + ConvertHex(b);
        }
        public static string ConvertHex(int value) => Convert.ToString((value < 0 ? 0 : value > 255 ? 255 : value), 16).ToUpper().PadLeft(2, '0');
    }
}
