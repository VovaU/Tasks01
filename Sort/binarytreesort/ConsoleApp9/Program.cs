using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] {2, 5, 3, 1,4,5,6,7,9};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            SortTree(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }

        static public int max = 0;

        public class Tree
        {
            public int value;
            public Tree left;
            public Tree right;
        }

        static public Tree AddNodeToTree(Tree root, int new_value)
        {

            if (root == null)
            {
                root = new Tree();
                root.value = new_value;
                root.left = null;
                root.right = null;
                return root;
            }

            if (root.value < new_value)
            {
                root.right = AddNodeToTree(root.right, new_value);
            }
            else
            {
                root.left = AddNodeToTree(root.left, new_value);
            }

            ;
            return root;
        }

        static public void TreeToArray(Tree root, int[] a)
        {
            if (root == null) return;
            TreeToArray(root.left, a);
            a[max++] = root.value;
            TreeToArray(root.right, a);
        }

        static public void SortTree(ref int[] a)
        {
            Tree root = null;
            for (int i = 0; i < a.Length; i++)
            {
                root = AddNodeToTree(root, a[i]);
            }

            int k=0;//
            TreeToArray(root, a);

        }
    }
}
