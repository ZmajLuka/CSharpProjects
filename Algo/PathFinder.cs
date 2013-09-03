using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astar.Algo.Nodes;

namespace Astar.Algo
{
    public class PathFinder
    {

        public static void Main()
        {
            Astar astar = new Astar(new Node(2, 20), new Node(18, 43));
            Node[] nodes = astar.FindPath();
            if (nodes != null)
            {
                foreach (Node node in nodes)
                {
                    System.Console.WriteLine(node.ToString());
                }
            }
            else
            {
                System.Console.WriteLine("Path was null, could not find one");
            }
        }

    }
}
