using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseABinaryTree;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddBaseNode()
        {
            //Should look like:
            //           2
            Node BaseNode = new Node(2);
            BinaryTree BT = new BinaryTree(BaseNode);

            Assert.AreEqual(BaseNode, BT.RootNode);
        }

        [TestMethod]
        public void TestAddBaseNodeAndLeftNode()
        {
            /// Should look like
            ///       2
            ///      /  
            ///     1
            Node BaseNode = new Node(2);
            Node LeftNode = new Node(1);

            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(LeftNode);

            Assert.AreEqual(LeftNode, BT.RootNode.LeftNode);
        }
        [TestMethod]
        public void TestAddBaseNodeAndLeftNodeReverse()
        {
            /// Should look like to 
            ///       2                   2
            ///      /                     \
            ///     1                        1
            Node BaseNode = new Node(2);
            Node LeftNode = new Node(1);

            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(LeftNode);
            BT.Reverse(BaseNode);

            Assert.AreEqual(LeftNode, BT.RootNode.RightNode);
        }

        [TestMethod]
        public void TestAddBaseNodeAndRightNode()
        {
            /// Should look like  
            ///       2                   
            ///        \                     
            ///        3                     

            Node BaseNode = new Node(2);
            Node RightNode = new Node(3);

            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(RightNode);

            Assert.AreEqual(RightNode, BT.RootNode.RightNode);
        }

        [TestMethod]
        public void TestAddBaseNodeAndTwoRightNodes()
        {
            /// Should look like  
            ///       2                   
            ///        \                     
            ///         3  
            ///          \
            ///           4
            Node BaseNode = new Node(2);
            Node RightNode = new Node(3);
            Node SecondRightNode = new Node(4);

            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(RightNode);
            BT.AddNode(SecondRightNode);
            Assert.AreEqual(SecondRightNode, BT.RootNode.RightNode.RightNode);
        }

        [TestMethod]
        public void TestSwapNodes()
        {
            ///Should look like to
            //      2                  2
            //     / \                / \
            //    1   3              3   1
            Node BaseNode = new Node(2);
            Node RightNode = new Node(3);
            Node LeftNode = new Node(1);

            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(BaseNode);
            BT.AddNode(RightNode);
            BT.AddNode(LeftNode);

            BT.SwapNodes(BaseNode);

            Assert.AreEqual(LeftNode, BaseNode.RightNode);
            Assert.AreEqual(RightNode, BaseNode.LeftNode);

        }

        [TestMethod]
        public void TreeFourNodesBranchingFromLeft()
        {
            //Should look like
            //        4
            //       /
            //      2
            //     / \
            //    1   3

            Node BaseNode = new Node(4);
            Node LeftChildBaseNode = new Node(2);
            Node LeftChildNodeFromBaseNode = new Node(1);
            Node RightChildNodeFromBaseNode = new Node(3);


            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(BaseNode);
            BT.AddNode(LeftChildBaseNode);
            BT.AddNode(LeftChildNodeFromBaseNode);
            BT.AddNode(RightChildNodeFromBaseNode);

            Assert.AreEqual(RightChildNodeFromBaseNode, BaseNode.LeftNode.RightNode);
        }

        [TestMethod]
        public void ReverseTreeFourNodesBranchingFromLeft()
        {
            //Should look like goes to: 
            //        4            4 
            //       /              \
            //      2                2
            //     / \              / \
            //    1   3            3   1

            Node BaseNode = new Node(4);
            Node LeftChildBaseNode = new Node(2);
            Node LeftChildNodeFromBaseNode = new Node(1);
            Node RightChildNodeFromBaseNode = new Node(3);


            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(BaseNode);
            BT.AddNode(LeftChildBaseNode);
            BT.AddNode(LeftChildNodeFromBaseNode);
            BT.AddNode(RightChildNodeFromBaseNode);

            BT.Reverse(BaseNode);

            Assert.AreEqual(LeftChildNodeFromBaseNode, BaseNode.RightNode.RightNode);
        }

        [TestMethod]
        public void ReverseTreePartialFullNodesBranchingFromLeftAndRight()
        {
            //Should look like goes to: 
            //          4                       4             
            //       /     \                 /     \          
            //      2       7               7       2        
            //     / \                            /   \ 
            //    1   3                          3     1

            Node BaseNode = new Node(4);
            Node LeftChildBaseNode = new Node(2);
            Node RightChildBaseNode = new Node(7);
            Node LeftChildNodeFromBaseNode = new Node(1);
            Node RightChildNodeFromBaseNode = new Node(3);


            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(BaseNode);
            BT.AddNode(LeftChildBaseNode);
            BT.AddNode(RightChildBaseNode);
            BT.AddNode(LeftChildNodeFromBaseNode);
            BT.AddNode(RightChildNodeFromBaseNode);

            BT.Reverse(BaseNode);

            Assert.AreEqual(RightChildBaseNode, BaseNode.LeftNode);
            Assert.AreEqual(LeftChildNodeFromBaseNode, BaseNode.RightNode.RightNode);
        }
        [TestMethod]
        public void ReverseTreeFullNodesBranchingFromLeftAndRight()
        {
            //Should look like goes to: 
            //          4                       4             
            //       /     \                 /     \          
            //      2       7               7       2        
            //     / \    /   \            / \    /   \ 
            //    1   3  5     6          6   5  3     1

            Node BaseNode = new Node(4);
            Node LeftChildBaseNode = new Node(2);
            Node RightChildBaseNode = new Node(6);
            Node LeftLeftChildNodeFromBaseNode = new Node(1);
            Node LeftRightChildNodeFromBaseNode = new Node(3);
            Node RightLeftChildNodeFromBaseNode = new Node(5);
            Node RightRightChildNodeFromBaseNode = new Node(7);


            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(BaseNode);
            BT.AddNode(LeftChildBaseNode);
            BT.AddNode(RightChildBaseNode);
            BT.AddNode(LeftLeftChildNodeFromBaseNode);
            BT.AddNode(LeftRightChildNodeFromBaseNode);
            BT.AddNode(RightLeftChildNodeFromBaseNode);
            BT.AddNode(RightRightChildNodeFromBaseNode);
     
            BT.Reverse(BaseNode);

            Assert.AreEqual(RightRightChildNodeFromBaseNode, BaseNode.LeftNode.LeftNode);
            Assert.AreEqual(LeftLeftChildNodeFromBaseNode, BaseNode.RightNode.RightNode);
        }

        [TestMethod]
        public void ReverseTreePartialFullNodesBranchingFromLeftAndRightLevel3()
        {
            //Should look like goes to: 
            //          4                       4             
            //       /     \                 /     \          
            //      2       7               7       2        
            //     / \                            /   \ 
            //    1   3                          3     1
            //   /                                      \
            //  0                                        0
            Node BaseNode = new Node(4);
            Node LeftChildBaseNode = new Node(2);
            Node RightChildBaseNode = new Node(7);
            Node LeftChildNodeFromBaseNode = new Node(1);
            Node RightChildNodeFromBaseNode = new Node(3);
            Node LeftChildNodeFromLeftNodeBaseNode = new Node(0);


            BinaryTree BT = new BinaryTree(BaseNode);
            BT.AddNode(BaseNode);
            BT.AddNode(LeftChildBaseNode);
            BT.AddNode(RightChildBaseNode);
            BT.AddNode(LeftChildNodeFromBaseNode);
            BT.AddNode(RightChildNodeFromBaseNode);
            BT.AddNode(LeftChildNodeFromLeftNodeBaseNode);

            BT.Reverse(BaseNode);

            Assert.AreEqual(LeftChildNodeFromLeftNodeBaseNode, BaseNode.RightNode.RightNode.RightNode);

        }


    }

}
