using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int[]{0,1,2,0,1,1,6};
            int[] ar=Zeroes(array);
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i]);

            }
            Console.ReadKey();
        }

        static int[] DeleteTwoElem(int[] array) //4.1
        {
            for (int i = 0; i < array.Length; i++)
            {
                int x = 0;
                if (array[i] != Int32.MinValue)
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            ++x; 
                            if (x > 1)
                            {
                                array[j] = Int32.MinValue;
                            }
                        }
                    }
            }
           return Array.FindAll(array, x=>x!=Int32.MinValue).ToArray();
        }

        static int[] TooManyOperations(int[] array) // 4.2
        {
            int max = Int32.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && max < array[i])
                {
                    max = array[i];
                }
            }

            int indexMax = Array.IndexOf(array, max);
            if (indexMax != array.Length - 1)
            {

                for (int i = 0; i < 3; i++)
                {
                    int t = array[indexMax + 1];
                    for (int j = indexMax + 1; j < array.Length - 1; j++)
                        array[j] = array[j + 1];
                    array[array.Length - 1] = t;
                }
            }

            if (indexMax != 0)
                {
                    int t = array[indexMax - 1];
                    for (int j = indexMax - 1; j > 0; j--)
                        array[j] = array[j - 1];
                    array[0] = t;
                }
            

            return array;
        }

        static int NegativeCount(int[] array) //4.3
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        static int Negativepow(int[] array) //4.4
        {
            int sum = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum =sum*array[i];
                }
            }

            return sum;
        }

        static int Sum(int[] array) //4.5
        {
            int zero1 = -1, zero2 = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {

                    if (zero1 == -1)
                        zero1 = i;
                    else if (zero2 == -1)
                        zero2 = i;
                    else
                        break;
                }

            }

            if (zero2 == -1)
            {
                return 0;
            }
            else
            {
                if (zero1 == zero2 - 1)
                    return 0;
                else
                {
                    int s = 0;
                    for (int i = zero1 + 1; i < zero2; i++)
                        s += array[i];
                    return s;
                }
            }
        } 

        static int MaxElement(int[] array) //4.6
        {
            int max=Int32.MinValue;
            for (int a = 0; a < array.Length; a++)
            {
                if (max < array[a]) max = array[a];
            }

            return max;
        }

        static int SmallPair(int[] array) //4.7
        {
            int min = Int32.MaxValue;
            for (int a = 0; a < array.Length; a++)
            {
                if (min > array[a] && array[a] % 2 == 0) min = array[a];
            }

            return min == Int32.MaxValue ? array[0] : min;
        }

        static int[] Zeroes(int[] array) //4.8
        {

            for (int i = 0; i < array.Length; i++)
            { 
                if(array[i]!=0) continue;
                ;
                for (int j = i; j > 0; j--)
                {
                    array[j]=array[j-1];
                    array[j - 1] = 0; 
                }
            }

            return array;
        }

        static int maxMin(int[] array) //4.9
        {
            int imax = 0, imin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[imax])
                    imax = i;
                if (array[i] < array[imin])
                    imin = i;
            }
            return Array.IndexOf(array,imax) + Array.IndexOf(array, imin)+2;
        }

        static void underSer(int[] array, int sum) // 4.10
        {
            int res = -1;
            int k = Convert.ToInt32(Math.Pow(2, array.Length));
            for (int i = 0; i < k; i++)
            {
                int p = 0;
                bool flag = false;
                for (int j = 0; j < array.Length; j++)
                    if ((i & (1 << j)) != 0)
                    {
                        p += array[j];
                        flag = true;
                    }

                if (p == sum && flag)
                {
                    res = i;
                    break;
                }
            }

            for (int j = 0; j < array.Length; j++)
                if ((res & (1 << j)) != 0)
                {
                    Console.Write(array[j] + " ");
                }

            Console.ReadKey();
        }

        static int BinarySearch(int[] array, int key, int low = 0, int high = -1) //4.11
        {
            if (high == -1) high = array.Length - 1;

            int mid = (low + high) / 2;
            if (array[mid] == key)
                return mid;
            if (array[mid] < key)
                BinarySearch(array, key, mid + 1, high);
            if (array[mid] > key)
                BinarySearch(array, key, low, mid - 1);
            return 0;
        }
    }


}
