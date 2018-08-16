using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static int[] Bubble_Sort(int[] anArray)
        {
            for (int i = 0; i < anArray.Length; i++)
            {
                for (int j = 0; j < anArray.Length - 1 - i; j++)
                {
                    if (anArray[j] > anArray[j + 1])
                    {
                        anArray[j] = anArray[j] + anArray[j + 1];
                        anArray[j + 1] = anArray[j] - anArray[j + 1];
                        anArray[j] = anArray[j] - anArray[j + 1];
                    }
                }
            }

            return anArray;

        }

        static void Main(string[] args)
        {
            int[] someArray = new int[] { 5,1,7,3,8 };
            foreach (int number in someArray)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
            someArray = Bubble_Sort(someArray);
            foreach (int number in someArray)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
