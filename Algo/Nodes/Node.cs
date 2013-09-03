using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astar.Algo.Nodes
{
    public class Node
    {

        public Node(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Node previous;
        public int X { get; set; }
        public int Y { get; set; }
        public double G { get; set; }
        public double F { get; set; }

        public override Boolean Equals(Object o)
        {
            Node node = o as Node;
            if (o == null)
            {
                return false;
            }
            return X == node.X && Y == node.Y;
        }

        public override int GetHashCode()
        {
            return X * Y;
        }

        public override String ToString()
        {
            return "Node = " + X + "," + Y;
        }


    }
}
