// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void MultiplyingArrays(int[,] arrayA, int[,] arrayB, int[,] arrayMult)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            arrayMult[i, j] = arrayA[i, j] * arrayB[i, j];
        }
    }
}

int lines = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);

int[,] ourArray1 = new int[lines, columns];
int[,] ourArray2 = new int[lines, columns];
int[,] resultArray = new int[lines, columns];

Console.Clear();
Console.WriteLine("Задаём два массива случайных чисел одинаковой размерности и умножаем их друг на друга поэлементно");

FillArray(ourArray1);
Console.WriteLine("Исходный массив №1:");
PrintArray(ourArray1);

FillArray(ourArray2);
Console.WriteLine("Исходный массив №2:");
PrintArray(ourArray2);

MultiplyingArrays(ourArray1,ourArray2,resultArray);

Console.WriteLine("Результирующий массив после перемножения элементов:");
PrintArray(resultArray);