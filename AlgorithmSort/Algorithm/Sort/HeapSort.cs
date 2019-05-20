using System;
using Algorithm.DataStruct;

namespace AlgorithmSort
{
    public class HeapSort<T> : SortAlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            Heap<T> heap = new Heap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}
