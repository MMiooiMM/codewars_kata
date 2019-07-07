namespace Kata._6kyu
{
    //https://www.codewars.com/kata/525f50e3b73515a6db000b83
    public class Create_Phone_Number
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }
    }

    public class Create_Phone_Number_Clever
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}