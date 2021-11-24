using System;
using System.Collections.Generic;
using System.Text;

namespace ValueSorterComparison
{

    //Below the class is the pseudocode of the entire process

    //This algorithm's best case is O(n)
    //This algorithm's worse case is O(n^2)
    class InsertionSorter
    {
        public int[] Collectedvalues;
        public InsertionSorter(int[] array)
        {
            Collectedvalues = array;
            InsertionSort(Collectedvalues);
            foreach (int i in Collectedvalues)
            {
                Console.WriteLine(i);
                Console.ReadKey(true);
            }
        }
        private void InsertionSort(int[] unsortedcollection)
        {
            int val;
            for (int i = 1; i < unsortedcollection.Length; i++)
            {
                val = unsortedcollection[i];
                for (int j = i - 1; j >= 0;)
                {
                    if (val < unsortedcollection[j])
                    {
                        unsortedcollection[j + 1] = unsortedcollection[j];
                        j--;
                        unsortedcollection[j + 1] = val;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        //Insertionsort(Data: values[])
   //For i = 0 To<length of values> - 1
       /// Move item i into position
       ///in the sorted part of the array
       //< Find the first index j where
         //j<i and values[j]> values[i].>
       //<Move the item into position j.>
   //Next i
//End Insertionsort
    }
}
