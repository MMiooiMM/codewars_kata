using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/558fc85d8fd1938afb000014
    public static class Sum_of_two_lowest_positive_integers
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            var a = numbers.Where(x => x > 0).Min();
            var b = numbers.Where(x => x > 0 && x != a).Min();
            return a + b;
        }
    }
}
