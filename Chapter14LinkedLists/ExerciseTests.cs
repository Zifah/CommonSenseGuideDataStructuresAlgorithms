using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.Chapter14LinkedLists
{
    public class ExerciseTests
    {
        public static void TestLinkedListPrintElements()
        {
            // Create a linked list with three nodes
            var firstNode = new ListNode("Hafiz");
            var linkedList = new LinkedList(firstNode);
            linkedList.Append("Eats");
            linkedList.Append("Lots");
            linkedList.Append("Of");
            linkedList.Append("Icecream");

            // Create a print method
            Action<string> printAction = (string data) => { Console.WriteLine(data); };

            // Pass this linked list to the new method
            linkedList.PrintElements_Ex14_1(printAction);

            // Observe what gets printed out
        }
    }
}
