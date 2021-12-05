using System;
using System.Collections.Generic;
using System.Text;

namespace BasicSearchingAlgorithm
{

    /// <summary>
    /// Goes through the array in element order to identify its location
    /// Worst Case O(n)
    /// Best Case O(1)
    /// </summary>
    //Below the class is the pseudocode of the process
    class LinearSearching
    {
        public LinearSearching()
        {

        }
        public int LinearSearcher(int[] arr, int searchNumber)
        {
            arr[arr.Length - 1] = searchNumber;

            int i;
            //Simplest search system keeps going until the search value is the same as element
            for (i = 0; arr[i] != searchNumber; i++);
            return (i < arr.Length - 1) ? i : -1;
        }
//Begin
//1) Set i = 0
//2) If Li = T, go to line 4
//3) Increase i by 1 and go to line 2
//4) If i<n then return i
//End
    }
}
