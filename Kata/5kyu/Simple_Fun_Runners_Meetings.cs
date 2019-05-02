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
            //coding and coding..
            StartPosition = StartPosition.Select(x => x * 60).ToArray();
            var count = StartPosition.Length;
            var meetings = new List<Meetings>();
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (speed[i] == speed[j])
                        continue;
                    var time = 1.0d * (StartPosition[i] - StartPosition[j]) / (speed[j] - speed[i]);
                    if (time < 0)
                        continue;
                    meetings.Add(new Meetings { Time = time, Position = StartPosition[i] + (speed[i] * time) });
                }
            }
            return meetings.Any() ? GetRunners(meetings.GroupBy(x => new { x.Time, x.Position }).Max(x => x.Count())) : -1;
        }

        private static int GetRunners(int i)
        {
            var count = 1;
            while (i != 0)
            {
                i -= count;
                count++;
            }
            return count;
        }

        private class Meetings
        {
            public double Time { get; set; }
            public double Position { get; set; }
        }
    }

    public class Simple_Fun_Runners_Meetings_Clever
    {
        public int RunnersMeetings(int[] startPosition, int[] speed)
        {
            return RunnersMeetings(startPosition.Zip(speed, (a, b) => new Meetings { startPosition = a, speed = b }));
        }

        private int RunnersMeetings(IEnumerable<Meetings> runners)
        {
            if (runners.Count() < 2) return -1;
            var r1 = runners.First();
            var meetings = runners.Skip(1)
                                  .Where(r2 => (r2.startPosition - r1.startPosition) * (r1.speed - r2.speed) > 0)
                                  .Select(r2 => (r2.startPosition - r1.startPosition) / (r1.speed - r2.speed));
            var cardinality = meetings.Count() == 0 ? -1 : meetings.GroupBy(m => m).Max(g => g.Count() + 1);
            return Math.Max(cardinality, RunnersMeetings(runners.Skip(1)));
        }

        private class Meetings
        {
            public double startPosition { get; set; }
            public double speed { get; set; }
        }
    }
}
