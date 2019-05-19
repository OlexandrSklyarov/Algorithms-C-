using System;

namespace AlgorithmSort
{
    public class ShellSort<T> : SortAlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            int step = Items.Count / 2;

            while (step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    while ((j >= step) && Items[j-step].CompareTo(Items[j]) == 1)
                    {
                        Swop(j-step, j);
                        j -= step;
                    }
                }

                step /= 2;
            }
        }
    }
}
