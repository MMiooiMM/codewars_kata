using System;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/554a44516729e4d80b000012
    public class Buying_a_car
    {
        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingperMonth, double percentLossByMonth)
        {
            if (startPriceOld >= startPriceNew)
            {
                return new int[2] { 0, startPriceOld - startPriceNew };
            }
            int n = 0;
            double result = -1;
            percentLossByMonth *= 0.01;
            double p = 1 - percentLossByMonth;
            while (result <= 0)
            {
                result = (startPriceOld - startPriceNew) * p + savingperMonth * (n + 1);
                n += 1;
                if (n % 2 == 1) percentLossByMonth += 0.005;
                p *= 1 - percentLossByMonth;
            }
            return new int[2] { n, (int)Math.Round(result, 0) };
        }
    }
}
