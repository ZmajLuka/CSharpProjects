using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.Algos
{
    public class Bubblesort : Algorithm<int>
    {

        public Bubblesort(List<int> array)
        {
            this.array = array;
        }


        public override List<int> Sort()
        {
            Boolean swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = array.Count - 1; i > 0; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        swapped = true;
                        array = Swap(array, i - 1, i);
                    }
                }
            }
            return array;
        }

        public override List<int> GetArray()
        {
            return this.array;
        }


        private List<int> Swap(List<int> list, int firstIndex, int secondIndex)
        {
            int a = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = a;
            return list;
        }
    }
}
