// ====================================================================
// Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе. * Сделать оценку времени алгоритма через
// вещественные числа и строки
// ====================================================================


// чтение целого числа из консоли
int ReadIntData(string line)
{
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);

    // Считываем данные
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number; // Возвращаем значение 
    }
    return -1; // если значение некорректно
}


// расчет суммы цифр
int CalculateSumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}


// расчет суммы цифр через строку
int CalculateSumOfDigitsStr(int number)
{
    string digits = number.ToString();
    double sum = 0;
    for (int i = 0; i < digits.Length; i++)
    {
        sum += Char.GetNumericValue(digits, i);
    }
    return (int)sum;
}


// вывод результата
void PrintResult(int sum)
{
    Console.WriteLine(sum);
}


int number = ReadIntData("Введите число");

DateTime d1 = DateTime.Now;

// PrintResult(CalculateSumOfDigits(number));
PrintResult(CalculateSumOfDigitsStr(number));

Console.WriteLine(DateTime.Now - d1);