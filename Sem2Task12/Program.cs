// =======================================================================================
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.
// =======================================================================================

int numberA, numberB, result;


// запрашивает число у пользователь, в качестве аргумента принимает текст запроса и команду выхода из программы.
int RequestNumber(string text = "Enter number", string exitCmd = "q")
{
    while (true) // код в цикле выполняется пока пользователь не введет целое число или команду выхода из программы
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
    numberA = RequestNumber("Enter number A");
    numberB = RequestNumber("Enter number B");
}

// Определяем кратность чисел
void CalculateData()
{
    result = numberB % numberA;
}

// Вывод данных
void PrintData()
{
    if (result == 0)
    {

        Console.WriteLine("Число B кртно числу A");
    }
    else
    {
        Console.WriteLine("Число B не кратно кртно числу A, остаток от деления " + result);
    }
}


ReadData();
CalculateData();
PrintData();