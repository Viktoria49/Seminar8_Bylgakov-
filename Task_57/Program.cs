// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
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

int[] TransformMatrixToArray (int[,] matrix)
{
    int[] newArray = new int[matrix.GetLength(0)*matrix.GetLength(1)];
    int k =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[k] = matrix[i,j];
            k++;
        }
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    { 
        Console.Write($"{array[i]}, ");  
    }
    Console.WriteLine(); 
}

void PrintVocabulary (int[] array)
{
    int count = 1;
    int temp = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (temp != array[i]) 
        {
            Console.WriteLine($"Элемент {temp} встречается {count} раз");
            count = 1;
            temp = array[i];
        }
        else count++;
        
    }
    Console.WriteLine($"Элемент {temp} встречается {count} раз");
}


int[,] array2D = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] array1 = TransformMatrixToArray(array2D);
Array.Sort(array1);
PrintArray(array1);
PrintVocabulary(array1);