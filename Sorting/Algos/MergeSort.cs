using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.Algos
{
    public class MergeSort : Algorithm<int>
    {

        public MergeSort(List<int> array)
        {
            this.array = array;
        }

        public override List<int> GetArray()
        {
            return this.array;
        }

        public override List<int> Sort()
        {

            int arraySize = array.Count();
            System.Console.WriteLine(arraySize);
            for (int i = 1; i < arraySize; i *= 2)
            {
                for (int j = 0; j < arraySize - i; j += 2 * i)
                {
                    int t = (2 * i < arraySize - j) ? 2 * i : arraySize - j;
                    Merge(array, i, t);
                }
            }

            return array;

        }

        private void Merge(List<int> array, int e, int t)
        {
            int[] temp = new int[t];
            int i = 0, j = e, k = 0;

            while (i < e && j < t)
            {
                if (array[i] < array[j])
                {
                    Console.WriteLine(i + " " + array[i]);
                    temp[k] = array[i];
                    i++;
                }
                else
                {
                    temp[k] = array[j];
                    j++;
                }
                k++;
            }
            while (i < e)
            {
                temp[k] = array[i];
                i++; k++;
            }

            while (j < t)
            {
                temp[k] = array[j];
                j++; k++;
            }

            for (int x = 0; x < t; x++)
            {
                array[x] = temp[x];
            }
        }

    }
}
