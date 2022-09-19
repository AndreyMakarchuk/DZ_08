// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] FirstArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}
int[,] SecondArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов первой матрицы: ");
int columns1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] array = FirstArray(rows1, columns1, 0, 9);
int[,] secondArray = SecondArray(rows2, columns2, 0, 9);
int[,] divMatrix = DivMatrix(array, secondArray);

PrintArray(array);
Console.WriteLine();
PrintArray(secondArray);

int[,] DivMatrix(int[,] array, int[,] secondArray)

{
    if (array.GetLength(0) != secondArray.GetLength(1))
    {
        throw new Exception(" Не перемножаются ");
    }
    int[,] result = new int[array.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                result[i, j] += array[i, k] * secondArray[k, j];
            }
        }
    }
    return result;
}
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет:");
PrintArray(divMatrix);
