using System.Collections.Generic;
using System.Linq;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/52a89c2ea8ddc5547a000863
    public static class Can_you_get_the_loop
    {
        public static int getLoopSize(Node startNode)
        {
            List<Node> Nodelist = new List<Node>();
            while (true)
            {
                Nodelist.Add(startNode);
                startNode = startNode.next;
                if (Nodelist.Count() < 20000)
                {
                    if (Nodelist.IndexOf(startNode) != -1)
                        break;
                }
                {
                    if (Nodelist.Count() % 10000 == 0)
                    {
                        if (Nodelist.IndexOf(startNode) != -1)
                            break;
                    }
                }
            }
            return Nodelist.Count() - Nodelist.IndexOf(startNode);
        }
    }

    public class Node
    {
        public Node next { get; set; }
    }
}
