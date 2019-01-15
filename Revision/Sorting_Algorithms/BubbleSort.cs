using System;
using System.Collections.Generic;
namespace Sorting_Algorithms
{
    public class BubbleSort
    {
        int[] myArray;

        public BubbleSort()
        {
            foreach(int i in myArray)
            {
                if(myArray[i] > myArray[i+1])
                {
                    swap(myArray[i], myArray[i + 1]);
                }
            }
        }

        private void swap(int v1, int v2)
        {
            int temp;
            temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
