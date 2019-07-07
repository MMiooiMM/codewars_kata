namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5544c7a5cb454edb3c000047
    public class Bouncing_Balls
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h <= 0 || bounce >= 1 || bounce <= 0 || window >= h)
                return -1;
            int result = 1;
            h *= bounce;
            while (h >= window)
            {
                h *= bounce;
                result += 2;
            }
            return result;
        }
    }
}