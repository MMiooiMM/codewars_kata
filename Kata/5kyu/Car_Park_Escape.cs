using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._5kyu
{
    public class Car_Park_Escape
    {
        public static string[] escape(int[,] carpark)
        {
            var movelist = new List<int>();
            var result = new List<string>();
            int position = 0;
            int staircases = 0;
            int space = carpark.GetLength(1) - 1;
            int level = carpark.GetLength(0) - 1;
            bool isStart = false;
            for (int i = 0; i <= level; i++)
            {
                bool isBotton = true;
                for (int j = 0; j <= space; j++)
                {
                    switch (carpark[i, j])
                    {
                        case 1:
                            staircases = j;
                            isBotton = false;
                            break;
                        case 2:
                            position = j;
                            isStart = true;
                            break;
                    }
                }
                if (isBotton || !isStart) continue;
                movelist.Add(staircases - position);
                position = staircases;
            }
            movelist.Add(space - position);

            int downcount = 0;
            bool down = false;
            foreach (var move in movelist)
            {
                if (move != 0)
                {
                    if (downcount > 0)
                    {
                        result.Add("D" + downcount);
                        downcount = 0;
                    }
                    if (move > 0)
                    {
                        result.Add("R" + move);
                    }
                    else if (move < 0)
                    {
                        result.Add("L" + move * -1);
                    }
                    down = false;
                }
                else
                {
                    down = true;
                }
                downcount++;
            }
            if (down)
            {
                if (--downcount != 0)
                    result.Add("D" + downcount);
            }
            return result.ToArray();
        }
    }
    public class Car_Park_Escape_Clever
    {
        public static string[] escape(int[,] carpark)
        {
            var list = new List<string>();
            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                var stair = -1;
                var car = -1;
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[i, j] == 1) stair = j;
                    if (carpark[i, j] == 2) car = j;
                }
                if (stair >= 0 && car >= 0)
                {
                    list.Add(stair < car ? $"L{car - stair}" : $"R{stair - car}");
                    var k = i;
                    while (carpark[k, stair] == 1) k++;
                    list.Add($"D{k - i}");
                    carpark[k, stair] = 2;
                    i += k - i - 1;
                }
                else if (car >= 0)
                {
                    var r = carpark.GetLength(1) - 1 - car;
                    if (r > 0) list.Add($"R{r}");
                }
            }
            return list.ToArray();
        }
    }
}