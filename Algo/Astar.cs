using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astar.Algo.Nodes;

namespace Astar.Algo
{
    public class Astar
    {

        public Node start;
        public Node finish;

        public Astar(Node start, Node finish)
        {
            this.start = start;
            this.finish = finish;
        }


        public Node[] FindPath()
        {
            HashSet<Node> open = new HashSet<Node>();
            HashSet<Node> closed = new HashSet<Node>();

            Node current = start;
            current.G = 0;

            Node destination = finish;

            current.F = HeuristicCost(current, destination);
            open.Add(current);

            while (open.Count != 0)
            {
                current = Lowest_f(open);
                if (current.Equals(destination))
                {
                    if (current.previous != null)
                    {
                        return Path(current, start);
                    }

                }

                open.Remove(current);
                closed.Add(current);

                foreach (Node node in GetNeighbours(current))
                {
                    double t = current.G + Distance(current, node);

                    if (t < node.G)
                    {
                        if (open.Contains(node))
                        {
                            open.Remove(node);
                        }
                        if (closed.Contains(node))
                        {
                            closed.Remove(node);
                        }
                    }

                    if (!open.Contains(node) && !(closed.Contains(node)))
                    {
                        node.G = t;
                        node.F = HeuristicCost(node, destination);
                        node.previous = current;
                        open.Add(node);
                    }
                }
            }
            return null;
        }

        private List<Node> GetNeighbours(Node current)
        {
            List<Node> neighbours = new List<Node>();

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x != 0 || y != 0)
                    {
                        Node node = new Node(current.X + x, current.Y + y);
                        neighbours.Add(node);
                    }
                }
            }
            return neighbours;
        }


        private double Distance(Node one, Node two)
        {
            return Math.Sqrt(Math.Pow(two.X - one.X, 2) + Math.Pow(two.Y - one.Y, 2));
        }

        private double HeuristicCost(Node start, Node end)
        {
            double dx = start.X - end.X;
            double dy = start.Y - end.Y;

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

        private Node Lowest_f(HashSet<Node> open)
        {
            Node n = null;
            foreach (Node node in open)
            {
                if (n == null || node.F < n.F)
                {
                    n = node;
                }
            }
            return n;
        }


        private Node[] Path(Node destination, Node start)
        {
            LinkedList<Node> nodes = new LinkedList<Node>();
            Node node = destination;
            while (!start.Equals(destination))
            {
                nodes.AddFirst(new Node(node.X, node.Y));
                if (node.previous == null)
                {
                    break;
                }
                node = node.previous;
            }
            return nodes.ToArray();
        }

    }

}
