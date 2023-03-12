namespace lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = MaxValue();
            int min = MinValue();
            int max1 = MaxValue(5, 15);
            int max2 = MaxValue(10, 7, 19);
            int max3 = MaxValue(14, 9, 13, 4);
            int max4 = MaxValue(1, 5, 12, 32, 15, 22);
            int min1 = MinValue(5, 15);
            int min2 = MinValue(10, 7, 19);
            int min3 = MinValue(14, 9, 13, 4);
            int min4 = MinValue(1, 5, 12, 32, 15, 22);
            var isOdd = TrySumIfOdd(1, 5, out int sum);
            
      
        }
        //TAsk 1
        static int MaxValue()
        {
            var rand = new Random();
            var x = rand.Next(10);
            var y = rand.Next(10);
            var max = Math.Max(x, y);
            Console.WriteLine($"x = {x}, y = {y},max value = {max}");
            return max;
            
        }
        //TAsk 2
        static int MinValue()
        {
            var rand = new Random();
            var x = rand.Next(10);
            var y = rand.Next(10);
            var min = Math.Min(x, y);
            Console.WriteLine($"x = {x}, y = {y},min value = {min}");
            return min;

        }
        //Task 4
        static int MaxValue(int x, int y)
        {
            int max = Math.Max(x, y);
            Console.WriteLine($"x = {x}, y = {y},max value = {max}");
            return max;
        }
        static int MaxValue(int x, int y, int c)
        {
            int max = Math.Max(Math.Max(x, y), c);
            return max;
        }
        static int MaxValue(int x, int y, int c,int d)
        {
            int max = Math.Max( Math.Max(Math.Max(x, y), c), d);
            return max;
        }
        static int MaxValue(params int[] y)
        {
            int max = y.Max();
            return max;
        }
        static int MinValue(int x, int y)
        {
            int min = Math.Min(x, y);
            Console.WriteLine($"x = {x}, y = {y},min value = {min}");
            return min;
        }
        static int MinValue(int x, int y, int c)
        {
            int min = Math.Min(Math.Min(x, y), c);
            return min;
        }
        static int MinValue(int x, int y, int c, int d)
        {
            int min = Math.Min(Math.Min(Math.Min(x, y), c), d);
            return min;
        }
        static int MinValue(params int[] y)
        {
            int min = y.Min();
            return min;
        }
        //Task 3
        static bool TrySumIfOdd(int start, int end, out int sum)
        {
            sum = 0;
            if (start == end)
                return false;
            if(start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            for(var i = start+1;i<end;i++)
            {
                sum += i;
            }
            bool isOdd = sum % 2 == 1;
            return isOdd;
        }




    }


}
      