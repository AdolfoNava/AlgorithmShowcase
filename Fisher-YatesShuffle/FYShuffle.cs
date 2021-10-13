using System;
using System.Collections.Generic;
using System.Text;

namespace Fisher_YatesShuffle
{
    public static class FYShuffle
    {
        
        public static Random random = new Random();

        public static void DoFisherYatesShuffle(this object[] objects)
        {
            //The loop is to ensure that every word gets the potential to change around
            for (int i = objects.Length - 1; i > 0; i--)
            {
                //Seperated the methods on the reasoning that they are
                //intended to do only one thing exactly

                int j = GetRandomInt(i);
                objects.SwapArrayElements( i, j);
                //object temp = objects[i];
                //objects[i] = objects[j];
                //objects[j] = temp;
            }
        }
        //This functions the same way as DoFisherYatesShuffle but works backwards with the same effect
        public static void DoFisherYatesInverseShuffle(this object[] objects)
        {
            //The loop is to ensure that every word gets the potential to change around
            for (int i = 0; i<objects.Length - 2; i++)
            {
                //Seperated the methods on the reasoning that they are
                //intended to do only one thing exactly

                int j = GetRandomInt((objects.Length - i)-1);
                objects.SwapArrayElements(i, i+j);

            }
        }
        //This just makes sure a new random value is created for the
        //Swap method each time it get called
        private static int GetRandomInt(int i)
        {
            return random.Next(i + 1);
        }
    }
}
