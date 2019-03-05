using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    public static class Rainfall
    {
        public static double Mean(string town, string strng)
        {
            var data = GetRainfall(town, strng);

            return data == null ? -1 : data.Sum() / data.Count();
        }

        public static double Variance(string town, string strng)
        {
            var data = GetRainfall(town, strng);
            var mean = Mean(town, strng);
            return data == null ? -1 : data.Select(x => (x - mean) * (x - mean)).Sum() / data.Count();
        }

        public static IEnumerable<double> GetRainfall(string town, string strng) 
            => strng.Split('\n')
            .Where(x => x.Split(':')[0].Contains(town))
            .SingleOrDefault()
            ?.Split(':')[1]
            .Split(',')
            .Select(x => double.Parse(x.Split(' ')[1]));

    }
}
