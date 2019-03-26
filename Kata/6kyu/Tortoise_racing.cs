namespace Kata._6kyu
{
    //https://www.codewars.com/kata/55e2adece53b4cdcb900006c
    public class Tortoise_racing
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;
            var res = g * 3600d / (v2 - v1);
            return new int[] { (int)(res / 3600), (int)(res % 3600 / 60), (int)(res % 60) };
        }

        public static int[] Race_Best_Practices(int v1, int v2, int g)
        {
            if (v1 >= v2)
                return null;
            var ts = System.TimeSpan.FromSeconds((g * 3600) / (v2 - v1));
            return new[] { ts.Hours, ts.Minutes, ts.Seconds };
        }
    }
}
