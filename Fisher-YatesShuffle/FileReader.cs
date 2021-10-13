using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using ExtensionMethods;

namespace Fisher_YatesShuffle
{
    public class FileReader
    {
        public static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //File name that could be manipulated whenever there is a new file in the system
        public string FiletoCall;
        public string NewFileName;
        //Extracted text related information
        public string[] FileContent;
        public string ExtractedText;
        //The finalized shuffled words and the count of them in the new array
        public string[] SeperatedWords;
        public int SeperatedCount;
        public FileReader()
        {
            this.FiletoCall = "testtext";
            NewFileName = "NewFile";
            ReadFile();
        }
        //This is relatively the same as the previous file reader but now
        //supposed to used with .txt this time
        public void ReadFile()
        {
            //Collects the file text
            FileContent = File.ReadAllLines($"{path}\\..\\..\\..\\files\\{FiletoCall}.txt");
            ToExtractText(FileContent);
            //Calls from an seperate namespace to determine the word count of the file extracted 
            SeperatedCount=ExtractedText.WordCount();
            //Calls an static method intended to determine the words from each other in the same line
            SeperatedWords = ExtractedText.Split(new char[] { ' ', '.', '?', '!' },
                             StringSplitOptions.RemoveEmptyEntries);
            //Display the word count to the user
            Console.WriteLine(SeperatedCount);

        }
        //Create a new file with the words shuffled
        public void WriteNewFile(string[] finishedarray)
        {
            //This will make sure that old file doesn't get stacked information from previous builds and/or different csv content
            File.Delete($"{path}\\..\\..\\..\\files\\{NewFileName}.txt");
            using (StreamWriter sw = File.AppendText($"{path}\\..\\..\\..\\files\\{NewFileName}.txt"))
            {
                //this loop will ensure that every value gets into a new file while converting the single row file into a single column 
                foreach (string word in finishedarray)
                {
                    sw.Write(word+" ");
                }

            }
        }
        //To caputure seperate lines of text from the file
        private void ToExtractText(string[] filecontent)
        {
            foreach(string line in filecontent)
            {
                ExtractedText += line;
            }
        }
    }
}
