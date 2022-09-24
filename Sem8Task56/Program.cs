// ====================================================================
// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов. 
// ====================================================================


// Создает двумерный массив размером m×n
int[,] GenerateArray(int countRow, int countColumn,  int downBorder, int topBorder)
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


// возвращает сумму элементов строки
int RowSum(int[,] array, int row)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[row, i];
    }
    return sum;
}


// находит строку с наименьшей суммой элементов
int IndexRowWithMinSum(int[,] array)
{
    int bufSum = 0;
    int minSum = RowSum(array, 0);
    int rowIndex = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        bufSum = RowSum(array, i);
        if (bufSum < minSum)
        {
            minSum = bufSum;
            rowIndex = i;
        }
    }
    return rowIndex;
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


// вывод ответа
void PrintAnswer(int answer, string title = "")
{
    Console.WriteLine($"{title} -> {answer}");
}



int[,] array = GenerateArray(3, 3, 0, 10);

Console.WriteLine("\n------- Массив -------\n");
Print2DArray(array);

PrintAnswer(IndexRowWithMinSum(array) + 1, "строка с минимальной суммой элементов");