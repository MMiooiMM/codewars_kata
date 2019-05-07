using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class TestHelper
    {
        public static string Array2DToString(string[][] arr)
        {
            if (!(arr is string[][]))
                return string.Empty;
            return $"[{string.Join(", ", arr.Select(x => $"[{string.Join(", ", x.Select(o => $"\"{o}\""))}]"))}]";
        }

        public static string ArrayToString<T>(IEnumerable<T> arr)
        {
            if (!(arr is IEnumerable<T>))
                return string.Empty;
            return $"[{string.Join(", ", arr.Select(x => x + ""))}]";
        }
    }
}
