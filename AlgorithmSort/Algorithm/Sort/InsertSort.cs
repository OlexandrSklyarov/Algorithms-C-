using System;
namespace AlgorithmSort
{
    public class InsertSort<T> : SortAlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            for (int i = 1; i < Items.Count; i++)
            {
                T temp = Items[i];
                int j = i;

                while (j > 0 && temp.CompareTo(Items[j-1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;
                }

                Items[j] = temp;
            }
        }
    }
}
