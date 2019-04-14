using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class TestHelper
    {
        public static string Array2DToString(string[][] str)
        {
            if (!(str is string[][]))
                return string.Empty;
            return $"[{string.Join(", ", str.Select(x => $"[{string.Join(", ", x.Select(o => $"\"{o}\""))}]"))}]";
        }
    }
}
