// ====================================================================
//  Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
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


// находит произведение двух матриц
static int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int aRows = matrixA.GetLength(0); int aCols = matrixA.GetLength(1);
    int bRows = matrixB.GetLength(0); int bCols = matrixB.GetLength(1);
    if (aCols != bRows)
        throw new ArgumentException("Non-conformable matrices in MatrixProduct");
    int[,] result = new int[aRows, bCols];
    for (int i = 0; i < aRows; ++i) // каждая строка A
        for (int j = 0; j < bCols; ++j) // каждый столбец B
            for (int k = 0; k < aCols; ++k)
                result[i, j] += matrixA[i, k] * matrixB[k, j];
    return result;
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
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine($"{title} -> {answer}");
}



int[,] firstMatrix = GenerateArray(2, 2, 0, 4);
int[,] secondMatrix = GenerateArray(2, 2, 0, 4);

Console.WriteLine("\n------- матрица 1 -------\n");
Print2DArray(firstMatrix);

Console.WriteLine("\n------- матрица 2 -------\n");
Print2DArray(secondMatrix);

try
{
    Console.WriteLine("\n------- Произвидение матриц -------\n");
    Print2DArray(MatrixProduct(firstMatrix, secondMatrix));
}
catch (System.ArgumentException)
{
    PrintAnswer("Эти матрицы не возмжно перемножить! <-");
}
