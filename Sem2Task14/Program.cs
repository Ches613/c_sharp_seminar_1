// =======================================================================================
// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23. 
// =======================================================================================

int number, resultA, resultB;


// запрашивает число у пользователья, в качестве аргумента принимает 
// текст и команду выхода из программы.
// возвращает введенное число
int RequestNumber(string text = "Enter number", string exitCmd = "q")
{
    while (true) // цикл выполняется пока пользователь не введет целое число или команду выхода
    {
        Console.Write(text + ": ");
        string? inputLine = Console.ReadLine();

        if (inputLine == null)
        {
            continue;
        }
        if (inputLine.ToLower() == exitCmd)
        {
            Environment.Exit(0);
        }
        if (int.TryParse(inputLine, out int number))
        {
            return number;
        }
    }
}

// чтение данных из сонсоли
void ReadData()
{
    number = RequestNumber("Введите целое число или 'q' для выхода");
}

// Определяем кратность чисел
void CalculateData()
{
    resultA = number % 7;
    resultB = number % 23;
}

// Вывод данных
void PrintData()
{
    if (resultA == 0 && resultB == 0)
    {
        Console.WriteLine("Число кртно 7 и 23");
    }
    else
    {
        Console.WriteLine("Число не кртно 7 и 23");
    }
}


ReadData();
CalculateData();
PrintData();