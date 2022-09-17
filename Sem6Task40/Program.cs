// ====================================================================
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// ====================================================================


// чтение данных из сонсоли, возвращает
// Определение <число А, число В, знак операции>
Tuple<int, int, int> ReadData(string line)
{
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";

    // парсим полученную строку
    string[] inputLineItems = inputLine.Split(",");

    return Tuple.Create(
            int.Parse(inputLineItems[0]),
            int.Parse(inputLineItems[1]),
            int.Parse(inputLineItems[2])
           );
}
// может ли существовать треугольник с сторонами такой длины
bool ExistTriangle(Tuple<int, int, int> lehgths)
{
    if (lehgths.Item1 + lehgths.Item2 > lehgths.Item3 &&
        lehgths.Item1 + lehgths.Item3 > lehgths.Item2 &&
        lehgths.Item2 + lehgths.Item3 > lehgths.Item1
    )
    {
        return true;
    }

    return false;
}


// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}
Tuple<int, int, int> lehgths = ReadData("Введите три числа через запятую");
PrintAnswer(
    ExistTriangle(lehgths) ? "Да" : "Нет",
    $"Могут ли числа {lehgths.Item1}, {lehgths.Item1}, {lehgths.Item1} быть сторонами треугольника"
    );