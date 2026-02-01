using System;
class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Меню:");
        Console.WriteLine("1 -- Показать ФИО");
        Console.WriteLine("2 -- Показать группу");
        Console.WriteLine("3 -- Показать дату");
        Console.WriteLine("4 -- Выход");
        
        Console.WriteLine("Hello, client!");
        Console.WriteLine("Lepilkin Maxim Aleksandrovich");
        Console.WriteLine("ИСП-232");
        Console.WriteLine(DateTime.Now);
    }
}
