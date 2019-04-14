using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/56f3a1e899b386da78000732
    public class Parts_of_a_list
    {
        public static string[][] Partlist(string[] arr)
        {
            var result = new string[arr.Length - 1][];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                result[i] = new string[2];
                result[i][0] = string.Join(" ", arr.Take(i + 1));
                result[i][1] = string.Join(" ", arr.Skip(i + 1));
            }
            return result;
        }

        public static string[][] Partlist_Linq(string[] arr)
        {            
            return Enumerable.Range(0, arr.Length - 1).Select(i =>
               new string[] { string.Join(" ", arr.Take(i + 1)), string.Join(" ", arr.Skip(i + 1)) }).ToArray();
        }
    }
}
