using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.BinarySearchTrees
{
    public class BinarySearchTree
    {
        public BstNode RootNode { get; }

        public BinarySearchTree(int data)
        {
            RootNode = new BstNode(data);
        }

        public void Insert(int data)
        {
             Insert(data, RootNode);
        }

        private BstNode Insert(int data, BstNode theNode)
        {
            if(theNode == null)
            {
                return new BstNode(data);
            }

            if(data < theNode.Data)
            {
                theNode.LeftNode = Insert(data, theNode.LeftNode);
            }
            else
            {
                theNode.RightNode = Insert(data, theNode.RightNode);
            }
            return theNode;
        }

        public BstNode FindLargest_Ex_15_3()
        {
            return FindLargest(RootNode);
        }

        private BstNode FindLargest(BstNode rootNode = null)
        {
            if(rootNode != null)
            {
                if(rootNode.RightNode == null)
                {
                    return rootNode;
                }
                return FindLargest(rootNode.RightNode);
            }
            return null;
        }
    }
}
