namespace Kata._6kyu
{
    //https://www.codewars.com/kata/514b92a657cdc65150000006
    public class Multiples_of_3_or_5
    {
        public static int Solution(int value)
        {
            int result = 0;
            for (int i = 3; i < value; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            return result;
        }
    }
}