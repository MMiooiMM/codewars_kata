namespace Kata._8kyu
{
    //https://www.codewars.com/kata/5bb904724c47249b10000131
    public class Total_amount_of_points
    {
        public static int TotalPoints(string[] games)
        {
            // insert magic here
            int result = 0;
            foreach (var game in games)
            {
                int x = int.Parse(game.Substring(0, 1));
                int y = int.Parse(game.Substring(2, 1));
                if (x > y)
                    result += 3;
                else if (x == y)
                    result += 1;
            }
            return result;
        }
    }
}
