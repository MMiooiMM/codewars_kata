using System.Collections.Generic;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/55466989aeecab5aac00003e
    public static class Rectangle_into_Squares
    {
        public static List<int> sqInRect(int lng, int wdth)
        {
            if (lng == wdth || lng * wdth == 0)
                return null;
            List<int> result = new List<int>();
            while (true)
            {
                if (wdth > lng)
                {
                    lng = lng + wdth;
                    wdth = lng - wdth;
                    lng = lng - wdth;
                }
                lng -= wdth;
                if (wdth == 0)
                    break;
                result.Add(wdth);
            }
            return result;
        }
    }
}
