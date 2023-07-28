/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа, разделенные запятой:");
        string[] numberStrings = Console.ReadLine().Split(",");
        int count = 0;

        foreach (var numberString in numberStrings)
        {
            int number = int.Parse(numberString.Trim());
            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел, больших 0: {count}");
    }
}
*/



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения k1, b1, k2 и b2, разделенные запятой:");
        string[] values = Console.ReadLine().Split(",");
        double k1 = double.Parse(values[0].Trim());
        double b1 = double.Parse(values[1].Trim());
        double k2 = double.Parse(values[2].Trim());
        double b2 = double.Parse(values[3].Trim());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
    }
}
