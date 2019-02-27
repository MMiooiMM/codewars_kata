namespace Kata._7kyu
{
    //https://www.codewars.com/kata/51675d17e0c1bed195000001
    public static class Largest_5_digit_number_in_a_series
    {
        public static int GetNumber(string str)
        {
            int max = 0;
            for (int i = 0; i <= str.Length - 5; i++)
            {
                int tmp = int.Parse(str.Substring(i, 5));
                if (tmp > max)
                {
                    max = tmp;
                }
            }
            return max;
        }
    }
}
