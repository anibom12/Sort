using System;

namespace ClassLibrary1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the numbers to sort (comma-separated): ");
                string input = Console.ReadLine();
                int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);

                Console.WriteLine("Select sorting algorithm (1- BubbleSort, 2- SelectionSort, 3- MergeSort, 4- InsertionSort): ");
                if (!int.TryParse(Console.ReadLine(), out int algorithm) || algorithm < 1 || algorithm > 4)
                {
                    throw new ArgumentException("Invalid algorithm selection. Please enter a number between 1 and 4.");
                }

                ISortable<int> sorter = algorithm switch
                {
                    1 => new BubbleSort<int>(),
                    2 => new SelectionSort<int>(),
                    3 => new MergeSort<int>(),
                    4 => new InsertionSort<int>(),
                    _ => throw new ArgumentException("Invalid algorithm selection.")
                };

                Console.WriteLine("Select sorting order (1- Ascending, 2- Descending): ");
                if (!int.TryParse(Console.ReadLine(), out int order) || order < 1 || order > 2)
                {
                    throw new ArgumentException("Invalid order selection. Please enter 1 for Ascending or 2 for Descending.");
                }

                int[] sortedNumbers = order switch
                {
                    1 => sorter.Ascending(numbers),
                    2 => sorter.Descending(numbers),
                    _ => throw new ArgumentException("Invalid order selection.")
                };

                Console.WriteLine(order == 1 ? "Ascending: " : "Descending: " + string.Join(", ", sortedNumbers));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter numbers separated by commas.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
