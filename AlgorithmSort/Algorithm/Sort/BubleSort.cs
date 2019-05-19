using System;
using System.Collections.Generic;

namespace AlgorithmSort
{
    public class BubleSort<T> : SortAlgorithmBase<T> where T : IComparable
    {
        //алгоритм сортировки пузырьком
        public void SortT()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                for (int j = 0; j < Items.Count - i - 1; j++)
                {
                    var a = Items[j];
                    var b = Items[j +1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swop(j, j+1);
                    }
                }            
            }
        }       
    }
}
