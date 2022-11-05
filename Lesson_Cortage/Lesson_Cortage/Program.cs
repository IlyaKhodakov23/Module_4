namespace Lesson_Cortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var (name, age) = ("Евгения", 27);
            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            //(string name, int age) anketa;
            //Console.Write("Введите имя: ");
            //anketa.name = Console.ReadLine();
            //Console.Write("Введите возраст: ");
            //anketa.age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Твое имя {0}, твой возраст {1}.", anketa.name, anketa.age);

            (string Name, string Type, double Age, int NameCount) Pet;
            Console.WriteLine("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Введите тип питомца: ");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Введите возраст питомца: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("Количество букв в имени питомца: {0}", Pet.NameCount);
        }
    }
}