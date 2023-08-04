/*
using System;

class Program
{
    static void Main()
    {
        int m = 3;
        int n = 4;
        double[,] array = new double[m, n];
        Random random = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double randomNumber = random.NextDouble() * 20 - 10; // Генерация случайного числа от -10 до 10
                array[i, j] = randomNumber;
            }
        }

        // Вывод массива
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array[i, j]:F1} ");
            }
            Console.WriteLine();
        }
    }
}
/*

using System;

class Program
{
    static void Main()
    {
        int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        Console.Write("Введите позицию строки элемента (отсчет начинается с 0): ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите позицию столбца элемента (отсчет начинается с 0): ");
        int column = Convert.ToInt32(Console.ReadLine());

        int m = array.GetLength(0); // количество строк в массиве
        int n = array.GetLength(1); // количество столбцов в массиве

        if (row >= 0 && row < m && column >= 0 && column < n)
        {
            int element = array[row, column];
            Console.WriteLine($"Значение элемента: {element}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет в массиве.");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        int m = array.GetLength(0); // количество строк в массиве
        int n = array.GetLength(1); // количество столбцов в массиве

        double[] averages = new double[n];

        for (int col = 0; col < n; col++)
        {
            int sum = 0;
            for (int row = 0; row < m; row++)
            {
                sum += array[row, col];
            }
            averages[col] = (double)sum / m;
        }

        Console.WriteLine("Среднее арифметическое каждого столбца:");
        for (int col = 0; col < n; col++)
        {
            Console.Write($"{averages[col]:F1} ");
        }
    }
}