using System;
using System.Collections.Generic;
using System.Text;

namespace BasicSearchingAlgorithm

    {
    /// <summary>
    /// Interpolation Search is to segment the search based on rough ideas on where itll be
    /// It will run the best for uniformly distributed values and already being sorted
    /// Best Case O(log log n)
    /// Worst Case O(n)
    /// </summary>
    //Below the class is the pseudocode of the process
    class InterpolationSearch
    {
        public int[] InterpolationSearchArray;
        public InterpolationSearch(int[] array)
        {
            InterpolationSearchArray = array;
        }
        
        public int interpolationSearch(int[] array, int LowBound,
                               int HiBound, int SearchForValue)
        {
            int pos;

            // Since array is sorted, an element present in array must be in range defined by corner
            if (LowBound <= HiBound && SearchForValue >= array[LowBound] &&
                            SearchForValue <= array[HiBound])
            {

                // Probing the position with keeping uniform distribution in mind.
                pos = LowBound + (((HiBound - LowBound) /
            (array[HiBound] - array[LowBound])) * (SearchForValue - array[LowBound]));

                // Condition of target found
                if (array[pos] == SearchForValue)
                    return pos;

                // If x is larger, x is in right sub array
                if (array[pos] < SearchForValue)
                    return interpolationSearch(array, pos + 1, HiBound, SearchForValue);

                // If x is smaller, x is in left sub array
                if (array[pos] > SearchForValue)
                    return interpolationSearch(array, LowBound, pos - 1, SearchForValue);
            }
            //If we get this far the value couldn't be found
            return -1;

            //   Let A   →  array collection 
            //   Let Lo  →  0
            //   Let Mid → -1
            //   Let Hi  →  N - 1

            //   While X does not match
            //      if Lo = Hi OR A[Lo] equals to A[Hi]{
            //         Search Failed}
            //      end if
            //      Let Mid = Lo + ((Hi - Lo) / (A[Hi] - A[Lo])) * (X - A[Lo])
            //      if A[Mid] = X
            //         return mid
            //      else
            //         if A[Mid] < X
            //            Let Lo to Mid+1
            //         else if A[Mid] > X
            //            Let Hi to Mid-1
            //         end if
            //      end if
            //   End While
            //End 
        }
    }
}
