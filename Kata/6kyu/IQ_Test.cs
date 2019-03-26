using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/552c028c030765286c00007d
    public class IQ_Test
    {
        public static int Test(string numbers)
        {
            var s = numbers.Split(' ').ToList();
            if (s.Where(x => int.Parse(x) % 2 == 0).Count() == 1)
                return s.IndexOf(numbers.Split(' ').Where(x => int.Parse(x) % 2 == 0).Single()) + 1;
            else
                return s.IndexOf(numbers.Split(' ').Where(x => int.Parse(x) % 2 == 1).Single()) + 1;
        }
    }
}
