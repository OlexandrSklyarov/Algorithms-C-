using System;
using System.Collections.Generic;

namespace AlgorithmSort
{
    public class SortAlgorithmBase<T> 
    {
        public List<T> Items = new List<T>();


        //обмен
        protected void Swap(int posA, int posB)
        {
            if (posA < Items.Count && posB < Items.Count)
            {
                T temp = Items[posA];
                Items[posA] = Items[posB];
                Items[posB] = temp;
            }
        }


        //сортировка (базовый метод)
        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
