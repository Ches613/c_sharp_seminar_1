// =======================================================================
// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// =======================================================================


// чтение данных из сонсоли
int ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";
    return int.Parse(inputLine);
}


// Возвращает строку чисел от N до 1
string LineGenRec(int numN)
{
    return (numN == 0) ? "" : (numN + " " + LineGenRec(numN - 1));
}


// Вывод в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}


PrintResult(LineGenRec(ReadData("Введите число N")));