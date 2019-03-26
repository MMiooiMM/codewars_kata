namespace Kata._8kyu
{
    //https://www.codewars.com/kata/577bd026df78c19bca0002c0
    public class Correct_the_mistakes_of_the_character_recognition_software
    {
        public static string Correct(string text) => text.Replace("5", "S").Replace("0", "O").Replace("1", "I");
    }
}
