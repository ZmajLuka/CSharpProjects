using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.Algos
{
    public class Insertionsort : Algorithm<int>
    {

        public Insertionsort(List<int> array)
        {
            this.array = array;
        }

        public override List<int> Sort()
        {
            for (int i = 1; i < array.Count; i++)
            {
                int value = array[i];
                int h = i;

                while (h > 0 && array[h - 1] >= value)
                {
                    array[h] = array[h - 1];
                    h -= 1;
                }

                array[h] = value;
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
