using System;

namespace ClassLibrary1
{
    public class SelectionSort<T> : ISortable<T> where T : IComparable<T>
    {
        public T[] Ascending(T[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j].CompareTo(numbers[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                Swap(ref numbers[minIndex], ref numbers[i]);
            }
            return numbers;
        }

        public T[] Descending(T[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j].CompareTo(numbers[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }
                Swap(ref numbers[maxIndex], ref numbers[i]);
            }
            return numbers;
        }

        private void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
