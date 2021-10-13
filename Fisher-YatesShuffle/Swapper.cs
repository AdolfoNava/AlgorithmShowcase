using System;
using System.Collections.Generic;
using System.Text;

namespace Fisher_YatesShuffle
{
    public static class Swapper
    {
        //This is where the magic of the Fisher Yates Shuffle takes place
        //moving elements of an array or list around randomly is decending range of the value location
        public static void SwapArrayElements(this object[] objects,int i, int j)
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}
