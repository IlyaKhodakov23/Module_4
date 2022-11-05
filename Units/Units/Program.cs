using System.Linq.Expressions;

namespace Units
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] array = new int[3][];
            //array[0] = new int[2] { 1, 2 };
            //array[1] = new int[3] { 1, 2, 3 };
            //array[2] = new int[5] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array[i].Length; j++)
            //    {
            //        Console.Write(array[i][j]);
            //    }
            //}
            //int[] arr = new int[] { 1, 2, 3, -5, -10 };
            //int count = 0;
            //for (int i = 0; i <= arr.Length - 1; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("\n" + count);

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            //Console.WriteLine(arr.GetUpperBound(0) + " " + arr.GetUpperBound(1));
            //int count = 0;
            //for (int i = 0; i <= arr.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //    {
            //        if (arr[i, j] > 0)
            //        {
            //            count++;
            //            //Console.Write(arr[i, j] + " ");
            //        }
                    
            //    }
            //}
            //Console.Write(count);

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                int k = 0;
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int y = j; y <= arr.GetUpperBound(1); y++)
                    {
                        if (arr[i, j] > arr[i, y])
                        {
                            k = arr[i, y];
                            arr[i, y] = arr[i, j];
                            arr[i, j] = k;
                        }
                        
                    }
                    Console.Write(arr[i, j] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}