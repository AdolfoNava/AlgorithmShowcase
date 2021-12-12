using System;
using QuickSortConsoleApp;

namespace TreeSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is for obtaining the dataset I will be using for the project
            QuickSorter quickSorter = new QuickSorter();

            //The main class for the app that makes a massive amount of node objects that are within a tree.
            BinaryTreeSystem binaryTreeSystem = new BinaryTreeSystem(quickSorter.csvManip.intValues);
            //These method calls are varying methods of showing the collection of nodes
            
            //binaryTreeSystem.PostOrderRec(binaryTreeSystem.root);
            // InOrder goes from left side -> root -> right
            //binaryTreeSystem.InOrderRec(binaryTreeSystem.root);
            // PreOrder goes from root -> left -> right
            binaryTreeSystem.PreOrderRec(binaryTreeSystem.root);

        }
    }
}
