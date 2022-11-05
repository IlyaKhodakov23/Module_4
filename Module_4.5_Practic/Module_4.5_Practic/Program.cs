namespace Module_4._5_Practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int y = 0; y < 3; y++)
            {
                (string name, string surname, string login, int count_log, bool pet, double age, string[] colors) user;

                Console.WriteLine("Введите имя");

                user.name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                user.surname = Console.ReadLine();

                Console.WriteLine("Введите логин");

                user.login = Console.ReadLine();

                user.count_log = user.login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                string answer = Console.ReadLine();
                if (answer == "Да")
                    user.pet = true;
                else user.pet = false;

                Console.WriteLine("Введите возраст пользователя");

                user.age = Convert.ToDouble(Console.ReadLine());

                user.colors = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < 3; i++)
                {
                    user.colors[i] = Console.ReadLine();
                }
            }

            

        }
    }
}