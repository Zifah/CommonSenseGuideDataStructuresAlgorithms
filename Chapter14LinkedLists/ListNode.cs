using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.Chapter14LinkedLists
{
    public class ListNode
    {
        public virtual  string Data { get; private set; }
        public virtual ListNode NextNode { get; set; }

        public ListNode(string data)
        {
            Data = data;
        }
    }
}
