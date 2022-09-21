// ====================================================================
// Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты
// ====================================================================


// чтение данных из сонсоли, возвращает
(int m, int n) ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";

    // парсим полученную строку
    string[] inputLineItems = inputLine.Split(",");

    return (int.Parse(inputLineItems[0]), int.Parse(inputLineItems[1]));
}


// Создает двумерный массив размером m×n
int[,] GenerateArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    Random rand = new Random();
    int[,] array = new int[countRow, countColumn];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(downBorder, topBorder+1);
        }
    }
    return array;
}

// замена элементов массива у которых оба индекса чётные, на их квадраты
int[,] ReplaceEvenIndexElementsOnSquares(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}


// вывод двумерный массив
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


(int m, int n) = ReadData("Введите через запятую размер двумерного массива m x n");
int[,] array = GenerateArray(m, n, 0, 9);
Console.WriteLine("\n----- Исходный массив -----\n");
Print2DArray(array);
Console.WriteLine("\n----- Результат -----\n");
Print2DArray(ReplaceEvenIndexElementsOnSquares(array));