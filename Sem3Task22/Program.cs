// =======================================================================================
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов 
// чисел от 1 до N. 
// =======================================================================================

//чтение данных из сонсоли 
int ReadData(string line)
{
    //Выводим сообщение 
    Console.WriteLine(line + ": ");
    //Считываем число 
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение 
    return number;
}

// Печать Таблицы квадратов
void PrintPowTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        PrintColumn(i);
    }
    CursorOffset(0, 4, true);
}

// печатать колонки
void PrintColumn(int num)
{
    int value = (int)Math.Pow(num, 2);
    Console.Write(num);
    CursorOffset(0 - ((int)Math.Log10(num) + 1), 2);
    Console.Write(value);
    CursorOffset(3, -2);
}

//смещение курсора
void CursorOffset(int leftOffset, int topOffset, bool isNewLine =false)
{
    (int left, int top) = Console.GetCursorPosition();
    if (isNewLine)
    {
        left = 0;
    }
    Console.SetCursorPosition(left + leftOffset, top + topOffset);
}

Console.Clear();
int number = ReadData("Введите число");
CursorOffset(0, 1);
PrintPowTable(number);