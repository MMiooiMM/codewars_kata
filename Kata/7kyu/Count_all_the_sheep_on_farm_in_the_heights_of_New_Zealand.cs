using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/58e0f0bf92d04ccf0a000010
    public static class Count_all_the_sheep_on_farm_in_the_heights_of_New_Zealand
    {
        public static int lostSheep(int[] friday, int[] saturday, int total)
        {
            return total - friday.Aggregate((x, y) => x + y) - saturday.Aggregate((x, y) => x + y);
        }
    }
}
