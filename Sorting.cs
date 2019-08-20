using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation
{
    class Sorting
    {
        public int[] array = { 6, 3, 8, 2, 10, 18, 13, 11, 15 };

        public int[] bubbleSort(int[] array)
        {
            int lastElement = array.Length;
            for (int i = 0; i < lastElement - 1; i++)
            {
                for(int j = i+1; j < lastElement; j++)
                {
                    if(array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        #region mergesort
        public void mergeSort(int low,int high)
        {
            if(low < high)
            {
                int mid = (low + high) / 2;
                mergeSort(low, mid);
                mergeSort(mid + 1, high);
                merge_sort(low, mid, high);
            }
            else
            {
                return;
            }
        }

        private void merge_sort(int low,int middle,int high)
        {
            int[] temp = new int[high+1];
            for(int count = 0; count <= high; count++)
            {
                temp[count] = array[count];
            }

            int i = low;
            int j = middle+1;
            int k = low;

            while(i<=middle && j <= high)
            {
                if (temp[i] > temp[j])
                {
                    array[k] = temp[j];
                    j++;
                }
                else
                {
                    array[k] = temp[i];
                    i++;
                }
                k++;
            }


            while (i <= middle)
            {
                array[k] = temp[i];
                i++;
                k++;
            }
            while (j <= high)
            {
                array[k] = temp[j];
                j++;
                k++;
            }
        }

        public void printArray()
        {
           foreach(var i in array)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
    }
}
