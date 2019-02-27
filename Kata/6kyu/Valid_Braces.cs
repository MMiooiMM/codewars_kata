using System;
using System.Collections.Generic;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/5277c8a221e209d3f6000b56
    public static class Valid_Braces
    {
        public static bool validBraces(String braces)
        {
            if (string.IsNullOrEmpty(braces.Trim()))
                return false;
            Stack<char> s1 = new Stack<char>();
            foreach (char brace in braces)
            {
                switch (brace)
                {
                    case ')':
                    case ']':
                    case '}':
                        if (s1.Count == 0)
                            return false;
                        string s = s1.Pop().ToString() + brace.ToString();
                        if (s != "()" && s != "[]" && s != "{}")
                            return false;
                        break;
                    default:
                        s1.Push(brace);
                        break;
                }
            }
            if (s1.Count != 0)
                return false;
            return true;
        }
    }
}
