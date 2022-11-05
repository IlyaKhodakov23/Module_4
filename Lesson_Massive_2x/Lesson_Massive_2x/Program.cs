namespace Lesson_Massive_2x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }
            // Unit 1 + 2
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;
            for (int i= 0; i <= arr.Length - 1; i++)
            {
                int k = 0;
                for (int j = i; j <= arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        k = arr[j];
                        arr[j] = arr[i];
                        arr[i] = k;
                    }
                }
            }
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write(arr[x]);
            }
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("\n" + sum);
            // Unit 
        }
    }
}