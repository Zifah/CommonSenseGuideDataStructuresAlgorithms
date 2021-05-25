using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSenseGuideDataStructuresAlgorithms.BinarySearchTrees
{
    public class ExerciseTests
    {
        public static void PrintLargestInBST_Ex_15_3()
        {
            var randNumberGenerator = new Random();
            BinarySearchTree theBst = null; 
            // new BinarySearchTree(randNumberGenerator.Next(1, 100));
            for(int i = 0; i < 10; i++)
            {
                var currentData = randNumberGenerator.Next(1, 100);
                if(theBst == null)
                {
                    theBst = new BinarySearchTree(currentData);
                }
                else
                {
                    theBst.Insert(currentData);
                }
                Console.WriteLine($"Added {currentData} to the tree");
            }

            Console.WriteLine(theBst.FindLargest_Ex_15_3().Data);
        }
    }
}
