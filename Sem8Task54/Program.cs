// ====================================================================
// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// ====================================================================


// Создает двумерный массив размером m×n
int[,] GenerateArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    Random rand = new Random();
    int[,] array = new int[countRow, countColumn];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(downBorder, topBorder + 1);
        }
    }
    return array;
}


// упорядочит по убыванию элементы каждой строки двумерного массива
int[,] SortInRows(int[,] array)
{
    List<int> rowElements = new List<int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // заполняем список элементами строки
            rowElements.Add(array[i, j]);
        }

        rowElements.Sort();

        for (int k = 0; k < array.GetLength(1); k++)
        {
            // перезаписываем строку элементами отсортированного списка начиная с конца
            array[i, array.GetLength(1) - 1 - k] = rowElements[k];
        }

        // очищаем список
        rowElements.Clear();
    }
    return array;
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



int[,] array = GenerateArray(10, 10, 0, 10);

Console.WriteLine("\n------- Исходный массив -------\n");
Print2DArray(array);

Console.WriteLine("\n------- Отсортированный массив -------\n");
Print2DArray(SortInRows(array));