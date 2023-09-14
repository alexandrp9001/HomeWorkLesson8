using System;
using static System.Console;
using System.Numerics;

public class MatrixMultiplication
{
    public static void Main()
    {
        // Создаем матрицы
        int[,] matrix1 = {
            { 1, 2 },
            { -1, -2 },
        };

        int[,] matrix2 = {
            { 4, 5 },
            { 7, 8 },
        };

        WriteLine("Матрица 1:");
        WriteMatrix(matrix1);
        WriteLine();

        WriteLine("Матрица 2:");
        WriteMatrix(matrix2);
        WriteLine();

        Vector2[] row1 = new Vector2[2];
        row1[0] = new Vector2(1, 0);
        row1[1] = new Vector2(-1, 0);
        Vector2[] col1 = new Vector3(4, 7);

        var result = MatrixMultiplication.VectorMultiply(row1, col1);

        WriteLine($"Результат умножения: {result}");
    }

    public static Vector2 VectorMultiply(Vector2 row, Vector2 col)
    {
        double result = 0;
        for (int i = 0; i < 2; i++)
        {
            result += row[i] * col[i];
        }
        return new Vector2(result);
    }
}