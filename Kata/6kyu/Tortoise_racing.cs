namespace Kata._6kyu
{
    //https://www.codewars.com/kata/55e2adece53b4cdcb900006c
    public static class Tortoise_racing
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;
            int h = 0, m = 0, s = 0;
            int v = v2 - v1;
            decimal time = decimal.Divide(g, v) * 3600;
            while (time - 3600 >= 0)
            {
                time -= 3600;
                h++;
            }
            while (time - 60 >= 0)
            {
                time -= 60;
                m++;
            }
            s = (int)time;
            return new int[] { h, m, s };
        }
    }
}
