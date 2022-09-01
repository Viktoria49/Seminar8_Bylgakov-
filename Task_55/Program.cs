// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int m = 0;
int n = 0;
Console.WriteLine("Enter M: ");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Enter N: ");
int.TryParse(Console.ReadLine(), out n);

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

void ChangeArray(int [,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Unable to change Matrix");
        return;
    }
    
    for (int i = 0; i < m; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            int temp = array[i, j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array2D);
Console.WriteLine();
ChangeArray(array);
PrintMatrix(array2D);