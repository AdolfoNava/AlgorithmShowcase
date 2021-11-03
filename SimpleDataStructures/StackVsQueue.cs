using System;
using System.Collections.Generic;
using System.Text;
using CsvReadCollections;

namespace SimpleDataStructures
{
    //This is for the comparison between Stacks vs Queues
    public class StackVsQueue
    {
        //Obtained this from an older project in this c# solution
        CSVManipulator CSVManipulator;
        Stack<int> stackCollection;
        Queue<int> queueCollection;
        public StackVsQueue()
        {
            CSVManipulator = new CSVManipulator();
            CSVManipulator.FiletoCall = "valuesRANDOM";
            stackCollection = new Stack<int>();
            queueCollection = new Queue<int>();
            //Calls method for external files to read from for the app
            CSVManipulator.Readfile();
        }

        /// <summary>
        /// Method to demonstrate the queue data structure collection
        /// A Stack is a collection of objects that is intended to collect
        /// a special list where the most recent object inserted in the stack
        /// will be "pushed out"
        /// </summary>
        public void ToStack()
        {
            //Content in the csv file is now stored in a stack object
            foreach (int i in CSVManipulator.intValues)
            {
                stackCollection.Push(i);
            }
            //This will display the values that will soon be deleted within the stack object by the most recent object inserted
            while (stackCollection.Count > 0)
            {
                Console.WriteLine(stackCollection.Pop());                
            }
        }
        /// <summary>
        /// Method to demonstrate the queue data structure collection
        /// A queue is a collection of objects that is intended to collect
        /// special list where the intended purpose is to be deleted after
        /// being Dequeued
        /// </summary>
        public void ToQueue()
        {
            //Content in the csv file is now stored in a queue object
            foreach(int i in CSVManipulator.intValues)
            {
                queueCollection.Enqueue(i);
                
                
            }
            Console.WriteLine("Demonstration of values coming out of the queue by ");
            //This will display the values that will soon be deleted within the queue object by the earliest object inserted
            while(queueCollection.Count>0)
            {
                Console.WriteLine(queueCollection.Dequeue());
            }
        }
    }
}
