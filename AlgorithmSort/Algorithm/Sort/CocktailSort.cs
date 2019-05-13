using System;

namespace AlgorithmSort
{
    public class CocktailSort<T> : SortAlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while (left < right)
            {
                //проход вправо по колекции
                for (int i = left; i < right; i++)
                {
                    //если следующий больше
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }

                //уменьшаем правый край на 1
                right--;

                //проход влево по колекции
                for (int i = right; i > left; i--)
                {
                    //если предведущий больше
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swap(i, i - i);
                    }
                }

                //увеличиваем левый край на 1
                left++;
            }
        }
    }
}
