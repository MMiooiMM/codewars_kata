namespace Kata._6kyu
{
    //https://www.codewars.com/kata/555615a77ebc7c2c8a0000b8
    public class Vasya_Clerk
    {
        public static string Tickets(int[] peopleInLine)
        {
            int _25Count = 0;
            int _50Count = 0;
            foreach (int now in peopleInLine)
            {
                if (now == 25)
                    _25Count += 1;
                else if (now == 50)
                {
                    _50Count += (_25Count >= 1) ? 1 : -1;
                    _25Count -= (_25Count >= 1) ? 1 : 0;
                }
                else if (now == 100)
                {
                    _50Count -= (_25Count >= 3) ? 0 : 1;
                    _25Count -= (_25Count >= 3) ? 3 : 1;
                }
                if (_25Count < 0 || _50Count < 0)
                    return "NO";
            }
            return "YES";
        }
    }
}