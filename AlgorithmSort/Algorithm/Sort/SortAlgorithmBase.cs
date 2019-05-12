using System;
using System.Collections.Generic;

namespace AlgorithmSort
{
    public class SortAlgorithmBase<T>
    {
        public List<T> items = new List<T>();

        //обмен
        protected void Swap(int itemA, int itemB)
        {
            int temp = itemA;
            itemA = itemB;
            itemB = temp;
        }


        //сортировка (базовый метод)
        public virtual void Sort()
        {
            items.Sort();
        }
    }
}
