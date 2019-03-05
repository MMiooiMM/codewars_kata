using System.Linq;

namespace Kata._7kyu
{
    //https://www.codewars.com/kata/56484848ba95170a8000004d
    public static class Speed_Control
    {
        public static int Gps(int s, double[] x)
        {
            return x.Count() <= 1 ? 0 : (int)(x.Skip(1).Select((distance, index) => distance - x[index]).Max() * 3600 / s);
        }
    }
}
