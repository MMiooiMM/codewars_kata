namespace Kata._7kyu
{
    //https://www.codewars.com/kata/555bfd6f9f9f52680f0000c5
    public static class Reverse_a_Number
    {
        public static int ReverseNumber(int n)
        {
            int result = 0;

            while (n < 0 || n > 0)
            {
                result = result * 10 + n % 10;
                n /= 10;
            }
            return result;
        }
    }
}
