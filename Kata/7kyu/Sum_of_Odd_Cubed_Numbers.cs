using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/580dda86c40fa6c45f00028a
    internal class Sum_of_Odd_Cubed_Numbers
    {
        public static int CubeOdd(int[] arr)
        {
            return arr.Select(x => x * x * x).Where(x => x % 2 != 0).Sum();
        }
    }
}