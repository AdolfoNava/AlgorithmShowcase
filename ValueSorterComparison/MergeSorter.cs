using System;
using System.Collections.Generic;
using System.Text;

namespace ValueSorterComparison
{

    //Below the class is the pseudocode of the entire process

    //This algorithm's best case is O(n log n)
    //This algorithm's worst case is O(n log n)
    class MergeSorter
    {
        public int[] CollectedValues;
        public MergeSorter(int[] array)
        {
            CollectedValues = array;
            CollectedValues = MergeSort(CollectedValues);
            foreach (int i in CollectedValues)
            {
                Console.WriteLine(i);
                Console.ReadKey(true);
            }
        }
        //This is the only Sorting Algorithm with a return method because it gets used many times
        //and having be a return value lets me better see the process as it transitions to check for errors better
        public int[] MergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
                return array;
            // The exact midpoint of our array  
            int midPoint = array.Length / 2;
            //Will represent our 'left' array
            left = new int[midPoint];

            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //populate right array   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to midpoint
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = MergeSort(left);
            //Recursively sort the right array
            right = MergeSort(right);
            //Merge our two sorted arrays
            result = merge(left, right);
            return result;
        }
        public int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
//        Mergesort(Data: values[], Data: scratch[], Integer: start, Integer: end)
///     If the array contains only one item, it is already sorted.

//If(start == end) Then Return

///     Break the array into left and right halves.
//        Integer: midpoint = (start + end) / 2
 
///     Call Mergesort to sort the two halves.
//    Mergesort(values, scratch, start, midpoint)
//    Mergesort(values, scratch, midpoint + 1, end)

///     Merge the two sorted halves.
//        Integer: left_index = start
//    Integer: right_index = midpoint + 1
//    Integer: scratch_index = left_index
//    While((left_index <= midpoint) And(right_index <= end))
//        If(values[left_index] <= values[right_index]) Then
//           scratch[scratch_index] = values[left_index]
//            left_index = left_index + 1
//        Else
//            scratch[scratch_index] = values[right_index]
//            right_index = right_index + 1
//        End If
//        scratch_index = scratch_index + 1    End While

///     Finish copying whichever half is not empty.
//        For i = left_index To midpoint
//        scratch[scratch_index] = values[i]
//        scratch_index = scratch_index + 1
//    Next i
//    For i = right_index To end

//scratch[scratch_index] = values[i]
//        scratch_index = scratch_index + 1
//    Next i
//    // Copy the values back into the original values array.
//    For i = start To end
//        values[i] = scratch[i]
//    Next i
//End Mergesort
    }
}
