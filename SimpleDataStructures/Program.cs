using System;

namespace SimpleDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {   //This is for the Stack Vs Queue comparison
            StackVsQueue stackVsQueue = new StackVsQueue();
            stackVsQueue.ToStack();
            stackVsQueue.ToQueue();
            //This is for the Array Vs Map comparison
            //ArrayVsMap arrayVsMap = new ArrayVsMap();
            //arrayVsMap.ToShowArrayDemonstration();
            //arrayVsMap.ToShowMapDemonstration();
            Console.ReadKey(true);
        }
    }
}
