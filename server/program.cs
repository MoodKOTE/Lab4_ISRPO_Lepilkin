using System;
class Program
{
    public static void Main(String[] args)
    {
        bool flag = true;
        Console.WriteLine("Hello, client!");
        while (flag == true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 -- Показать ФИО");
            Console.WriteLine("2 -- Показать группу");
            Console.WriteLine("3 -- Показать дату");
            Console.WriteLine("4 -- Выход");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1": Console.WriteLine("Lepilkin Maxim Aleksandrovich"); break;
                case "2": Console.WriteLine("ИСП-232"); break;
                case "3": Console.WriteLine(DateTime.Now); break;
                case "4": flag = false; break;
            }
            Console.WriteLine();
        }
    }
}

