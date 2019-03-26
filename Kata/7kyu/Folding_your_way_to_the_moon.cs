using System;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/58f0ba42e89aa6158400000e
    public class Folding_your_way_to_the_moon
    {
        public static int? FoldTo(double distance)
        {
            if (distance <= 0) return null;
            if (distance < 0.0001) return 0;
            int count = 0;
            while (true)
            {
                if (distance < Math.Pow(2, ++count) * 0.0001) break;
            }
            return count;
        }
    }
}
