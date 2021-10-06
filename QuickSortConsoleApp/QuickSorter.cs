using System;
using System.Collections.Generic;
using System.Text;
using CsvReadCollections;

namespace QuickSortConsoleApp
{
    public class QuickSorter
    {
        CSVManipulator csvManip;

        public QuickSorter()
        {
            //All work on the app is here in this cs file I call upon an seperate csv file reader and writer that is made only for this function
            csvManip = new CSVManipulator();
            //gathers the info from the csvfiles folder with the pathing that should work regardless of the project location in the computer so long as the folder is here in the existing project
            csvManip.Readfile();
            //The main function of this particular project is to conduct an Quick sort array where it can call function and be manually adding new sorting functions later on if I so choose to make
            SortArray(csvManip.intValues);
            //This display to the console the numbers that were just sorted through
            foreach(int value in csvManip.intValues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey(true);
            
            csvManip.MakeCSV(csvManip.intValues);
        }
        //This system is to begin the potential sorting of whatever method I wish to call later in the solutino as I bring in new projects and act accordingly
        private static void SortArray(int[] numbers)
        {
            Quicksort(numbers, 0, numbers.Length - 1);
        }
        //The main function of the entire app The Quicksort is the algorithmn at work
        
        private static void Quicksort(int[]numbers, int left,int right)
        {
            //The left and right are the bounds of the function and to re iterate the values
            var i = left;
            var j = right;
            //The main
            var pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                //These are the bounds of the method call and will determine the exact array slot for the transfer to commence
                while (numbers[i] < pivot)
                {
                    i++;
                }
                while (numbers[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {//Begins the transfer of the values around 
                    var tempSpot = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tempSpot;
                    i++;
                    j--;
                }
            }
            //This is to continue the function until there is no more values that are not unsorted in ascending order
            if (left < j)
            {
                Quicksort(numbers, left, j);
            }
            if (i < right)
            {
                Quicksort(numbers, i, right);
            }
        }
    }
}
