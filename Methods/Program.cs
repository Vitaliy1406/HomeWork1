using System.Diagnostics;

namespace Methods
{
    internal class Program
    {    static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
       

        
    }

    private static int[] BubbleSort(int[] array)

    {

          for ( var i = 1; i < array.Length; i++)
          {

            for (var j = 0; j < array.Length - i; j++)
                
                if (array[j] > array[j + 1]) ;
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

        Console.ReadLine()
        
    }



}
     