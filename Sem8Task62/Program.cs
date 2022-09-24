// ====================================================================
// Напишите программу, которая заполнит спирально массив.
// ====================================================================


// чтение данных из сонсоли
(int countRow, int countColumn) ReadData(string line)
{    
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";

    // парсим полученную строку
    string[] inputLineItems = inputLine.Split(",");

    return (int.Parse(inputLineItems[0]), int.Parse(inputLineItems[1]));
}


// Создает двумерный спирально заполненный массив
int[,] FillSpirallyArray(int countRow, int countColumn)
{
    int count = 1;
    int startRow = 0; 
    int endRow = countRow - 1; 
    int startCol = 0; 
    int endCol = countColumn - 1;
    int[,] array = new int[countRow, countColumn];
    int maxValue = countRow * countColumn;

    // пока все элементы не заполнены
    while (count < maxValue)
    {
        // проход слева направо
        for (int i = startCol; i <= endCol; i++)
        {
            array[startRow, i] = count++;
        }

        // сдвигаем верхнюю границу к центру
        startRow++;

        // проход сверху вниз
        for (int j = startRow; j <= endRow; j++)
        {
            array[j, endCol] = count++;
        }

        // сдвигаем правую границу
        endCol--;

        // проход справа налево
        for (int i = endCol; i >= startCol; i--)
        {
            array[endRow, i] = count++;
        }

        // сдвигаем нижнюю границу
        endRow--;

        // проход снизу вверх
        for (int j = endRow; j >= startRow; j--)
        {
            array[j, startCol] = count++;
        }

        // сдвигаем левую границу
        startCol++;
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
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}


(int countRow, int countColumn) = ReadData("Введите размеры двумерного массива через запятую");
Print2DArray(FillSpirallyArray(countRow, countColumn));