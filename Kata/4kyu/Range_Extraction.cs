using System.Collections.Generic;
using System.Linq;

namespace Kata._4kyu
{
    //https://www.codewars.com/kata/51ba717bb08c1cd60f00002f
    public class Range_Extraction
    {
        public static string Extract(int[] args)
        {
            if (args is null || args.Length == 0) return "";
            var prev = args[0];
            var result = new List<string>();
            var tmp = args.Skip(1).Select((e, index) => new { range = e == args[index] + 1, index }).ToList();
            tmp.Add(new { range = false, index = args.Length - 1 });
            foreach (var element in tmp)
            {
                if (!element.range)
                {
                    if (prev == args[element.index])
                    {
                        result.Add(prev + "");
                    }
                    else
                    {
                        if(prev == args[element.index - 1])
                        {
                            result.Add(prev + "");
                            result.Add(args[element.index] + "");
                        }
                        else
                        {
                            result.Add(prev + "-" + args[element.index]);
                        }                        
                    }
                    prev = (element.index + 1) == args.Length ? 0 : args[element.index + 1];
                }
            }
            return string.Join(",", result);
        }
    }
}
