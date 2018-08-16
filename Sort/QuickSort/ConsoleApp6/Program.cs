using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 6, 2, 4 };
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Quicksort(ref arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        static public void Quicksort(ref int[] ar)
        {
            if (ar.Length > 1) Quicksort(ar, 0, ar.Length - 1);
        }

        static private void Quicksort(int[] ar, int left, int right)
        {
            if (left == right) return;
            int i = left + 1;
            int j = right;
            int pivot = ar[left];

            while (i < j)
            {
                if (ar[i] <= pivot) i++;
                else if (ar[j] > pivot) j--;
                else
                { 
                    int m = ar[i]; ar[i] = ar[j]; ar[j] = m;
                }
            }

            if (ar[j] <= pivot)
            {
                int m = ar[left]; ar[left] = ar[right]; ar[right] = m;
                Quicksort(ar, left, right - 1);
            }
            else
            {
                Quicksort(ar, left, i - 1);
                Quicksort(ar, i, right);
            }
        }
    }
}
