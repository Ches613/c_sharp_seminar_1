// ====================================================================
// Напишите программу, выведит числа от 1 до N
// ====================================================================


// чтение данных из сонсоли
int ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";
    return int.Parse(inputLine);
}

// Возвращает строку чисел от 1 до N
string LineGenRec(int numN)
{
    if (numN == 0) return "";
    string outLine = LineGenRec(numN - 1) + " " + numN;
    return outLine;
}

// Вывод в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

PrintResult(LineGenRec(ReadData("Введите число N")));