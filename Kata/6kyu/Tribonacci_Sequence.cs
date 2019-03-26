using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/tribonacci-sequence
    public class Tribonacci_Sequence
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            var result = signature.ToList();
            
            while(result.Count < n)
            {
                result.Add(result.Skip(result.Count - 3).Sum());
            }
            return result.Take(n).ToArray();
        }
    }
}