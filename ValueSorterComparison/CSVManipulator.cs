using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ValueSorterComparison
{
    public class CSVManipulator
    {
        public string[] file1content;
        public int[] intValues;
        public string path;
        public string FiletoCall;
        public string newFileName;
        public CSVManipulator()
        {
            //As my build is through debug for testing path will lead to a dead end which is why the full address of the files
            //is $"{path}\\..\\..\\..\\csvfiles\\values1.csv" because it can be very flexible
            this.path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            FiletoCall = "HardestRandomValues";
            newFileName = "NewFile";
            

        }
        public void Readfile()
        {
            //This locates the exact location of the csvfiles folder and get the individual file for the analysis as well as ALL of its contents
            file1content = System.IO.File.ReadAllLines($"{path}\\..\\..\\..\\csvfiles\\{FiletoCall}.csv");
            //This covers rowdata in this case its only one row
            for(int i = 0;i < file1content.Length; i++)
            {
                //since this is a csv files the numbers are seperated by well a comma for each value
                var Splitcomma = file1content[i].Split(',');
                //starts to initalize the int array count before input the numbers in itself
                intValues = new int[Splitcomma.Length];
                for (int j = 0; j < Splitcomma.Length; j++)
                {
                    //To check the file if its a number value like 123412 or not
                    try
                    {
                        
                        int value = Convert.ToInt32(Splitcomma[j]);
                        //after converting the value transfer the value onto the array
                        intValues[j] = value;
                    }
                    catch
                    {
                        //Display to the user the potential loss of information without shutting down the whole app
                        Console.WriteLine($"Failed to convert {Splitcomma[j]} into a int value");

                    }
                }
            }
        }
        public void MakeCSV(int[] finishedvalues)
        {                
            //This will make sure that old file doesn't get stacked information from previous builds and/or different csv content
            File.Delete($"{path}\\..\\..\\..\\csvfiles\\Created.csv");
            using (StreamWriter sw = File.AppendText($"{path}\\..\\..\\..\\csvfiles\\{newFileName}.csv"))
            {
                //this loop will ensure that every value gets into a new file while converting the single row file into a single column 
                foreach(int number in finishedvalues)
                {
                    sw.WriteLine(number);
                }

            }
        }
    }        
}
