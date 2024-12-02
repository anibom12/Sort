using System;

namespace ClassLibrary1
{
    public class MergeSort<T> : ISortable<T> where T : IComparable<T>
    {
        public T[] Ascending(T[] numbers)
        {
            if (numbers.Length <= 1)
                return numbers;

            int mid = numbers.Length / 2;
            T[] left = numbers.Take(mid).ToArray();
            T[] right = numbers.Skip(mid).ToArray();

            return Merge(Ascending(left), Ascending(right));
        }

        public T[] Descending(T[] numbers)
        {
            if (numbers.Length <= 1)
                return numbers;

            int mid = numbers.Length / 2;
            T[] left = numbers.Take(mid).ToArray();
            T[] right = numbers.Skip(mid).ToArray();

            return MergeDescending(Descending(left), Descending(right));
        }

        private T[] Merge(T[] left, T[] right)
        {
            List<T> result = new List<T>();
            int i = 0, j = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i].CompareTo(right[j]) < 0)
                    result.Add(left[i++]);
                else
                    result.Add(right[j++]);
            }

            while (i < left.Length)
                result.Add(left[i++]);

            while (j < right.Length)
                result.Add(right[j++]);

            return result.ToArray();
        }

        private T[] MergeDescending(T[] left, T[] right)
        {
            List<T> result = new List<T>();
            int i = 0, j = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i].CompareTo(right[j]) > 0)
                    result.Add(left[i++]);
                else
                    result.Add(right[j++]);
            }

            while (i < left.Length)
                result.Add(left[i++]);

            while (j < right.Length)
                result.Add(right[j++]);

            return result.ToArray();
        }
    }
}
