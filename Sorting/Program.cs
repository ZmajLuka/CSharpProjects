using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms.Sorting.Algos;
using Algorithms.Sorting;

namespace Algorithms
{
    public class Program
    {
        static void Main()
        {
            List<int> array = new List<int> { 123, 12312, 3232, 21, 432, 123414 };
            Insertionsort algorithm = new Insertionsort(array);

            foreach (int i in algorithm.Sort())
            {
                Console.Write(i + "  ");
            }
        }
    }
}
