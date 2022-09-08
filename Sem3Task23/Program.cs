// =======================================================================================
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N с значениями друг над другом.
// =======================================================================================


// чтение челого числа из сонсоли
int ReadIntData(string line, int numLength = 0)
{
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);

    // Считываем данные, проверяем число ли это и количество знаков
    // (если < 1, то любое)
    if (int.TryParse(Console.ReadLine(), out int number) &&
        numLength > 0 ? (int)Math.Log10(number) + 1 == numLength : true)

    {
        return number; // Возвращаем значение 
    }
    return -1; // если значение некорректно
}


// вывод таблицы
void PrintPowTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            PrintColumn(i);
        }
        CursorOffset(0, 4, true);
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
    }
}


// вывод столбца
void PrintColumn(int num)
{
    int value = (int)Math.Pow(num, 3); //получаем куб числа
    Console.Write(num); //вывод числа
    CursorOffset(0 - ((int)Math.Log10(num) + 1), 2); // сдвигаем курсор
    Console.Write(value); // вывод куба
    CursorOffset(3, -2);
}


//смещение курсора
void CursorOffset(int leftOffset, int topOffset, bool isNewLine = false)
{
    (int left, int top) = Console.GetCursorPosition(); // текущее положение курсора
    if (isNewLine) // перевод на новую строку
    {
        left = 0;
    }
    // смещаем курсор
    Console.SetCursorPosition(left + leftOffset, top + topOffset);
}


void Program()
{
    Console.Clear();
    int number = ReadIntData("Введите число");
    CursorOffset(0, 1);
    PrintPowTable(number);

}


Program();