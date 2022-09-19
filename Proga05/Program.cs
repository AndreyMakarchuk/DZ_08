// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralMassive(int side)
{
    int[,] spiralMassive = new int[side, side];
    int value = 0;
    int count = side;
    int vol = -side;
    int ind = -1;
    while (count > 0)
    {
        vol = -1 * vol / side;
        for (int i = 0; i < count; i++)
        {
            ind += vol;
            spiralMassive[ind / side, ind % side] = value++;
        }
        vol *= side;
        count--;
        for (int i = 0; i < count; i++)
        {
            ind += vol;
            spiralMassive[ind / side, ind % side] = value++;
        }
    }
    return spiralMassive;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int x = 4;
int[,] array = SpiralMassive(x);
PrintArray(array);
