// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void FillArrayRandomNumbers(double[,] array)   //CreateMatrixFormula
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 5} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


Console.WriteLine ("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);



