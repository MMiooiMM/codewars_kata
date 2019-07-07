using System;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/56c04261c3fcf33f2d000534
    public class Magnet_particules_in_boxes
    {
        public static double Doubles(int maxk, int maxn)
        {
            double result = 0d;
            for (int i = 1; i <= maxk; i++)
            {
                for (int j = 1; j <= maxn; j++)
                {
                    result += 1 / (i * Math.Pow(j + 1, 2 * i));
                }
            }
            return result;
        }
    }
}