using System;
using System.Collections;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/pi-approximation
    public class PI_approximation
    {
        public static ArrayList iterPi(double epsilon)
        {
            double pi = 0;
            double count = 1;
            while ((Math.Abs(Math.PI - pi * 4) > epsilon))
            {
                pi += ((count % 2 == 0) ? -1 : 1) * (1d / (count * 2 - 1));
                count++;
            }
            return new ArrayList { count - 1, Math.Round(pi * 4, 10) };
        }
    }
}
