namespace Kata._7kyu
{
    //https://www.codewars.com/kata/563b662a59afc2b5120000c6
    public static class Growth_of_a_Population
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int years = 0;
            while (p0 < p)
            {
                p0 = p0 + (int)(p0 * percent / 100) + aug;
                years++;
            }
            return years;
        }
    }
}
