using System.Collections.Generic;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/55b42574ff091733d900002f
    public static class Friend_or_Foe
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < names.Length; i++)            
                if (names[i].Length == 4)
                    result.Add(names[i]);            
            return result;
        }
    }
}
