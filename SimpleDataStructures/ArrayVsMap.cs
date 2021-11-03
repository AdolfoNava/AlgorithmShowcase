using System;
using System.Collections.Generic;
using System.Text;
using CsvReadCollections;

namespace SimpleDataStructures
{
    ///<summary>
    ///This is for the compare and contrast between arrays and map
    ///in this situation of using C# 
    ///this demonstration will be in a dictionary instead of a map
    ///</summary>
    public class ArrayVsMap
    {
        CSVManipulator CSVManipulator;
        public int[] intValues;
        public Dictionary<string, int> keyWithValues;
        public string[] keyNames;

        public ArrayVsMap()
        {
            //Obtained this from an older project in this c# solution
            CSVManipulator = new CSVManipulator();
            CSVManipulator.FiletoCall = "valuesRANDOM";
            intValues = new int[100];
            keyWithValues = new Dictionary<string, int>();

            //These will be the names of the keys within the dictionary for the demonstration
            keyNames = new string[10] 
            {"First","Second","Third","Fourth","Fifth","Sixth","Seventh","Eighth","Ninth","Tenth"};
            CSVManipulator.Readfile();
        }
        /// <summary>
        /// Method to demonstrate the array data structure collection
        /// Array is a specified quatity of objects that is inheritly organized
        /// where each indexed variable can be called, or changed at any point
        /// </summary>
        public void ToShowArrayDemonstration()
        {
            //Content in the csv file is now stored in a int array object
            for (int i = 0; i < CSVManipulator.intValues.Length; i++)
            {
                intValues[i] = CSVManipulator.intValues[i];
            }
            Console.WriteLine("Displays the array in order inserted");
            foreach(int i in intValues)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Method to demonstrate the Map data structure collection
        /// A map is a dynamic collection of objects that is intended to be paired with 
        /// "keys" that are intended to be unique to the values associated with them
        /// they are intended to be accessesed, and changed dynamically
        /// </summary>
        public void ToShowMapDemonstration()
        {
            var name = "";
            //Content in the csv file is now stored in the Dictionary(map) string = key int = values object
            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        name = keyNames[0];
                        break;
                    case 1:
                        name = keyNames[1];
                        break;
                    case 2:
                        name = keyNames[2];
                        break;
                    case 3:
                        name = keyNames[3];
                        break;
                    case 4:
                        name = keyNames[4];
                        break;
                    case 5:
                        name = keyNames[5];
                        break;
                    case 6:
                        name = keyNames[6];
                        break;
                    case 7:
                        name = keyNames[7];
                        break;
                    case 8:
                        name = keyNames[8];
                        break;
                    case 9:
                        name = keyNames[9];
                        break;
                    default:
                        break;
                }
                keyWithValues.Add(name, CSVManipulator.intValues[i]);
            }
            Console.WriteLine("Now will be displaying dictionary(map) pairs");
            //This is for displaying the values with their individual key
            foreach(KeyValuePair<string,int> pairs in keyWithValues)
            {
                Console.WriteLine(@$"Key: {pairs.Key}
Value: {pairs.Value}
");
            }
        }
    }
}
