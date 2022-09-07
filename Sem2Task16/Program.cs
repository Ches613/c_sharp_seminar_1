// =======================================================================================
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого. 
// =======================================================================================

// чтение данных из сонсоли
int ReadData(string line)
{
    Console.Write(line + ": ");
    int number = int.Parse(Console.ReadLine()??"");
    return number;
}

// Определяем кратность чисел
bool SqrTest(int firstNumber, int secondNumber)
{
    return firstNumber == secondNumber * secondNumber;
}

// Вывод данных
void PrintData(int firstNumber, int secondNumber)
{
    if (SqrTest(firstNumber, secondNumber))
    {
        Console.WriteLine($"Число {firstNumber} квадрат {secondNumber}");
    }else{
        Console.WriteLine($"Число {firstNumber} не квадрат {secondNumber}");
    }
}


int num1 = ReadData("Введите первое число");
int num2 = ReadData("Введите второе число");
PrintData(num1, num2);