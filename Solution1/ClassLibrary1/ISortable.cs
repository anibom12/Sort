using System;

namespace ClassLibrary1
{
    public interface ISortable<T> where T : IComparable<T>
    {
        T[] Ascending(T[] numbers);
        T[] Descending(T[] numbers);
    }
}
