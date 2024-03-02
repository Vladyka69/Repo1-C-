using System;

class Program
{
    static void Main()
    {
        int year;

        Console.WriteLine("Введите год: ");
        year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    Console.WriteLine(year + " Год високосный ");
                else
                    Console.WriteLine(year + " Год не високосный ");
            }
            else
                Console.WriteLine(year + " Год високосный ");
        }
        else
            Console.WriteLine(year + " Год не високосный");
    }
}