namespace CommonSenseGuideDataStructuresAlgorithms.BinarySearchTrees
{
    public class BstNode
    {

        public BstNode(int data)
        {
            this.Data = data;
        }

        public BstNode RightNode { get; set; }
        public BstNode LeftNode { get; set; }
        public int Data { get; set; }
    }
}