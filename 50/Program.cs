// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
int[,] matrixFyrst = new int[,]
                    {
                        {1, 2, 3},
                        {4, 5, 6},
                        {7, 8, 9}
                    };
Console.WriteLine("Размер массива 3 х 3, нумерация с нулевой позиции.");
Console.Write("Введите позицию строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите позицию колонки: ");
int column = int.Parse(Console.ReadLine());

void PositionNumber(int[,] matrix, int[] position)
{
    bool chek = false;


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == position[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == position[1])
                {
                    chek = true;
                    Console.Write($" Число {matrix[i, j]} ");
                }
            }
        }
    }
    Console.Write($"на позиции [{String.Join(", ", position)}]  {(chek ? "" : "нет чисел чисел")}");
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        const int cellWidth = 6;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],cellWidth}");
        }
        Console.WriteLine();
    }

}


int[] positionCoordinate = new int[] { row, column };
PrintMatrix(matrixFyrst);
PositionNumber(matrixFyrst, positionCoordinate);