using System;
using System.Collections;
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

        public static bool ArrayAreEqual<T>(T[] Arr1, T[] Arr2)
        {
            if (Arr1.Count() != Arr2.Count())
                return false;
            for(int i = 0; i < Arr1.Count(); i++)
            {
                if (Arr1[i].ToString() != Arr2[i].ToString())
                    return false;
            }
            return true;
        }

        public static bool ArrayAreEqual(ArrayList Arr1, ArrayList Arr2)
        {
            if (Arr1.Count != Arr2.Count)
                return false;
            for (int i = 0; i < Arr1.Count; i++)
            {
                if (Arr1[i].ToString() != Arr2[i].ToString())
                    return false;
            }
            return true;
        }
    }
}
