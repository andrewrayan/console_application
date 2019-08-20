using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation
{
    class BinarySearching
    {
        int searchCount = 1;
        public Boolean BinarySearchRecursive(int[] array,int value,int left,int right)
        {
            if(left > right)
            {
                return false;
            }
            else
            {
                int mid = (left + right) / 2;
                if (array[mid] == value)
                {
                    return true;
                }
                else if (array[mid] > value)
                {
                    searchCount++;
                    return BinarySearchRecursive(array, value, left, mid - 1);
                }
                else
                {
                    searchCount++;
                    return BinarySearchRecursive(array, value, mid + 1, right);
                }
            }
        }

        public int GetSearchCount()
        {
            return searchCount;
        }

        public void SetSearchCount()
        {
            searchCount = 1;
        }
    }
}
