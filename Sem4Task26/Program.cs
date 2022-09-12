// =======================================================================================
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
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


// колличества цифр в числе через while
int NumberLength(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number = number/10;
    }
    return count;
}
// колличества цифр в числе через ToString
int NumberLengthCharArray(int number)
{
    return number.ToString().Length;
}

// колличества цифр в числе через Math.Log10
int NumberLengthLog10(int number)
{
    return (int)(Math.Log10(number)) + 1;
}


// вывод результата
void PrintResult(int sum)
{
    Console.WriteLine(sum);
}

int num = ReadIntData("Введите число");


DateTime d1 = DateTime.Now;

// PrintResult(NumberLengthLog10(num));
// Console.WriteLine(DateTime.Now-d1);

// PrintResult(NumberLengthCharArray(num));
// Console.WriteLine(DateTime.Now-d1);

PrintResult(NumberLength(num));
Console.WriteLine(DateTime.Now-d1);