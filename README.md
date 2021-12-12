# AlgorithmShowcase
This is my collection of various demonstrations of algorithm systems as well my explantions as to what I have been working on. All algorithm demonstrations are in c# only and will be expanded based on what I was taught. All naming conventions in the repository will be clear and exact as to what I am doing in my comments as well as the methods variable names is concerned.

Example: 
```csharp
//Constant in this example means that it'll only perform the action a pre designed amount of times and therefore
//can not be used for scalable databases or searching for stored variables in a collection because it requires manual 
//adjustment each time

      void ConstantBigOExample(int[] example)
          {
                Console.WriteLine("Constant BigO example 'O1':");
          //Here the method will only run once and only for the first object in the array

                Console.WriteLine(example[0]);
          //output: 0
          }     
```
## Table of Contents
Week 1: Simple BigO notation https://github.com/AdolfoNava/AlgorithmShowcase/blob/f9f9a66c9b05c2048d26a1f6618a459891980325/SimpleAlgorithms/Program.cs

Made in .NetFramework 4.7.2

Week 2: Quicksort example with csv file read and writer https://github.com/AdolfoNava/AlgorithmShowcase/blob/master/QuickSortConsoleApp/QuickSorter.cs

Made in .NetCore 3.1 

week 3: Fisher-Yates Shuffle Implementation https://github.com/AdolfoNava/AlgorithmShowcase/tree/master/Fisher-YatesShuffle

week 3 cont: JSONQuickSort verison https://github.com/AdolfoNava/AlgorithmShowcase/tree/master/JSONObjectQuickSort

week 4: Simple Data Structure with comparison and contrast https://github.com/AdolfoNava/AlgorithmShowcase/tree/master/SimpleDataStructures

week 5: Data Sorting Comparisons https://github.com/AdolfoNava/AlgorithmShowcase/tree/master/ValueSorterComparison

week 6: Basic Data Searching Algorithm https://github.com/AdolfoNava/AlgorithmShowcase/tree/master/BasicSearchingAlgorithm

etc.

## Resources
Developed in VS 2019 Community build 16.11.2 C# Console App .NetFramework 4.7.2 and .NetCore 3.1

For Week 2 I looked up a c# quicksort algorithmn implementation on youtube went to this video and combined with my prior project before this class with a csv file read and write program https://youtu.be/wygsfgtpApI

For Week 3 I used Daniel knights 2 part demonstration of the algorithmn in action as the basis for the app and is more flexible than last week's work https://youtu.be/H5LGwDanx2

For the reading the json files install Newtonsoft.Json 13.0.1

To be updated if there is pre-requisite items outside of the git repository 

