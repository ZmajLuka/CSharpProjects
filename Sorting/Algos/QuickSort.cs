using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.Algos
{
    public class QuickSort : Algorithm<int>
    {

        public QuickSort(List<int> array)
        {
            this.array = array;
        }

        public override List<int> Sort()
        {
            Partition(array, array.Count());
            
            return array;
        }

        public override List<int> GetArray()
        {
            return this.array;
        }
         
        private void Partition(List<int> array , int arraySize)
        {

            if (arraySize <= 1)
            {
                return;
            }

            Random random = new Random();
            int pivot = array[random.Next(arraySize - 1)];
            int lower = 0, upper = arraySize-1;

            while (lower < upper)
            {
                while (array[lower] < pivot)
                {
                    lower++;
                }

                while (array[upper] > pivot)
                {
                    --upper;
                }

                int temp = array[lower];
                array = Swap(array,lower, upper);
            }

            Partition(array, lower);
            Partition(array, arraySize - lower - 1);
           
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
