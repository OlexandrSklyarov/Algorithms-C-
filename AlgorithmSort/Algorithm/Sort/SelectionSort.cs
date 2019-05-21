using System;
namespace AlgorithmSort
{
    public class SelectionSort<T> :SortAlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            var minIndex = 0;

            for (int i = 0; i < Items.Count - 1; i++)
            {
                minIndex = i;

                for (int j = i+1; j < Items.Count; j++)
                {
                    if (Items[j].CompareTo(Items[minIndex]) == -1)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Swop(minIndex, i);
                }
            }
        }
    }
}
