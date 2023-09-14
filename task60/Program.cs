using System;

class Program
{
    static void Main()
    {
        int[][][] threeDArray = new int[2][][];

        for (int i = 0; i < threeDArray.Length; i++)
        {
            threeDArray[i] = new int[2][];
            for (int j = 0; j < threeDArray[i].Length; j++)
            {
                threeDArray[i][j] = GetUniqueDigits(i, j);
            }
        }

        foreach (var subArray in threeDArray)
        {
            Console.WriteLine("Subarray:");
            foreach (var array in subArray)
            {
                Console.Write("[" + array.Length + "]");
                foreach (var num in array)
                {
                    Console.Write(num.ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }
    }

    private static int[] GetUniqueDigits(int row, int col)
    {
        List<int> uniqueDigits = new List<int>();

        while (uniqueDigits.Count < 2)
        {
            int candidate = (row * 10) + col;
            if (!uniqueDigits.Contains(candidate))
            {
                uniqueDigits.Add(candidate);
            }

            col++;

            if (col == 10)
            {
                col = 0;
                row++;
            }
        }

        return uniqueDigits.ToArray();
    }
}