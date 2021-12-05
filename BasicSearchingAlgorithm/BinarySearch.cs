using System;
using System.Collections.Generic;
using System.Text;

namespace BasicSearchingAlgorithm
{
    class BinarySearch
    {
        /// <summary>
        /// Compare the value in question starting in the middle and move 
        /// accordingly based on the where it is upper or lower bounded
        /// Best Case O (1)
        /// Worst Case O (log n)
        /// </summary>
        //Below the class is the pseudocode of the process
        public BinarySearch()
        {

        }
        //Binary Search done Iteratively make use of the same method called until the value position is found or not in the system
        public int BinarySearchIterative(int[] arr, int searchNumber)
        {
            int left = 0;
            int right = arr.Length - 1;

            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                switch (Compare(arr[middle], searchNumber))
                {
                    //Based on the resutls of the Comparison method continues or is identified
                    case -1: left = middle + 1; break;
                    case 0: return middle;
                    case 1: right = middle - 1; break;
                }
            }
            return -1;
        }
        //Binary Search done recursively make repeat method calls with changing bounds
        public int BinarySearchRecursive(int[] arr, int searchnum, int left, int right)
        {
            int middle;
            while (left <= right)
            {
                //Middle is the element in the process
                middle = (left + right) / 2;

                switch (Compare(arr[middle], searchnum))
                {                
                    //Based on the resutls of the Comparison method to remake the method call or finish the process
                    case -1: return BinarySearchRecursive(arr, searchnum, middle + 1, right);
                    case 0: return middle;
                    case 1: return BinarySearchRecursive(arr, searchnum, left, middle - 1);
                }
            }
            return -1;
        }
        //This will simply compare the value in question with the value it actually is
        private int Compare(int x, int y)
        {
            return x < y ? -1 : (y < x ? 1 : 0);
        }
    //function binary_search(A, n, T) is
    //L := 0
    //R := n − 1
    //while L ≤ R do
    //    m := floor((L + R) / 2)
    //    if A[m] < T then
    //        L := m + 1
    //    else if A[m] > T then
    //        R := m − 1
    //    else:
    //        return m
    //return unsuccessful
    }
}
