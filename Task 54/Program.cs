// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

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

void AscendingRowArrange(int[,] array)
{
    int tempMin = 0;
    int k = 0;
    int minPos = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempMin = array[i, j];
            minPos = j;
            k = j + 1;

            while (k < array.GetLength(1))
            {

                if (array[i, k] < tempMin)
                {
                    tempMin = array[i, k];
                    array[i, k] = array[i, minPos];
                    array[i, minPos] = tempMin;
                }
                k++;
            }
        }
    }

}

int lines = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);

int[,] ourArray = new int[lines, columns];

FillArray(ourArray);

Console.Clear();
Console.WriteLine("Упорядочим по возрастанию элементы вкаждой строке массива");
Console.WriteLine("Исходный массив:");
PrintArray(ourArray);
AscendingRowArrange(ourArray);
Console.WriteLine("А вот массив после обработки:");
PrintArray(ourArray);

