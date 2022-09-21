// ====================================================================
// Задайте двумерный массив размером m×n, заполненный случайными 
// целыми числами.
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
int[,] Generate2DArray(int countRow, int countColumn, int downBorder, int topBorder)
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
Print2DArray(Generate2DArray(m, n, -99, 99));