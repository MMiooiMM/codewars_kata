namespace Kata._7kyu
{
    //https://www.codewars.com/kata/58841cb52a077503c4000015
    public class Simple_Fun_2_Circle_of_Numbers
    {
        public static int CircleOfNumbers(int n, int FirstNumber)
        {
            return (FirstNumber >= n / 2) ? FirstNumber - n / 2 : FirstNumber + n / 2;
        }
    }
}
