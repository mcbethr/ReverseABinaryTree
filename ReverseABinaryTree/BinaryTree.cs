using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseABinaryTree
{
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

        private void CompareData (Node NodeToAdd, Node NodeToCompare)
        {
            if (NodeToAdd.Data < NodeToCompare.Data)
            {
                if (NodeToCompare.LeftNode == null)
                {
                    NodeToCompare.LeftNode = NodeToAdd;
                }
                else
                {
                    CompareData(NodeToAdd, NodeToCompare.LeftNode);
                }
            }
            else
            {
                if (NodeToCompare.RightNode == null)
                {
                    NodeToCompare.RightNode = NodeToAdd;
                }
                else
                {
                    CompareData(NodeToAdd, NodeToCompare.RightNode);
                }
            }
        }



    }



}
