// ===============================================================================
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// ===============================================================================


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


// преобразовывает десятичное число в двоичное
string DecToBin(int number)
{
    string binNumber = "";
    while (number > 0)
    {
        binNumber = number % 2 + binNumber;
        number = number / 2;
    }
    return binNumber;
}

// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}

int num = ReadIntData("Введите целое число");
PrintAnswer(DecToBin(num), num.ToString() + " в бинарном формате");