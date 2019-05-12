using System;
using System.Collections.Generic;

namespace AlgorithmSort
{
    public class BubleSort<T> : SortAlgorithmBase<T> where T : IComparable
    {
        //алгоритм сортировки пузырьком
        public void SortT()
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count - i - 1; j++)
                {
                    var itemA = items[j];
                    var itemB = items[j +1];

                    if (itemA.CompareTo(itemB) == 1)
                    {
                        Swap(j, j+1);
                    }
                }            
            }
        }       
    }
}
