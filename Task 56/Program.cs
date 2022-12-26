// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(10,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindMinRowSum(int[,] array)
{
    int minSum = 0;
    int nminSum = 0;
    int tempMinsum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0, j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        tempMinsum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempMinsum += array[i, j];
        }
        if (tempMinsum < minSum)
        {
            minSum = tempMinsum;
            nminSum = i;
        }
    }
    return nminSum;
}

int lines = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);

int[,] ourArray = new int[lines, columns];

FillArray(ourArray);

Console.Clear();
Console.WriteLine("Находим в массиве строку с наименьшей суммой элементов");
Console.WriteLine("Исходный массив:");
PrintArray(ourArray);
Console.WriteLine($"Строкой с наименьшей суммой элементов является строка № {FindMinRowSum(ourArray)}");
