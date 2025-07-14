namespace DSA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the arrat: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine();

            Console.Write("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Enter the element to be searched: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            // Binary Search Algorithm
            Array.Sort(arr); // Ensure the array is sorted before performing binary search


            int left = 0, right = n - 1;
            int index = -1;


            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == x)
                {
                    index = mid;
                    break;
                }
                else if (arr[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }
            if (index != -1)
            {
                Console.WriteLine("Element found at index: " + index);
            }
            else
            {
                Console.WriteLine("Element not found in the array.");
            }
        }
    }
}
