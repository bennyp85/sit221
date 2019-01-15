using System;
namespace Sorting_Algorithms
{
    public class InsertionSort
    {
        int[] myArray;
        int holePosition;
        int valueToinsert;

        private InsertionSort()
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                valueToinsert = myArray[i];
                holePosition = 1;
                while(holePosition > 0 && myArray[holePosition-1] > valueToinsert)
                {
                    myArray[holePosition] = myArray[holePosition - 1];
                    holePosition = holePosition - 1;
                }
                myArray[holePosition] = valueToinsert;
            }
        }
    }
}
