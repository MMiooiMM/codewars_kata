namespace Kata._8kyu
{
    //https://www.codewars.com/kata/56f6ad906b88de513f000d96
    public class Do_I_get_a_bonus
    {
        public static string bonus_time(int salary, bool bonus) => "$" + (bonus ? (salary * 10) : salary);
    }
}