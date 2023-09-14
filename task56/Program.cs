
Console.WriteLine("Введите количество строк и столбцов массива:");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

Console.WriteLine("Введите элементы массива:");

// Ввод элементов массива
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

// Находим строку с минимальной суммой элементов
int minSum = Int32.MaxValue;
int sum = 0;
for (int row = 0; row < rows; row++)
{
    sum = 0;
    for (int col = 0; col < columns; col++)
    {
        sum += array[row, col];
    }
    if (sum < minSum)
    {
        minSum = sum;
    }
}

Console.WriteLine($"Минимальная сумма: {minSum}");
Console.ReadKey();
