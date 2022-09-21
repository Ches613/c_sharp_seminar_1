// ====================================================================
// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
// ====================================================================


// чтение данных из сонсоли
int ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";

    return int.Parse(inputLine);
}


// Создает двумерный массив чисел Фибоначчи
long[,] Generate2DArrayOfFibonacciNums(int countRow, int countColumn)
{
    long[,] fibNums = new long[countRow, countColumn];
    long first = 1;
    long last = 1;
    long buf = 0;
    fibNums[0, 0] = 0;
    fibNums[0, 1] = 1;
    for (int i = 0; i < fibNums.GetLength(0); i++)
    {
        // если первая строка, то начинаем с индекса 2
        for (int j = (i == 0) ? 2 : 0; j < fibNums.GetLength(1); j++)
        {
            fibNums[i, j] = last;
            buf = first + last;
            first = last;
            last = buf;
        }
    }
    return fibNums;
}


// Вывод двумерного массива. 
// если number содержится в массиве, подсвечивает его и возвращает true
bool Print2DArrayAndFindNumber(long[,] array, int number)
{
    bool isContains = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                isContains = true;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
     Console.ResetColor();
    return isContains;
}


// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("{0} -> {1}", title, answer);
    Console.ResetColor();
}


int number = ReadData("Введите число");

bool isContains = Print2DArrayAndFindNumber(Generate2DArrayOfFibonacciNums(6, 6), number);

if (!isContains)
{
    PrintAnswer("такого числа в массиве нет", number.ToString());
}