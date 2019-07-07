using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5679aa472b8f57fb8c000047
    public class Equal_Sides_Of_An_Array
    {
        public static int FindEvenIndex(int[] arr)
        {
            int index = -1;
            for (int i = 0; i < arr.Count(); i++)
            {
                int a = 0;
                int b = 0;
                for (int j = 0; j < arr.Count(); j++)
                {
                    if (j < i)
                        a += arr[j];
                    else if (j > i)
                        b += arr[j];
                }
                if (a == b)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}