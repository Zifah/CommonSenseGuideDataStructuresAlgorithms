using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.Chapter14LinkedLists
{
    public class ExerciseTests
    {
        private static LinkedList GetLinkedList()
        {
            var firstNode = new ListNode("Hafiz");
            var linkedList = new LinkedList(firstNode);
            linkedList.Append("Eats");
            linkedList.Append("Lots");
            linkedList.Append("Of");
            linkedList.Append("Icecream");
            return linkedList;
        }

        public static void TestLinkedListPrintElements()
        {
            // Create a linked list with three nodes
            var linkedList = GetLinkedList();

            // Create a print method
            Action<string> printAction = (string data) => { Console.WriteLine(data); };

            // Pass this linked list to the new method
            linkedList.PrintElements_Ex14_1(printAction);

            // Observe what gets printed out
        }

        public static void TestDoublyLinkedListPrintElementsInReverse()
        {
            // Create a linked list with three nodes
            var linkedList = new DoublyLinkedList();

            linkedList.InsertAtEnd("Hafiz");
            linkedList.InsertAtEnd("Eats");
            linkedList.InsertAtEnd("Lots");
            linkedList.InsertAtEnd("Of");
            linkedList.InsertAtEnd("Icecream");

            // Create a print method
            Action<string> printAction = (string data) => { Console.WriteLine(data); };

            // Pass this linked list to the new method
            linkedList.PrintElementInReverse_Ex14_2(printAction);

            // Observe what gets printed out
        }

        public static ListNode TestGetLinkedLastItem()
        {
            // Create a linked list with three nodes
            var firstNode = new ListNode("Hafiz");
            var linkedList = new LinkedList(firstNode);
            linkedList.Append("Eats");
            linkedList.Append("Lots");
            linkedList.Append("Of");
            linkedList.Append("Icecream");

            // Pass this linked list to the new method
            return linkedList.GetLastItem_Ex14_3();
        }

        public static void TestReverseLinkedList()
        {
            var linkedList = GetLinkedList();
            linkedList.ReverseList_Ex14_4();
            linkedList.PrintElements_Ex14_1((string data) => Console.WriteLine(data));
        }

        public static void DeleteDetachedNodeFromLinkedList_Ex14_5()
        {
            /**
             * With no reference to the object whose next node is the detached node,
             * We want to make that object point to the node after the detached one
             * Effectively deleting detached from the linkedList
             */

            /**
             * One idea that occurred to me it to copy the values from the subsequent nodes backward
             * And then detach the final node from the list
             * And I have implemented this below. It works, except for if the detachedNode is the last item in the list
             * The question says the detached node would be pulled from somewhere in the middle of a list anyway
             * So, for now, we shall work with that
             * Goo Job!
             */
            var linkedList = GetLinkedList();
            var detachedNode = linkedList.Read(1);
            var currentNode = detachedNode;

            while(currentNode.NextNode != null)
            {
                currentNode.Data = currentNode.NextNode.Data;
                if(currentNode.NextNode.NextNode == null)
                {
                    currentNode.NextNode = null;
                    break;
                }
                currentNode = currentNode.NextNode;
            }

            linkedList.PrintElements_Ex14_1((string data) => Console.WriteLine(data));
        }
    }
}
