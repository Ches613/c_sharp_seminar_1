// ====================================================================
// Задайте двумерный массив. Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д.
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

// сумму элементов, находящихся на главной диагонали
int SumOfMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum += array[i, i];
    }

    return sum;
}


// вывод двумерный массив
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ResetColor();
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
     Console.ResetColor();
}

// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}


(int m, int n) = ReadData("Введите через запятую размер двумерного массива m x n");
int[,] array = GenerateArray(m, n, 0, 10);
Console.WriteLine("\n----- Исходный массив -----\n");
Print2DArray(array);
PrintAnswer(SumOfMainDiagonal(array).ToString(), "Cумму элементов, находящихся на главной диагонали");