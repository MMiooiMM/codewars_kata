using System.Linq;

namespace Kata._6kyu
{
    //https://www.codewars.com/kata/57b06f90e298a7b53d000a86
    public class The_Supermarket_Queue
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] lines = new int[n];
            foreach (int customer in customers)
            {
                int minIndex = 0;
                foreach (int line in lines)
                {
                    if (line == lines.Min())
                        break;
                    minIndex++;
                }
                lines[minIndex] += customer;
            }
            return lines.Max();
        }
    }
}
