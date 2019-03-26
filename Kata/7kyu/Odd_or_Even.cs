using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/5949481f86420f59480000e7
    public class Odd_or_Even
    {
        public static string OddOrEven(int[] array)
        {
            return (array.Sum() % 2 == 0) ? "even" : "odd";
        }
    }
}
