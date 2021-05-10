using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.Chapter14LinkedLists
{
    public class DoubleFacedNode : ListNode
    {
        public ListNode PreviousNode { get; set; }

        public DoubleFacedNode(string data) : base(data)
        {
        }
    }
}
