// ====================================================================
// Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.
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


// Меняет местами первую и последнюю строку массива.
int[,] ChangeFirstAndLastRow(int[,] array)
{
    int buf = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        buf = array[0, i];
        array[0, i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = buf;
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



int[,] array = GenerateArray(5, 5, 0, 10);

Console.WriteLine("\n----- Исходный массив -----\n");
Print2DArray(array);

Console.WriteLine("\n----- Изменненный массив -----\n");
Print2DArray(ChangeFirstAndLastRow(array));


