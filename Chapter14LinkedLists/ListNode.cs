using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.Chapter14LinkedLists
{
    public class ListNode
    {
        public string Data { get; private set; }
        public ListNode NextNode { get; set; }

        public ListNode(string data)
        {
            Data = data;
        }
    }
}
