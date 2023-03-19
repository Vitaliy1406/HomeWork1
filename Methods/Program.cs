using System.Diagnostics;

namespace Methods
{
    internal class Program
    { //1
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

        static int[] SelectionSort(int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                var minIndex = IndexOfMin(array1, i);
                if (minIndex != i)
                {
                    Swap(ref array1[minIndex], ref array1[i]);
                }
            }

            return array1;
        }

        //2
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

        //3
        static int[] InsertionSort(int[] array2)
        {
            for (var i = 1; i < array2.Length; i++)
            {
                var j = i;
                while ((j > 0) && (array2[j - 1] > array2[i]))
                {
                    Swap(ref array2[j - 1], ref array2[j]);
                    j--;
                }
            }

            return array2;
        }

        static void Main(string[] args)
        {
            var array = new int[] { 1, 3, 2, 7, 3 };
            Console.WriteLine($"Sort arrays: {string.Join(", ", BubbleSort(array))}");
            var array1 = new int[] { 10, 3, 2, 0, 1 };
            Console.WriteLine("Sort array: {0}", string.Join(",", SelectionSort(array1)));
            var array2 = new int[] { 10, 3, 2, 7, 7 };
            Console.WriteLine("Sort array: {0}", string.Join(",", InsertionSort(array2)));
            Console.ReadLine();
        }
    }
}
