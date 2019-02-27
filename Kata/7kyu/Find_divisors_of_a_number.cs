namespace Kata._7kyu
{
    //https://www.codewars.com/kata/542c0f198e077084c0000c2e
    public static class Find_divisors_of_a_number
    {
        public static int Divisors(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                int j = n / i;
                if (n == j * i)
                    count++;
            }
            return count;
        }
    }
}
