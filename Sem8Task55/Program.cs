// ====================================================================
// Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа должна 
// вывести сообщение для пользователя.
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


// проверка на возможность разворота матрицы
bool TestRotate(int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);
}

// Разворот матрицы
int[,] RotateArray(int[,] array)
{
    int buf = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            buf = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = buf;
        }
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



int[,] array = GenerateArray(5, 3, 0, 10);

Console.WriteLine("\n------- Исходная матрица -------\n");
Print2DArray(array);

if (TestRotate(array))
{
    Console.WriteLine("\n------- Перевернутая матрица -------\n");
    Print2DArray(RotateArray(array));
}
else
{
    Console.WriteLine("\nДанную матрице перевернуть нельзя");
}