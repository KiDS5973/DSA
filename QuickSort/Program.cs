using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> QuickSort(List<int> arr)
    {
        if (arr.Count <= 1)
            return arr;

        int pivot = arr[0];
        List<int> less = arr.Skip(1).Where(i => i < pivot).ToList();    // FIXED
        List<int> greater = arr.Skip(1).Where(i => i >= pivot).ToList(); // FIXED

        List<int> sorted = new List<int>();
        sorted.AddRange(QuickSort(less));
        sorted.Add(pivot);
        sorted.AddRange(QuickSort(greater));

        return sorted;
    }

    static void Main()
    {
        List<int> data = new List<int> { 5, 8, 7, 15, 6, 32, 95, 42, 75, 43, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        List<int> result = QuickSort(data);
        Console.WriteLine(string.Join(", ", result));
    }
}
