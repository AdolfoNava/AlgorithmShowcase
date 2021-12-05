using System;
using System.Timers;
using CsvReadCollections;
using QuickSortConsoleApp;
namespace BasicSearchingAlgorithm
{
    class Program
    {               
        //This is to display the time progressed in the app
        public static int Minutes = 0;
        public static int Seconds = 0;
        public static int Tenths = 0;
        public static Timer timer = new Timer(100);
        static void Main(string[] args)
        {            

            //Value to find 288035 which is 2952(2951 in code) out of 10000 total values in the array
            //This app requires an already sorted collection and the quicksorter will do just that
            QuickSorter quickSorter = new QuickSorter();

            //This will be the main variable where every array in the project will read from
            //quickSorter.csvManip.intValues;

            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            //Time to find value was: less than 0.1 seconds
            LinearSearching linearSearching = new LinearSearching();
             if (linearSearching.LinearSearcher(quickSorter.csvManip.intValues, 288035) == 2951)
            {
                Console.WriteLine("Value Found");
            }
            else
            {
                Console.WriteLine("Value Not Found");
            }

            //Time to find value was: less than 0.1 seconds
            BinarySearch binarySearch = new BinarySearch();
            if(binarySearch.BinarySearchIterative(quickSorter.csvManip.intValues, 288035) == 2951)
            {
                Console.WriteLine("Value Found");
            }
            else
            {
                Console.WriteLine("Value Not Found");
            }
            if(binarySearch.BinarySearchRecursive(quickSorter.csvManip.intValues, 288035,0, quickSorter.csvManip.intValues.Length) == 2951)
            {
                Console.WriteLine("Value Found");
            }
            else
            {
                Console.WriteLine("Value Not Found");
            }
            //Time to find value was: less than 0.1 seconds
            InterpolationSearch interpolationSearch = new InterpolationSearch(quickSorter.csvManip.intValues);
            //This would identify which position in the array the value is being located at for debugging
            int v = interpolationSearch.interpolationSearch(quickSorter.csvManip.intValues, 0, quickSorter.csvManip.intValues.Length - 1, 288035);
            if (interpolationSearch.interpolationSearch(quickSorter.csvManip.intValues, 0, quickSorter.csvManip.intValues.Length - 1, 288035) == 2951)
            {
                Console.WriteLine("Value Found");
            }
            else
            {
                Console.WriteLine("Value not Found");
            }
            timer.Stop();
            Console.ReadKey(true);
            //SUMMARY:
            ///So overall my pc app processing was again very fast to identify the differences in 
            ///performance between the three especially since one of my implementations appears to 
            ///not work with the highest array collection for something I couldn't understand. However, 
            ///with all that said I can understand as to why would the linear search systembe the 
            ///slowest because the value in question is already at the mercy of the amount of other
            ///values it has to go through to from the start to whereever it is. Worst case is going
            ///through every value in the collection and there is no other alternative than a single direction.
            ///The other Search algorithms have ways to cut through the collection or at the very least 
            ///ignore a section of code to deal the task dealt with. Interpolation literally narrows 
            ///down the search with each interation and binary search goes with the divide slowly going through to either end
            ///both the recursive and iterative versions.

        }
        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Tenths == 9)
            {
                Tenths = 0;
                if (Seconds == 59)
                {
                    Seconds = 0;
                    Minutes++;
                }
                else
                {
                    Seconds++;
                }

            }
            else
            {
                Tenths++;
            }
            Console.WriteLine($"The Sorting as of right now took {Minutes}:{Seconds}.{Tenths}");
        }
    }
}
