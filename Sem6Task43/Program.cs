// ====================================================================
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых.
// ====================================================================
using Values;
using Utils;


// чтение данных из сонсоли, возвращает
// Определение <число А, число В, знак операции>
LineValues ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";

    // парсим полученную строку
    string[] inputLineItems = inputLine.Split(",");

    return new LineValues(
            k1: double.Parse(inputLineItems[0]),
            b1: double.Parse(inputLineItems[1]),
            k2: double.Parse(inputLineItems[2]),
            b2: double.Parse(inputLineItems[3])
           );
}


// поиск пересечения двух прямых
PointCoordinates FindCrossingOfTwoLines(LineValues values)
{
    double pointCoordX = (values.B2 - values.B1) / (values.K1 - values.K2);
    double pointCoordY = values.K1 * pointCoordX + values.B1;

    return new PointCoordinates(x: pointCoordX, y: pointCoordY);
}


// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}


LineValues lineValues = ReadData("Введите значения k1, b1, k2 и b2 через запятую");

new LinearFunctionPrinter(12)
    .AddLinearFunction(lineValues.K1, lineValues.B1)
    .AddLinearFunction(lineValues.K2, lineValues.B2)
    .printChart();

PrintAnswer($"({FindCrossingOfTwoLines(lineValues)})",
            $"Координаты точки пересечения двух прямых {lineValues}");