// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

void FillArray(int[,,] array)
{
    int meaning = new Random().Next(10, 16);

    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = meaning + new Random().Next(1, 11);
                meaning = array[x, y, z];
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z=0; z < array.GetLength(2); z++)
            {
            Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
            }
        }
        Console.WriteLine();
    }
}

int xParam = 2;
int yParam = 2;
int zParam = 2;

int[,,] ourArray = new int[xParam, yParam, zParam];

Console.Clear();
Console.WriteLine("Формируем 3-х мерный массив 2х2х2 из неповторяющихся двухзначных чисел и выводим его на печать");

FillArray(ourArray);
Console.WriteLine("Наш массив:");
PrintArray(ourArray);


