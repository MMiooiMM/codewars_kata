namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5996eb39cdc8eb39f80000a0
    public static class Round_and_Round
    {
        public static decimal RoundBy2DecimalPlaces(this decimal number)
        {
            number = (int)(number * 1000);
            if (number % 10 >= 5) number += 10;
            if (number % 10 <= -5) number -= 10;
            number = (int)(number / 10);
            number /= 100;
            return number;
        }
    }
}
