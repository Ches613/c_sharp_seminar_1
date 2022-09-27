// =======================================================================
// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
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
//Возвращает сумму натуральных элементов в промежутке от m до n.
int SumOfNaturalElements(int m, int n)
{
    return m == n ? n : n + SumOfNaturalElements(m, n - 1);
}


// Вывод в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}


(int m, int n) = ReadData("Введите числа M и N через запятую");
PrintResult($"M = {m}; N = {n} -> {SumOfNaturalElements(m, n)}");