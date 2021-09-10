using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseABinaryTree
{
    /*
     * Just follow the algorithm: RE-BESII.

    RE - Write the REverse Method
    B - If both the left node and right node are null, return.
    E - Else
    S - Swap the nodes
    I - If the left node is not null, send the left node to reverse.
    I - If the right node is not null, send the right node to reverse.
    */
    public class BinaryTree
    {
        Node m_RootNode;

        public Node RootNode { get { return m_RootNode; } }

        public BinaryTree(Node BaseNodeData)
        {
            m_RootNode = BaseNodeData;
        }

        public void AddNode(Node NodeToAdd)
        {
            CompareData(NodeToAdd, m_RootNode);
        }

        private void CompareData(Node NodeToAdd, Node RootNode)
        {
            if (NodeToAdd.Data < RootNode.Data)
            {
                if (RootNode.LeftNode == null)
                {
                    RootNode.LeftNode = NodeToAdd;
                }
                else
                {
                    CompareData(NodeToAdd, RootNode.LeftNode);
                }
            }
            else if (NodeToAdd.Data > RootNode.Data)
            {
                if (RootNode.RightNode == null)
                {
                    RootNode.RightNode = NodeToAdd;
                }
                else
                {
                    CompareData(NodeToAdd, RootNode.RightNode);
                }
            }
            else
            {
                ///Handle the case of data being the same
                ///We can do this a few ways like with a counter
            }
        }

        public void SwapNodes(Node NodeToReverse)
        {
            if ((NodeToReverse.LeftNode == null) && (NodeToReverse.RightNode == null))
            {
                return;
            }
            else
            {

                Node TempNode = new Node(NodeToReverse.Data);
                TempNode.LeftNode = NodeToReverse.LeftNode;

                NodeToReverse.LeftNode = NodeToReverse.RightNode;
                NodeToReverse.RightNode = TempNode.LeftNode;

            }


        }

        public void Reverse(Node NodeToReverse)
        {

            if ((NodeToReverse.LeftNode == null) && (NodeToReverse.RightNode == null))
            {
                return;
            }
            else
            {
                SwapNodes(NodeToReverse);
                if (NodeToReverse.LeftNode != null)
                {
                    Reverse(NodeToReverse.LeftNode);
                }
                if (NodeToReverse.RightNode != null)
                {
                    Reverse(NodeToReverse.RightNode);
                }
            }

            return;
        }
    }



}
