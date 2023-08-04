/*
using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        // Упорядочивание элементов каждой строки по убыванию
        for (int i = 0; i < rows; i++)
        {
            Array.Sort(array, i * columns, columns, new CustomComparer());
        }

        // Вывод отсортированного массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class CustomComparer : IComparer
{
    public int Compare(object x, object y)
    {
        return ((int)x).CompareTo((int)y) * -1;
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRow = -1;

        // Нахождение строки с наименьшей суммой элементов
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        int[,,] array = new int[2, 2, 2];
        int num = 10;

        // Формирование трехмерного массива из неповторяющихся двузначных чисел
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = num++;
                }
            }
        }

        // Вывод массива построчно с добавлением индексов каждого элемента
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
                }
            }
        }
    }
}
/*
using System;

class Program
{
    static void Main()
    {
        int n = 4;
        int[,] array = new int[n, n];
        int number = 1;
        int row = 0;
        int col = 0;
        int direction = 0;

        for (int i = 0; i < n * n; i++)
        {
            array[row, col] = number;

            switch (direction)
            {
                case 0: // Вправо
                    col++;
                    if (col == n || array[row, col] != 0)
                    {
                        col--;
                        row++;
                        direction = 1;
                    }
                    break;
                case 1: // Вниз
                    row++;
                    if (row == n || array[row, col] != 0)
                    {
                        row--;
                        col--;
                        direction = 2;
                    }
                    break;
                case 2: // Влево
                    col--;
                    if (col < 0 || array[row, col] != 0)
                    {
                        col++;
                        row--;
                        direction = 3;
                    }
                    break;
                case 3: // Вверх
                    row--;
                    if (row < 0 || array[row, col] != 0)
                    {
                        row++;
                        col++;
                        direction = 0;
                    }
                    break;
            }

            number++;
        }

        // Вывод массива
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array[i, j]:D2} ");
            }
            Console.WriteLine();
        }
    }
}
