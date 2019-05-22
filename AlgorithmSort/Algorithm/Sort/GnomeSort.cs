using System;

namespace AlgorithmSort
{
    public class GnomeSort<T> : SortAlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            int i = 1;

            while (i < Items.Count)
            {
               if (i == 0 || Items[i].CompareTo(Items[i - 1]) >= 0)
                {
                    i++;
                }
                else
                {
                    Swop(i, i-1);
                    i--;
                }
            }
        }
    }
}
