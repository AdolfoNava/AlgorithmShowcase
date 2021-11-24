using System;
using QuickSortConsoleApp;
using System.Timers;
namespace ValueSorterComparison
{
    class Program
    {
        //This is to display the time progressed in the app
        public static int Minutes = 0;
        public static int Seconds = 0;
        public static int Tenths = 0;
        public static Timer timer = new Timer(100);
        static void Main(string[] args)
        {   //For my analysis all the classes will call the same csv collection of 10000 values and
            //display it the time calculated when the first value of the new array gets displayed
            CSVManipulator cSVManipulator = new CSVManipulator();
            cSVManipulator.Readfile();
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            //Time was less than 0.1 seconds
            //QuickSorter quickSorter = new QuickSorter();

            //Time was between .3 seconds and .4
            //BubbleSorter bubbleSorter = new BubbleSorter(cSVManipulator.intValues);

            //Time was less than 0.1 seconds
            //InsertionSorter insertionSorter = new InsertionSorter(cSVManipulator.intValues);

            //Time was less than 0.1 seconds
            //MergeSorter mergeSorter = new MergeSorter(cSVManipulator.intValues);

            //Time was less than 0.1 seconds
            //HeapSorter heapSorter = new HeapSorter(cSVManipulator.intValues);

            //Time was less than 0.1 seconds
            //SelectionSort selectionSort = new SelectionSort(cSVManipulator.intValues);
            timer.Stop();
            Console.ReadKey(true);
            //Overall at least with my attempt of analysis all the values get sorted with the exception of bubble sort under 0.1 seconds with doesn't really
            //identify the better one amongst the rest but each have their own issues with memory allocation in particularly with HeapSort with the amount of times the method gets recalled the adjusted array many times before finalizing it but it still gets dealt with extremely quickly
        }
        //This will be to identify the time it took for the algorithm to be sorted and displayed
        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Tenths == 9)
            {
                Tenths = 0;
                if(Seconds == 59)
                {
                    Seconds = 0;
                    Minutes++;
                }
                else
                {
                    Seconds++;
                }
                
            }
            else {
                Tenths++;
            }
            Console.WriteLine($"The Sorting as of right now took {Minutes}:{Seconds}.{Tenths}");
        }
    }
}
