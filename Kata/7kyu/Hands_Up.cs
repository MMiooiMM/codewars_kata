namespace Kata._7kyu
{
    //https://www.codewars.com/kata/56d8f14cba01a83cdb0002a2
    public class Hands_Up
    {
        public static int[] GetPositions(int s)
        {
            return new int[] { s % 3, (s % 9) / 3, (s % 27) / 9 };
        }
    }
}
