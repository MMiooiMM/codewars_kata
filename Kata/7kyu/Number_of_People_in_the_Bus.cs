using System.Collections.Generic;
using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/5648b12ce68d9daa6b000099
    public class Number_of_People_in_the_Bus
    {
        public static int Number(List<int[]> peopleListInOut) => peopleListInOut.Sum(x => x[0] - x[1]);
    }
}
