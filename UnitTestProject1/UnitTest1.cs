using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseABinaryTree;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddBaseNode()
        {
            Node BaseNode = new Node(2);
            BinaryTree BT = new BinaryTree(BaseNode);

            Assert.AreEqual(BaseNode, BT.RootNode);
        }

        [TestMethod]
        public void AddBaseNodeAndLeftNode()
        {
            Node BaseNode = new Node(2);
            Node LeftNode = new Node(1);

            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(LeftNode);

            Assert.AreEqual(LeftNode, BT.RootNode.LeftNode);
        }

        [TestMethod]
        public void AddBaseNodeAndRightNode()
        {
            Node BaseNode = new Node(2);
            Node RightNode = new Node(3);

            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(RightNode);

            Assert.AreEqual(RightNode, BT.RootNode.RightNode);
        }

        [TestMethod]
        public void AddBaseNodeAndTwoRightNodes()
        {
            Node BaseNode = new Node(2);
            Node RightNode = new Node(3);
            Node SecondRightNode = new Node(4);

            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(RightNode);
            BT.AddNode(SecondRightNode);
            Assert.AreEqual(SecondRightNode, BT.RootNode.RightNode.RightNode);
        }

    }
}
