// ====================================================================
// Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// ====================================================================


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


// расчет произведения от 1 до N
long CalculateMulti(int number)
{
    long multi = number;
    for (int i = number - 1; i > 0; i--)
    {
        multi = multi * i;
    }
    return multi;
}


// расчет произведения от 1 до N рекурсия
long CalculateMultiRecursion(int number)
{
    if (number > 1)
    {
        return number * CalculateMultiRecursion(--number);
    }
    else
    {
        return 1;
    }
}


// вывод результата
void PrintResult(long multi)
{
    Console.WriteLine(multi);
}

int number = ReadIntData("Введите число");

DateTime d1 = DateTime.Now;
PrintResult(CalculateMulti(number));
Console.WriteLine(DateTime.Now - d1);

d1 = DateTime.Now;
PrintResult(CalculateMultiRecursion(number));
Console.WriteLine(DateTime.Now - d1);