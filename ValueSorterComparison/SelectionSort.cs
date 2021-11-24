using System;
using System.Collections.Generic;
using System.Text;

namespace ValueSorterComparison
{

    //Below the class is the pseudocode of the entire process

    //This algorithm's best case is O(n)
    //This algorithm's worse case is O(n^2)
    class SelectionSort
    {
        public int[] CollectedValues;
        public SelectionSort(int[] array)
        {
            CollectedValues = array;
            SelectSort(CollectedValues);
            foreach (int i in CollectedValues)
            {
                Console.WriteLine(i);
                Console.ReadKey(true);
            }
        }
        public void SelectSort(int[] array)
        {
            //minValue is short for position of min
            int minValue, temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                minValue = i;//set minValue to the current index of array

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minValue])
                    {
                        //minValue will keep track of the index that min is in, this is needed when a swap happens
                        minValue = j;
                    }
                }

                //if minValue no longer equals i than a smaller value must have been found, so a swap must occur
                if (minValue != i)
                {
                    temp = array[i];
                    array[i] = array[minValue];
                    array[minValue] = temp;
                }
            }
        }
    }
//    Selectionsort(Data: values[])
//    For i = 0 To<length of values> - 1
        /// Find the item that belongs in position i.
//        <Find the smallest item with index j >= i.>
//        <Swap values[i] and values[j].>
//    Next i
//End Selectionsort
}
