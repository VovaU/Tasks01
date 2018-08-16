using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 5, 6, 2, 4 };
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            SelectionSort(ref arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        static void SelectionSort(ref int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                int minValueIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[minValueIndex];
                arr[minValueIndex] = temp;
            }

        }
    }
}
