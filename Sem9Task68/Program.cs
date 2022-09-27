// =======================================================================
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// =======================================================================


// чтение данных из сонсоли
(int m, int n) ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";

    // парсим полученную строку
    string[] inputLineItems = inputLine.Split(",");

    return (int.Parse(inputLineItems[0]), int.Parse(inputLineItems[1]));
}


//Возвращает результат функции Аккермана для m и n.
int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    else
        return -1;
}


// Вывод в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}


(int m, int n) = ReadData("Введите два неотрицательных числа m и n через запятую");

PrintResult($"m = {m}; n = {n} -> A(m,n) = {Ackermann(m, n)}");