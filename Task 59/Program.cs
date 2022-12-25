// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.

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

void FindMinimum (int [,] array, int [] result)
{
    result[0] = array [0,0];
    result[1] = 0;
    result[2] = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i,j] < result[0])
            {
                result[0] = array[i,j];
                result[1] = i;
                result[2] = j;
            }
        }
    }
        
}

void DeleteLineAndColumn(int[,] array1, int[,] array2, int[] array3)
{
    int ii = 0, jj = -1;

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (i != array3[1] && j != array3[2])

            {
                if (jj < array2.GetLength(1) - 1)
                {
                    jj++;
                    array2[ii, jj] = array1[i, j];
                }
                else
                {
                    ii++;
                    jj = 0;
                    array2[ii, jj] = array1[i, j];

                }
            }
        }
    }
}

int lines = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);

int[,] ourArray = new int[lines, columns];
int[] minElement = new int[3];
int[,] resultArray = new int[lines-1,columns-1];

FillArray(ourArray);

Console.Clear();
Console.WriteLine("Генерим случайный массив, находим в нём первый по счёту мин. элемент и удаляем из массива столбец и строку, в которых он находится.");
Console.WriteLine("Исходный массив:");
PrintArray(ourArray);
FindMinimum(ourArray, minElement);
Console.WriteLine($"Минимальный элемент: {minElement[0]} находится на {minElement[1]} строке и в {minElement[2]} столбце");
DeleteLineAndColumn(ourArray,resultArray,minElement);
Console.WriteLine("А вот массив после обработки:");
PrintArray(resultArray);
