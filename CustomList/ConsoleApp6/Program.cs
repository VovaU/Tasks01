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
            MyClass<int> test=new MyClass<int>();
            test.Add(22);
            test.Add(22);
            test.Add(22);
            test.Add(22);
            Console.WriteLine(test[1]);
            Console.Read();
        }
    }

    class MyClass<T>
    {
        private T[] arr;

        public MyClass()
        {
        }
        public T this[
            int index
        ]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public void Add(T newElem)
        {
            if (arr != null)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = newElem;
            }
            else
            {
                arr = new T[]{newElem};
            }
        }

        public int Count()
        {
            return arr.Length;
        }

        public void Clear()
        {
             arr=null;
        }

        public int IndexOf(T newElem)
        {
            return Array.IndexOf(arr, newElem);
        }

        public void Remove(T elem)
        {
            int t = IndexOf(elem);
            for (int a = t; a < arr.Length - 1; a++)
            {
                arr[a] = arr[a + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }

        public void Sort()
        {
            Array.Sort(arr);
        }
        
    }


}
