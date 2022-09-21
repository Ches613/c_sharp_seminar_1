// ====================================================================
// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами
// * При выводе матрицы показывать каждую цифру разного цвета
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


// Создает двумерный массив случайных вещественных числел размером m × n
double[,] Generate2DArrayOfDouble(int countRow, int countColumn, int downBorder, int topBorder)
{
    Random rand = new Random();
    double[,] array = new double[countRow, countColumn];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() * (topBorder - downBorder) + downBorder, 1);
        }
    }
    return array;
}


// вывод двумерного массива
void Print2DArray(double[,] array)
{
    // Массив всех доступных цветов консоли
    ConsoleColor[] consoleColors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();
    int colorCount = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // перебирает цветов по очереди
            Console.ForegroundColor = consoleColors[colorCount < consoleColors.Length ? colorCount++ : colorCount = 0];

            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}


(int m, int n) = ReadData("Введите через запятую размер двумерного массива m x n");
Print2DArray(Generate2DArrayOfDouble(m, n, -9, 9));