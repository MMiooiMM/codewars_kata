using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/5889a0706069af1cb9000176
    public class Simple_Fun_Runners_Meetings
    {
        public static int RunnersMeetings(int[] StartPosition, int[] speed)
        {
            var sps = StartPosition.Select((x, index) => new Sp
            {
                Position = x * 60d,
                Speel = speed.Where((y, indey) => indey == index).Single() * 1d
            })
            .OrderBy(x => x.Speel)
            .ToList();
            var maxMC = -1;
            while (CheckPosition(sps))
            {
                sps = sps.Select(x => new Sp {
                    Speel = x.Speel,
                    Position = x.Position + x.Speel
                })
                .ToList();
                var MC = GetMeetingCount(sps);
                if (MC > 1 && MC > maxMC)
                    maxMC = MC;
            }
            return maxMC;
        }
        private static int GetMeetingCount(IEnumerable<Sp> sps)
        {
            return sps.GroupBy(x => x.Position).Max(x => x.Count());
        }
        private static bool CheckPosition(List<Sp> sps)
        {
            return sps.Skip(1).Where((x, index) => x.Position < sps[index].Position).Any();
        }
        private class Sp
        {
            public double Speel { get; set; }
            public double Position { get; set; }
        }
    }
}
