using System.Linq;

namespace Kata._7kyu
{
    public static class Speed_Control
    {
        public static int Gps(int s, double[] x)
        {
            return x.Count() <= 1 ? 0 : (int)(x.Skip(1).Select((distance, index) => distance - x[index]).Max() * 3600 / s);
        }
    }
}
