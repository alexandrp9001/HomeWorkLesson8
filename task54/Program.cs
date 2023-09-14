
Console.WriteLine("Введите размерность массива:");
int height = Convert.ToInt32(Console.ReadLine());
int width = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[height, width];

Console.WriteLine("Введите элементы массива:");

// Ввод элементов массива
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

// Сортировка
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width - 1; j++)
    {
        if (arr[i, j] < arr[i, j + 1])
        {
            int temp = arr[i, j];
            arr[i, j] = arr[i, j + 1];
            arr[i, j + 1] = temp;
        }
    }
}

// Вывод отсортированного массива
Console.WriteLine($"Отсортированный массив: \n");
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(arr[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
