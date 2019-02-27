namespace Kata._8kyu
{
    //https://www.codewars.com/kata/557af9418895e44de7000053
    public static class repeatIt
    {
        public static string RepeatString(object toRepeat, int n)
        {
            if (toRepeat != null && toRepeat.GetType().FullName == "System.String")
            {
                string s = "";
                while (n-- > 0)
                {
                    s += toRepeat;
                }
                return s;
            }
            else
            {
                return "Not a string";
            }
        }
    }
}
