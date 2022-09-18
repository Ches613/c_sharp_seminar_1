// ====================================================================
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых.
// ====================================================================
using Values;


// чтение данных из сонсоли
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
            k2: double.Parse(inputLineItems[3]),
            b3: double.Parse(inputLineItems[4]),
            k3: double.Parse(inputLineItems[5])
           );
}


// поиск координат точек пересечений прямых
PointCoord[] FindTrianglePoints(LinesValue values)
{
    double pointACoordX = (values.B2 - values.B1) / (values.K1 - values.K2);
    double pointACoordY = values.K1 * pointACoordX + values.B1;

    double pointBCoordX = (values.B2 - values.B3) / (values.K3 - values.K2);
    double pointBCoordY = values.K3 * pointBCoordX + values.B3;

    double pointCCoordX = (values.B3 - values.B1) / (values.K1 - values.K3);
    double pointCCoordY = values.K1 * pointCCoordX + values.B1;

    PointCoord[] points = new PointCoord[]
    {
       new PointCoord(x: pointACoordX, y: pointACoordY),
       new PointCoord(x: pointBCoordX, y: pointBCoordY),
       new PointCoord(x: pointCCoordX, y: pointCCoordY)
    };

    return points;
}


// расстояние между двумя точками
double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}


// площадь треугольника по 3-м точкам
double AreaOfTriangle(PointCoord[] pointsCoord)
{
    double A = Distance(
        x1: pointsCoord[0].X,
        y1: pointsCoord[0].Y,
        x2: pointsCoord[1].X,
        y2: pointsCoord[1].Y
    );
    double B = Distance(
        x1: pointsCoord[1].X,
        y1: pointsCoord[1].Y,
        x2: pointsCoord[2].X,
        y2: pointsCoord[2].Y
    );
    double C = Distance(
        x1: pointsCoord[0].X,
        y1: pointsCoord[0].Y,
        x2: pointsCoord[2].X,
        y2: pointsCoord[2].Y
    );
    double P = (A + B + C) / 2;
    return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
}


// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}


LinesValue linesVal = ReadData("Введите значения b1, k1, b2 и k2, b3, k3 через запятую");
double S = AreaOfTriangle(FindTrianglePoints(linesVal));

PrintAnswer($"{Math.Round(S, 2)}", $"Площадь треугольника вписанного в прямые {linesVal}");