using System;
using System.Collections.Generic;
using System.Text;

namespace TreeSystems
{
    /// <summary>
    /// This is the main class for the project thats all
    /// about tree system using a binary setup to talk
    /// about it.
    /// </summary>
    public class BinaryTreeSystem
    {
        //The root is the start of the entire tree and
        //will make branches by the order of the InsertRec() method 
        public Node root { get; private set; }
        //The class constructor will take in the array collection and focus
        //solely on the implementation of the tree straight away
        public BinaryTreeSystem(int[] Dataset)
        {
            root = null;
            foreach(int i in Dataset)
            {
                Insert(i);
            }
        }
        //This method is where all values start in the tree assembly process
        public void Insert(int dataValue)
        {
            if (root == null)
            {
                root = new Node(dataValue);
                return;
            }
            InsertRec(root, new Node(dataValue));
        }
        //The values will be displayed recursively due to the nature
        //of binary tree its either 1 or a 0 naturally
        private void InsertRec(Node root, Node newNode)
        {
            //Implementation of this ensures to identify when its the start of a new branch
            if (root == null)
                root = newNode;

            //This will spread the tree further to the left side
            if (newNode.Data < root.Data)
            {
                if (root.LeftNode == null)
                    root.LeftNode = newNode;
                else
                    InsertRec(root.LeftNode, newNode);
            }
            //This will spread the further to the right side
            else
            {
                if (root.RightNode == null)
                    root.RightNode = newNode;
                else
                    InsertRec(root.RightNode, newNode);
            }
        }
        //These three methods below are all about display
        //the node information in different orders
        public void PostOrderRec(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree
            PostOrderRec(node.LeftNode);

            // then recur on right subtree
            PostOrderRec(node.RightNode);

            // now deal with the node
            Console.WriteLine(node.Data);
        }

        public void PreOrderRec(Node node)
        {
            if (node != null)
            { 
                //first deal with the node
                Console.WriteLine(root.Data);
                //then deal with the left side
                PreOrderRec(root.LeftNode);
                //finish with the right side
                PreOrderRec(root.RightNode);
            }
        }
        public void InOrderRec(Node root)
        {
            if (root != null)
            {
                //first deal with the left side
                InOrderRec(root.LeftNode);
                //Next write down the node value
                Console.WriteLine(root.Data);
                //lastly finish with the right side
                InOrderRec(root.RightNode);
            }
        }
    }
}
