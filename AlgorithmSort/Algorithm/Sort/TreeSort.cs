using System;
using System.Collections.Generic;
using Algorithm.DataStruct;

namespace AlgorithmSort
{
    public class TreeSort<T> : SortAlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            Tree<T> tree = new Tree<T>(Items);
            var sorted = tree.Inorder();
            Items = sorted;
        }
    }
}
