// ====================================================================
// Напишите программу, которая принимает на вход число (А) и выдаёт 
// сумму чисел от 1 до А.
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


// расчет суммы чисел от 1 до number
int CalculateSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}


// расчет суммы чисел по Гаусу
int CalculateSumGause(int number)
{
    return ((1 + number) * number)/2;
}


// вывод результата
void PrintResult(int sum)
{
    Console.WriteLine(sum);
}

int number = ReadIntData("Введите число");

DateTime d1 = DateTime.Now; 
PrintResult(CalculateSum(number));
Console.WriteLine(DateTime.Now-d1);

d1 = DateTime.Now; 
PrintResult(CalculateSumGause(number));
Console.WriteLine(DateTime.Now-d1);