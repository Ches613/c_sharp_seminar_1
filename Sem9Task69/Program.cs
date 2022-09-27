// ====================================================================
// Напишите программу, принимает A и B и возвращает а в степени ,
// ====================================================================


// чтение данных из сонсоли
(int a, int b) ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";

    // парсим полученную строку
    string[] inputLineItems = inputLine.Split(",");

    return (int.Parse(inputLineItems[0]), int.Parse(inputLineItems[1]));
}


// возвращает a в степени b
double RecPow(double a, double b)
{
    return (b == 0) ? 1 : (b % 2 == 0) ? RecPow(a * a, b / 2) : RecPow(a, b - 1) * a;
}


// Вывод в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}
(int a, int b) = ReadData("Введите числа А и B через запятую");

DateTime d1 = DateTime.Now;
PrintResult(RecPow(a, b).ToString());
PrintResult((DateTime.Now -  d1).ToString());