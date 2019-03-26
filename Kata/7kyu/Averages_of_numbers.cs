namespace Kata._7kyu
{
    //https://www.codewars.com/kata/57d2807295497e652b000139
    public class Averages_of_numbers
    {
        public static double[] Averages(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 1) return new double[0];
            double[] res = new double[numbers.Length - 1];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = (numbers[i] + numbers[i + 1]) / 2.0;
            }
            return res;
        }
    }
}
