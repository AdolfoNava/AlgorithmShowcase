using System;
using System.Collections.Generic;
using System.Text;

namespace TreeSystems
{
   /// <summary>
   /// Node class is the class object that
   /// will be created many times over the duration of the application
   /// </summary>
    public class Node
    {
        //This is the value taken from the external file
        public int Data { get; set; }
        //Right node is self explanatory when you go to the BinaryTreeSystem class
        public Node RightNode { get; set; }
        //Left node is self explanatory when you go to the BinaryTreeSystem class
        public Node LeftNode { get; set; }
        //These two constructors are for the different stages in the application start and the middle 
        public Node()
        {

        }
        
        public Node(int data)
        {
            Data = data;
        }
    }
    
}
