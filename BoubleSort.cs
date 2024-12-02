using System;

namespace ClassLibrary1
{
    public class BubbleSort<T> : ISortable<T> where T : IComparable<T>
    {
        public T[] Ascending(T[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j].CompareTo(numbers[j + 1]) > 0)
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                    }
                }
            }
            return numbers;
        }

        public T[] Descending(T[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j].CompareTo(numbers[j + 1]) < 0)
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                    }
                }
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
