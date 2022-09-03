// =========================================================================
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// =========================================================================


// запрашивает число у пользователь (принимает текст запроса, количество знаков и команду выхода)
int RequestNumber(string text = "Enter number", int size = 0, string exitCmd = "q")
{
    // цикл выполняется пока пользователь не введет целое число или команду выхода
    while (true)
    {
        Console.Write($"{text} или '{exitCmd}' для выхода из программы: ");
        string? inputLine = Console.ReadLine();

        // выход из программы
        if (inputLine.ToLower() == exitCmd)
        {
            Environment.Exit(0);
        }
        // проверка количества знаков
        if (size > 0 && inputLine.Length != size)
        {
            continue;
        }
        // возвращаем введеное число
        if (int.TryParse(inputLine, out int inputNumber))
        {
            return inputNumber;
        }
    }
}


// возвращает 2-й знак 3-х значного числа
int secondDigit(int num)
{
    return num / 10 % 10;
}


// Выводим 2-й знак введенного 3-х значного числа
Console.WriteLine(secondDigit(RequestNumber("Введите трех значное целое число", 3)));