using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation
{
    class SortingArray
    {
        public void GetSortedUnionArray(int[] arr1,int[] arr2)
        {
            int i = 0, j = 0;
            int x = arr1.Length, y = arr2.Length;
            ArrayList union = new ArrayList();
            while (i < x && j < y)
            {
                if (arr1[i] > arr2[j])
                {
                    union.Add(arr2[j]);
                    j++;
                }
                else if(arr1[i] < arr2[j])
                {
                    union.Add(arr1[i]);
                    i++;
                }
                else
                {
                    union.Add(arr1[i]);
                    i++;
                    j++;
                }
            }

            while (i < x)
            {
                union.Add(arr1[i]);
                i++;
            }
            while (j < y)
            {
                union.Add(arr1[j]);
                j++;
            }

            foreach(var item in union)
            {
                Console.WriteLine(item);
            }
        }

        public void GetSortedIntersectionArray(int[] arr1,int[] arr2)
        {
            ArrayList intersection = new ArrayList();
            int i = 0, j = 0, x = arr1.Length, y = arr2.Length;
            for (i = 0; i < x; i++)
            {
                for (j = 0; j < y; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        intersection.Add(arr1[i]);
                        break;
                    }
                }
            }

            foreach(var item in intersection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
