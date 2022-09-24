// ====================================================================
// Задайте двумерный массив из целых чисел. Напишите программу, которая 
// удалит строку и столбец, на пересечении которых расположен наименьший 
// элемент массива.
// ====================================================================


// Создает двумерный массив размером m×n
int[,] GenerateArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    Random rand = new Random();
    int[,] array = new int[countRow, countColumn];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(topBorder, downBorder);
        }
    }
    return array;
}


// поиск минимального элемента
void FindMinElement(int[,] array, ref int row, ref int col)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                row = i;
                col = j;
            }

        }
    }
}


// удаляет строку и столбец, на пересечении которых расположен наименьший элемент массива
int[,] DeleteRowAndColumnByElement(int[,] array, int row, int col)
{
    int[,] outArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int m = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == row)
            continue;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == col)
                continue;
            else
            {
                outArray[k, m] = array[i, j];
                m++;
            }

        }
        m = 0;
        k++;
    }
    return outArray;
}


// вывод двумерного массива
void Print2DArray(int[,] array)
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



int[,] array = GenerateArray(5, 5, 0, 10);

Console.WriteLine("\n------- Исходный массив -------\n");
Print2DArray(array);
int row = 0;
int col = 0;
FindMinElement(array, ref row, ref col);
Console.WriteLine($"row = {row}; col = {col}");

Console.WriteLine("\n------- Преобразованный массив -------\n");

Print2DArray(DeleteRowAndColumnByElement(array, row, col));