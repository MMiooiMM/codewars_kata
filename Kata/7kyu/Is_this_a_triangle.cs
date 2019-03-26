using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/56606694ec01347ce800001b
    public class Is_this_a_triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            int[] intArray = new int[] { a, b, c };
            if ((intArray.Sum() - (intArray.Max() * 2)) > 0)
                return true;
            return false;
        }
    }
}
