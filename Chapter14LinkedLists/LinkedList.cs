using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.Chapter14LinkedLists
{
    public class LinkedList
    {
        public ListNode FirstNode { get; set; }

        public LinkedList()
        {

        }

        public LinkedList(ListNode firstNode)
        {
            FirstNode = firstNode;
        }

        public ListNode Append(string data)
        {
            return Append(new ListNode(data));
        }
        public ListNode Append(ListNode newNode)
        {
            ListNode currentNode = FirstNode;
            bool appended = false;
            do
            {
                if (currentNode.NextNode == null)
                {
                    currentNode.NextNode = newNode;
                    appended = true;
                }
                currentNode = currentNode.NextNode;
            } while (!appended);

            return newNode;
        }

        public ListNode Prepend(string data)
        {
            var newNode = new DoubleFacedNode(data);

            // If there are no elements yet in the linked list:
            if (FirstNode == null)
            {
                FirstNode = newNode;
            }
            else //If the linked list already has at least one node:
            {
                newNode.NextNode = FirstNode;
                FirstNode = newNode;
            }

            return newNode;
        }

        public ListNode Read(int index)
        {
            // We begin at the first node of the list:​
            var currentNode = FirstNode;
            int currentIndex = 0;

            while (currentIndex < index)
            {
                // We keep following the links of each node until we get to the index we're looking for
                currentNode = currentNode.NextNode;
                currentIndex += 1;

                if (currentNode == null) return null;
            }

            return currentNode;
        }

        public void PrintElements_Ex14_1(Action<string> printData)
        {
            ListNode currentNode = FirstNode;
            while (currentNode != null)
            {
                printData(currentNode.Data);
                currentNode = currentNode.NextNode;
            }
        }

        public ListNode GetLastItem_Ex14_3()
        {
            return GetLastItem(FirstNode);
        }

        private ListNode GetLastItem(ListNode firstNode)
        {
            if (firstNode.NextNode == null)
            {
                return firstNode;
            }
            return GetLastItem(firstNode.NextNode);
        }

        public void ReverseList_Ex14_4()
        {
            var tailNode = GetLastItem_Ex14_3();
            var nextToMove = FirstNode.NextNode;
            var originalFirstNode = FirstNode;

            while (FirstNode != tailNode)
            {
                var newNextToMove = nextToMove.NextNode;
                var oldFirstNode = FirstNode;
                FirstNode = nextToMove;
                nextToMove.NextNode = oldFirstNode;
                nextToMove = originalFirstNode.NextNode = newNextToMove;
            }
        }
    }
}
