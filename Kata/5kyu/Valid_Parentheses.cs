namespace Kata._5kyu
{
    //https://www.codewars.com/kata/52774a314c2333f0a7000688
    public class Valid_Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            int a = 0;
            foreach (char c in input)
            {
                if (c == '(') a += 1;
                if (c == ')') a -= 1;
                if (a < 0) return false;
            }
            return (a == 0);
        }
    }
}