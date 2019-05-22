using System;
using System.Collections.Generic;

namespace AlgorithmSort
{
    public class SortAlgorithmBase<T> 
    {
        public List<T> Items = new List<T>();
        public int SwopCount { get; protected set; }

        //обмен
        protected void Swop(int posA, int posB)
        {
            if (posA < Items.Count && posB < Items.Count)
            {
                T temp = Items[posA];
                Items[posA] = Items[posB];
                Items[posB] = temp;

                SwopCount++;
            }
        }


        //сортировка (базовый метод)
        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
