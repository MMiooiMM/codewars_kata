using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    public class Catalog
    {
        public static string _Catalog(string s, string article)
        {
            var result = string.Join("\n", PickTagContent(s, "prod")
                .Where(x => x.IndexOf(article) != -1)
                .Select(prod => $"{GetTagValue(prod, "name")} > prx: ${GetTagValue(prod, "prx")} qty: {GetTagValue(prod, "qty")}"));
            
            return string.IsNullOrWhiteSpace(result) ? "Nothing" : result;
        }
        public static IEnumerable<string> PickTagContent(string str, string tag)
        {
            int index = 0;
            while(true)
            {
                int previndex = index;
                index = str.IndexOf($"/{tag}", previndex + 1);
                if (index == -1) break;
                yield return str.Substring(previndex, index - previndex);
            }
        }
        public static string GetTagValue(string str, string tag)
        {
            return str.Substring(str.IndexOf(tag), str.LastIndexOf(tag) - str.IndexOf(tag))
                .Replace(tag, "").Replace(">","").Replace("</","");
        }
    }
}
