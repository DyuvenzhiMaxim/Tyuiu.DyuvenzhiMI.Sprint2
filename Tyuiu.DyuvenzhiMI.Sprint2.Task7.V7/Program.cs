
using Tyuiu.DyuvenzhiMI.Sprint2.Task7.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Дювенжи М. И. | ПИНТб-25-1";
        //Длина строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #7                                                             *");
        Console.WriteLine("* Выполнил: Дювенжи Максим Иванович | ПИНТб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("Введите значение x:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool res = ds.CheckDotInShadedArea(x, y);
        if (res == true)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("False");
        }

        Console.ReadLine();
    }
}