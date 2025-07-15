using System;
using System.Collections.Generic;

class program
{
    static int FindSmallest (List<int> arr)
    {
        int smallest = arr[0];
        int smallestIndex = 0;

        for (int i = 1; i< arr.Count; i++)
        {
            if (arr[i]< smallest)
            {
                smallest = arr[i];
                smallestIndex = i;
            }

        }
        return smallestIndex;
    }
    static List<int> SelectionSort(List<int> arr)
    {
        List<int> sortedList = new List<int>();
        while (arr.Count > 0)
        {
            int smallestIndex = FindSmallest(arr);
            sortedList.Add(arr[smallestIndex]);
            arr.RemoveAt(smallestIndex);

        }
        return sortedList;
    }
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 3, 6, 2, 10 };
        List<int> sorted = SelectionSort(numbers);

        Console.WriteLine("Sorted List: " + string.Join(", ", sorted));
    }
}
//Another way to implement Selection Sort using a static class and method:
/*
 using System;

static class Sorter
{
    // Static method inside a static class
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 3, 6, 2, 10 };

        // No object needed — call static method directly
        Sorter.SelectionSort(numbers);

        Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));
    }
}
*/


//Another way to implement Selection Sort using a static class and method with for loop to print the sorted array:
/*using System;

static class Sorter
{
    // Static method inside a static class
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 3, 6, 2, 10 };

        // Call static sort method
        Sorter.SelectionSort(numbers);

        // Print sorted array using for loop with commas
        Console.Write("Sorted Array: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);

            // Don't print comma after the last element
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine(); // New line at end
    }
}
*/