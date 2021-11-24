using System;
using System.Collections.Generic;
using System.Text;

namespace ValueSorterComparison
{

    //Below the class is the pseudocode of the entire process

    //This algorithm's best case is O(n)
    //This algorithm's worse case is O(n^2)
    class BubbleSorter
    {
        public int[] CollectedValues;
        public BubbleSorter(int[] array)
        {
            CollectedValues = array;
            BubbleSort(CollectedValues);
            foreach (int i in CollectedValues)
            {
                Console.WriteLine(i);
                Console.ReadKey(true);
            }
        }
        /// <summary>
        /// Goes into each index and compares to the next number to check if its greater then the previous number
        /// Then the values swap places then the process repeats until all the values are sorted
        /// </summary>
        private void BubbleSort(int[] unsortedcollection)
        {
            // variable used to swap the values around efficiently
            int temp;
            //the loop is for every value in the array the nested nature of this is to check the with everything else before moving around the nested j element
            for (int i = 0; i < unsortedcollection.Length - 1; i++)
            {   //i goes in and keeps getting compared to the j array element
                for(int j = 0; j < unsortedcollection.Length - (i + 1); j++)
                {
                    //swap process if the value is greater than element [j+1]
                    if (unsortedcollection[j] > unsortedcollection[j + 1])
                    {
                        temp = unsortedcollection[j + 1];
                        unsortedcollection[j + 1] = unsortedcollection[j];
                        unsortedcollection[j] = temp;
                    }
                }
            }
        }

        /// <summary>
//      Bubblesort(Data: values[])
///     Repeat until the array is sorted.
//    Boolean: not_sorted = True
//    While(not_sorted)
///         Assume we won't find a pair to swap.
//        not_sorted = False
///         Search the array for adjacent items that are out of order.
//        For i = 0 To<length of values> - 1

/// See if items i and i - 1 are out of order.
//            If(values[i] < values[i - 1]) Then
///                Swap them.
//               Data: temp = values[i]
//               values[i] = values[i - 1]
//                values[i - 1] = temp

///                 The array isn't sorted after all.
//                not_sorted = True
//            End If
//        Next i
//    End While
//End   Bubblesort
    /// </summary>
    }
}
