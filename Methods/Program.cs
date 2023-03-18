using System.Diagnostics;

namespace Methods
{
    internal class Program
    {//1
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        static int IndexOfMin(int[] array, int n)
        {
            int minIndex = n;
            for (var i = n; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
        static int[] SelectionSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                var minIndex = IndexOfMin(array, i);
                if(minIndex != i)
                {
                    Swap(ref array[minIndex], ref array[i]);
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            var array = new int[] { 10, 3, 2, 0, 1 };
            Console.WriteLine("Sort array: {0}", string.Join(",", SelectionSort(array)));
        }
        //2
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        private static int[] BubbleSort(int[] array)

        {
            for (var i = 1; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - i; j++)
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
            }

            return array;
        }

        static void Main(string[] args)
        {
            var array = new int[] { 1, 3, 2, 7, 3 };
            Console.WriteLine($"Sort arrays: {string.Join(", ", BubbleSort(array))}");
            Console.ReadLine();
        }
        //3
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var j = i;
                while ((j > 0) && (array[j - 1] > array[i]))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            var array = new int[] { 10, 3, 2, 7, 7 };
            Console.WriteLine("Sort array: {0}", string.Join(",", InsertionSort(array)));
            Console.ReadLine();
        }
    }
