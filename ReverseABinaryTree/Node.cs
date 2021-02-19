using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseABinaryTree
{
    public class Node
    {

        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }

        public Node (int Data)
        {
            this.Data = Data;
        }

    }
}
