using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[]{1,5,6,2,4};
            foreach (int i in arr)
            {
                Console.Write(i+" ");
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
            int index, temp;
            for (int i = 0; i < arr.Length; ++i)
            {
                index = i;
                temp = arr[i];
                for (int j = i + 1; j < arr.Length; ++j)
                {
                    if (arr[j] < temp)
                    {
                        index = j;
                        temp = arr[j];
                    }
                }
                arr[index] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
