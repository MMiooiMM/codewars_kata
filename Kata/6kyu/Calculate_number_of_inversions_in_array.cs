namespace Kata._6kyu
{
    //https://www.codewars.com/kata/537529f42993de0e0b00181f
    public class Calculate_number_of_inversions_in_array
    {
        public static int CountInversions(int[] array)
        {
            bool todo = true;
            int result = 0;
            while (todo)
            {
                int count = result;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        array[i] = array[i] + array[i + 1];
                        array[i + 1] = array[i] - array[i + 1];
                        array[i] = array[i] - array[i + 1];
                        result++;
                    }
                }
                if (count == result)
                    todo = false;
            }
            return result;
        }
    }
}
