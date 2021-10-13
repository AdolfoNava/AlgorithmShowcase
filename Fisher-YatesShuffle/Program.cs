using System;

namespace Fisher_YatesShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader fr = new FileReader();
            //This is for when for whatever reason you want to inverse the same action
            //of randomizing elements of the array

            //Doing both at the same instance of running the app will result in
            //the same intended outcome of shuffling the elements
            
            //FYShuffle.DoFisherYatesShuffle(fr.SeperatedWords);
            FYShuffle.DoFisherYatesInverseShuffle(fr.SeperatedWords);
            foreach(string word in fr.SeperatedWords)
            {
                Console.Write(word+" ");
                Console.ReadKey(true);
            }
            fr.WriteNewFile(fr.SeperatedWords);
        }
    }
}
