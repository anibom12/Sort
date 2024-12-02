using System;

namespace ClassLibrary1
{
    public class InsertionSort<T> : ISortable<T> where T : IComparable<T>
    {
        public T[] Ascending(T[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                T key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j].CompareTo(key) > 0)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        public T[] Descending(T[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                T key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j].CompareTo(key) < 0)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }
    }
}
