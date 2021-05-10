using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.Chapter14LinkedLists
{
    public class DoublyLinkedList : LinkedList
    {
        public ListNode LastNode { get; set; }

        public DoublyLinkedList(DoubleFacedNode firstNode = null, DoubleFacedNode lastNode = null) : base(firstNode)
        {
            LastNode = lastNode;
        }

        public void InsertAtEnd(string data)
        {
            var newNode = new DoubleFacedNode(data);

            // If there are no elements yet in the linked list:
            if (FirstNode == null)
            {
                FirstNode = newNode;
                LastNode = newNode;
            }
            else //If the linked list already has at least one node:
            {
                newNode.PreviousNode = LastNode;
                LastNode.NextNode = newNode;
                LastNode = newNode;
            }
        }
    }
}
