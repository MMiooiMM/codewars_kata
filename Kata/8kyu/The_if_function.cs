using System;

namespace Kata._8kyu
{
    //https://www.codewars.com/kata/54147087d5c2ebe4f1000805
    public class The_if_function
    {
        public static void If(bool condition, Action func1, Action func2)
        {
            var a = condition ? func1 : func2;
            a.Invoke();
        }
    }
}