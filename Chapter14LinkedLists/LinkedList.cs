using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.Chapter14LinkedLists
{
    public class LinkedList
    {
        public ListNode FirstNode { get; set; }

        public LinkedList(ListNode firstNode)
        {
            FirstNode = firstNode;
        }

        public ListNode Append(string data)
        {
            var newNode = new ListNode(data);

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
            if(firstNode.NextNode == null)
            {
                return firstNode;
            }
            return GetLastItem(firstNode.NextNode);
        }
    }
}
