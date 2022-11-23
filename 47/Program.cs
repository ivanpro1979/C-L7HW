//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество колонок: ");
int columns = int.Parse(Console.ReadLine());

double[,] matrixFirst = new double[rows, columns];

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (new Random().NextDouble()) + (new Random().Next(-10, 10));
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    const int cellWidth = 6;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],cellWidth:f2}");
        }
        Console.WriteLine();
    }
}

FillMatrix(matrixFirst);
PrintMatrix(matrixFirst);