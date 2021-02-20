using System;

namespace ReverseABinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node RootNode = new Node(5);
            BinaryTree BT = new BinaryTree(RootNode);
            
            BT.AddNode(new Node(1));
            BT.AddNode(new Node(4));
            BT.AddNode(new Node(3));
            BT.AddNode(new Node(2));



        }
    }


}
