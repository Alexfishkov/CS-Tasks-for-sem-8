// Задача 62. Заполните спирально массив 4 на 4.

void FillArray(int[,] array)
{
    int totalElements = array.Length;
    int counterElements = 1;
    int i = 0, j = 1;

    // Инициализация сдвигов, т.е. изменяющихся границ остановки движения по строкам или столбцам
    int rihtShift = array.GetLength(1);
    int lowerShift = array.GetLength(0);
    int leftShift = 0;
    int upperShift = 0;
    array[0, 0] = 1;

    while (counterElements < totalElements)
    {
        while (j < rihtShift)
        {
            array[i, j] = counterElements + 1;
            j++;
            counterElements++;
        }
        j--;
        i++;
        rihtShift--;
        if (counterElements >= totalElements) break;

        while (i < lowerShift)
        {
            counterElements++;
            array[i, j] = counterElements;
            i++;
        }
        j--;
        lowerShift--;
        i--;
        if (counterElements >= totalElements) break;

        while (j >= leftShift)
        {
            counterElements++;
            array[i, j] = counterElements;
            j--;
        }
        i--;
        j++;
        leftShift++;
        if (counterElements >= totalElements) break;

        while (i > upperShift)
        {
            counterElements++;
            array[i, j] = counterElements;
            i--;
        }
        j++;
        i++;
        upperShift++;
        if (counterElements >= totalElements) break;
    }

}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j],2} ");
        }
        Console.WriteLine();
    }
}

int lines = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);

int[,] ourArray = new int[lines, columns];

Console.Clear();
Console.WriteLine("Заполняем случайного размера массив по спирали целыми числами от 1 до общего кол-ва элементов массива");
Console.WriteLine("Заполненный массив:");
FillArray(ourArray);
PrintArray(ourArray);
