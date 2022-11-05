using System;
using System.Reflection;

namespace Massive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам: ");
            foreach (var i in name)
            {
                Console.Write(i + " "); 
            }
            Console.WriteLine("Ваше имя в обратном порядке: ");
            for (int y = name.Length-1; y >= 0; y--)
            {
                Console.Write(name[y]);
            }

            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}