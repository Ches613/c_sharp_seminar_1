// ====================================================================
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых.
// ====================================================================
using Values;


// чтение данных из сонсоли, возвращает
// Определение <число А, число В, знак операции>
LinesValue ReadData(string line)
{
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";

    // парсим полученную строку
    string[] inputLineItems = inputLine.Split(",");

    return new LinesValue(
            b1: double.Parse(inputLineItems[0]),
            k1: double.Parse(inputLineItems[1]),
            b2: double.Parse(inputLineItems[2]),
            k2: double.Parse(inputLineItems[3])
           );
}


// поиск пересечения двух прямых
PointCoord FindPointOfTwoLines(LinesValue values)
{
    double pointCoordX = (values.B2 - values.B1) / (values.K1 - values.K2);
    double pointCoordY = values.K1 * pointCoordX + values.B1;

    return new PointCoord(x: pointCoordX, y: pointCoordY);
}


// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}


LinesValue linesVal = ReadData("Введите значения b1, k1, b2 и k2 через запятую");
PointCoord pointCoord = FindPointOfTwoLines(linesVal);

PrintAnswer($"({pointCoord})",
            $"Координаты точки пересечения двух прямых {linesVal}");