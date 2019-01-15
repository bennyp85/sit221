using System;
namespace Sorting_Algorithms
{
    public class SelectionSort
    {
        int[] myArray;

        public int lengthOfArray {get { return myArray.Length; } }

        private void swap(int v1, int v2)
        {
            int temp;
            temp = v1;
            v1 = v2;
            v2 = temp;
        }

        public SelectionSort()
        {
            for (int i = 1; i < lengthOfArray - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < lengthOfArray; j++)
                {
                    if(myArray[j] < myArray[min])
                    {
                        min = j;
                    }
                }

                if(min != i)
                {
                    swap(myArray[min], myArray[i]);
                }
            }
        }
    }
}
