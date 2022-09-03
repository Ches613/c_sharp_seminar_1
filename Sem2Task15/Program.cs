// =========================================================================
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// =========================================================================


// запрашивает число у пользователь (принимает текст запроса и команду выхода)
int RequestNumber(string text = "Enter number", string exitCmd = "q")
{
    // цикл выполняется пока пользователь не введет целое число или команду выхода
    while (true)
    {
        Console.Write($"{text} или '{exitCmd}' для выхода из программы: ");
        string inputLine = Console.ReadLine() ?? "0";


        if (inputLine.ToLower() == exitCmd) // выход из программы
        {
            Environment.Exit(0);
        }
        if (int.TryParse(inputLine, out int inputNumber)) // введено целое число?
        {
            if (inputNumber > 0 && inputNumber < 8) // число является днем недели?
            {
                return inputNumber;
            } 
            else
            {
                Console.WriteLine("Такого дня недели нет!(");
            }
        }
    }
}


// проверка является ли num день выходным
bool IsWeekend(int num)
{
    var daysOfWeek = new Dictionary<int, bool>
    {
        {1, false},
        {2, false},
        {3, false},
        {4, false},
        {5, false},
        {6, true},
        {7, true},
    };
    return daysOfWeek[num];
}


// вывод ответа
void PrintAnswer(bool answer)
{
    Console.WriteLine(answer ? "да" : "нет");
}


// Выводим 3-ю цифру числа
PrintAnswer(IsWeekend(RequestNumber("Введите цифру, обозначающую день недели")));