// Доп. задача N61: Вывести первые N строк треугольника Паскаля
// Сделать вывод в виде равнобедренного треугольника

void PrintArray(int[,] array)
{
    int width = 5;
    int leftShift = width*array.GetLength(0);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}  ");
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition (leftShift,i+2);
            if (array[i, j] != 0) Console.Write($"{array[i, j],5}");
            leftShift += width*2;
        }
        leftShift = width*array.GetLength(0)-width*(i+1);
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Выводим N строк (начиная с 0) в треугольнике Паскаля");
Console.Write("Введите целое N(>1)=> ");

int N = Convert.ToInt32(Console.ReadLine());

int[,] triangle = new int[N, N];
triangle[0, 0] = 1; triangle[1, 0] = 1; triangle[1, 1] = 1;

for (int i = 2; i < N; i++)
{
    triangle[i, 0] = 1; triangle[i, i] = 1;
    for (int j = 1; j < N - 1; j++)
    {
        triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1];
    }
}


PrintArray(triangle);
