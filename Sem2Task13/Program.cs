// =========================================================================
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// =========================================================================


// запрашивает число у пользователь (принимает текст запроса и команду выхода)
long RequestNumber(string text = "Enter number", string exitCmd = "q")
{
    // цикл выполняется пока пользователь не введет целое число или команду выхода
    while (true)
    {
        Console.Write($"{text} или '{exitCmd}' для выхода из программы: ");
        string inputLine = Console.ReadLine() ?? "0";

        // выход из программы
        if (inputLine.ToLower() == exitCmd)
        {
            Environment.Exit(0);
        }
        // возвращаем введеное число
        if (long.TryParse(inputLine, out long inputNumber))
        {
            return inputNumber;
        }
    }
}


// возвращает 3-ю цифру числа
int ThirdDigit(long num)
{
    int numLenght = (int)Math.Ceiling(Math.Log10(num)); // получаем количество цифр
    switch (numLenght)
    {
        case > 3: // если больше 3-х цифр, вычисляем по формуле
            return (int)(num / Math.Pow(10, numLenght - 3)) % 10;
        case 3: // если 3 цифры, возвращаем остаток от деления на 10
            return (int)(num % 10);
        default: // если меньше 3-х
            return -1;
    }
}


// вывод ответа
void PrintAnswer(int answerNumber)
{
    Console.WriteLine(answerNumber > -1 ? answerNumber : "третьей цифры нет");
}


// Выводим 3-ю цифру числа
PrintAnswer(ThirdDigit(RequestNumber("Введите целое число")));