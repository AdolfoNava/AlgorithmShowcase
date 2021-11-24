using System;
using System.Collections.Generic;
using System.Text;

namespace ValueSorterComparison
{

    //Below the class is the pseudocode of the entire process

    //This algorithm's best case is O(n log n)
    //This algorithm's worse case is O(n log n)
    class HeapSorter
    {
        public int[] CollectedValues;
        public HeapSorter(int[] array)
        {
            CollectedValues = array;
            HeapSort(CollectedValues);
            foreach (int i in CollectedValues)
            {
                Console.WriteLine(i);
                Console.ReadKey(true);
            }
        }
        // function for heap sort which calls heapify function 
        // to build the max heap and then swap last element of 
        // the max-heap with the first element
        // exclude the last element from the heap and rebuild the heap
        private void HeapSort(int[] Array)
        {
            int n = Array.Length;
            int temp;
            for (int i = n / 2; i >= 0; i--)
            {
                heapify(Array, n - 1, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                //swap last element of the max-heap with the first element
                temp = Array[i];
                Array[i] = Array[0];
                Array[0] = temp;

                //exclude the last element from the heap and rebuild the heap 
                heapify(Array, i - 1, 0);
            }
        }

        // heapify function is used to build the max heap
        // max heap has maximum element at the root which means
        // first element of the array will be maximum in max heap
        private void heapify(int[] Array, int n, int i)
        {
            int max = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            //if the left element is greater than root
            if (left <= n && Array[left] > Array[max])
            {
                max = left;
            }

            //if the right element is greater than root
            if (right <= n && Array[right] > Array[max])
            {
                max = right;
            }

            //if the max is not i
            if (max != i)
            {
                int temp = Array[i];
                Array[i] = Array[max];
                Array[max] = temp;
                //Recursively heapify the affected sub-tree
                heapify(Array, n, max);
            }
        }
    }
}
