// ====================================================================
// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце
// Пример: Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//
//* Дополнительно вывести среднее арифметическое по диагоналям и 
// диагональ выделить разным цветом.
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


// Возвращает среднее арифметическое элементов в каждом столбце
double[] AverageOfColumns(int[,] array)
{
    double[] averages = new double[array.GetLength(1)];

    // проходит по всем колонкам
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;

        // проходит по всем элементам в колонке
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        averages[i] = sum / array.GetLength(0);
    }

    return averages;
}


// Возвращает среднее арифметическое элементов по диаганалям
(double downDiagonalAverage, double upDiagonalAverage) AverageOfDiagonals(int[,] array)
{
    double downDiagonalSum = 0;
    double upDiagonalSum = 0;
    int downDiagonalCount = 0;
    int upDiagonalCount = 0;


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            // элемент нисходящей диагонали
            if (i == j)
            {
                downDiagonalSum += array[i, j];
                downDiagonalCount++;
            }

            //элемент восходящей диагонали
            if (i == array.GetLength(1) - 1 - j)
            {
                upDiagonalSum += array[i, j];
                upDiagonalCount++;
            }
        }
    }
    return (downDiagonalSum / downDiagonalCount, upDiagonalSum / upDiagonalCount);
}


// вывод двумерного массива
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            // элемент нисходящей диагонали
            if (i == j)
                Console.ForegroundColor = ConsoleColor.Blue;

            // элемент восходящей диагонали
            if (i == array.GetLength(1) - 1 - j)
                Console.ForegroundColor = ConsoleColor.Green;

            Console.Write($"{array[i, j]} ");
            Console.ResetColor();

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



int[,] array = GenerateArray(5, 5, 0, 10);
Console.WriteLine("\n----- Исходный массив -----\n");
Print2DArray(array);

double[] averageOfColumns = AverageOfColumns(array);

for (int i = 0; i < averageOfColumns.Length; i++)
{
    PrintAnswer(Math.Round(averageOfColumns[i], 1).ToString(), $"Cреднее арифметическое элементов в {i + 1} столбце");
}

(double downDiagonalAverage, double upDiagonalAverage) = AverageOfDiagonals(array);
PrintAnswer(Math.Round(downDiagonalAverage, 1).ToString(), $"Cреднее арифметическое элементов нисходящей диагонали");
PrintAnswer(Math.Round(upDiagonalAverage, 1).ToString(), $"Cреднее арифметическое элементов восходящей диагонали");