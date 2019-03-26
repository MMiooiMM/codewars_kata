using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/595ddfe2fc339d8a7d000089
    public class Hamster_me
    {
        public static string HamsterMe(string code, string message)
        {
            List<int> l = new List<int>();
            string result = "";
            foreach (char c in code)
            {
                l.Add(c);
            }
            l.Sort();
            foreach (char c in message)
            {
                int m = l.Where(x => x <= c).OrderByDescending(x => x).FirstOrDefault();
                if (m == 0)
                    result += (char)l.Max() + (c - l.Max() + 27).ToString();                
                else                
                    result += (char)m + (c - m + 1).ToString();  
            }
            return result;
        }
    }
}
