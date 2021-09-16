using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class Program
    {
        //This is week one demonstration of various simple BigO functions in c# since this is very abstract in nature
        //using example paints a strong picture of what we are trying to do
        
        static void Main(string[] args)
        { 
            //For the sake of the demonstration everything about simple BigONotation will be kept here in the same file
            int[] collection = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
            
            //Just calling all the methods for the demo
            ConstantBigOExample(collection);

            LinearBigOExample(collection);

            QuadraticBigOExample(collection);
            Console.ReadKey(true);


            //Constant in this example means that it'll only perform the action a pre designed amount of times and therefore
            //can not be used for scalable databases or searching for stored variables in a collection because it requires manual adjustment each time

                void ConstantBigOExample(int[] example)
            {
                Console.WriteLine("Constant BigO example 'O1':");
                //Here the method will only run once and only for the first object in the array

                Console.WriteLine(example[0]);
                //output: 0
            }        


            //Linear in this example means that this a function that will go through every element of an array or list in the method
            //This is a simple system if you want involve every element in a set order 
                void LinearBigOExample(int[] example)
            {
                Console.WriteLine("Linear BigO example 'n':");
                //The foreach loop goes through every element
                foreach(var item in example)
                {
                Console.WriteLine(item);
                    //output:
                    //0
                    //1
                    //2
                    //3
                    //4
                    //5
                    //6
                    //7
                    //8
                    //9
                    //10
                    //11
                    //12
                    //13
                    //14
                    //15
                    //16
                    //17
                    //18
                    //19
                }
            }

            //Quadratic
                void QuadraticBigOExample(int[] example)
            {
                //This is a nested loop that uses the same array/list foreach loop to display elements in outer loop first and the inner loop could either be direct nested
                //or made into a different type of loop entirely depending on what is it that you need at the moment.
                Console.WriteLine("Quadratic BigO example 'n^2':");
                foreach (var item1 in example)
                {
                    foreach (var item2 in example)
                    {
                    Console.WriteLine($"This is item1 {item1} and this is item2 {item2}");
                    }
                    //output:
                    //This is item1 0 and this is item2 0
                    //This is item1 0 and this is item2 1
                    //This is item1 0 and this is item2 2
                    //etc.
                }
            }
        }




    }
}
