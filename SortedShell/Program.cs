using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedShell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 34, 54, 2, 3 };
            
            Console.WriteLine("Original Array:");
            Display(array);

            ShellSort(array);

            Console.WriteLine("\nSorted Array:");
            Display(array);
           
            Console.ReadKey();
        }

        static void ShellSort(int[] arr)
        {
            
            int n = arr.Length;
            //edge case 
            if (n == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }
         

            // Start with a big gap, then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size
                for (int i = gap; i < n; i += 1)
                {
                    // Save arr[i] in temp and make a hole at position i
                    int temp = arr[i];

                    // Shift earlier gap-sorted elements up until the correct location for arr[i] is found
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    // Put temp (the original arr[i]) in its correct location
                    arr[j] = temp;
                }
            }
        }

        static void Display(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
