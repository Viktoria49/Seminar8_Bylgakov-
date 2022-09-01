// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mtx = CreateMatrixRandomInt(m, n, -9, 9);
Console.WriteLine("Иходная матрица: ");
PrintMatrix(mtx);
Console.WriteLine(" матрица: ");
int[,] newMtx = RemoveMinCrossover(mtx);
PrintMatrix(mtx);

static int RemoveMinCrossover(int[,] matrix)
{
    (int rowOfMin, int colOfMin) = FindMin(matrix);

    int rowsCount = matrix.GetLength(0);
    int colsCount = matrix.GetLength(1);
    int [,] result = new int [rowsCount - 1, colsCount - 1];

    for (int row = 0; row < rowsCount; row++)
    {
        for (int col = 0; col < colsCount; col++)
        {
            if (row == rowOfMin || col == colOfMin)
            continue;

            int newRow = row < rowOfMin ? row : row - 1;
            int newCol = col < colOfMin ? col : col - 1;
            result[newRow, newCol] = matrix[row, col];
        }
    }
    return result;
}

static (int row, int col) FindMin(int[,] matrix)
{
    int rowsCount = matrix.GetLength(0);
    int colsCount = matrix.GetLength(1);

    int rowOfMin = 0;
    int colOfMin = 0;

    int minValue = matrix[0,0];

}