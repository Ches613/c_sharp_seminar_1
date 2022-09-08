// =======================================================================================
// №21 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек
// =======================================================================================


//чтение данных из сонсоли 
string ReadData(string line)
{
    //Выводим сообщение 
    Console.WriteLine(line + ": ");
    //Возвращаем значение 
    return Console.ReadLine() ?? "0";
}


// извлекаем координаты точек
(string[], string[]) PointParser(string line)
{
    // определяем начало и конец записи координат точек
    int startAPoint = line.IndexOf('(') + 1;
    int endAPoint = line.IndexOf(')');
    int startBPoint = line.LastIndexOf('(') + 1;
    int endBPoint = line.LastIndexOf(')');

    // разбиваем координаты на отдельные значения
    string[] pointA = line.Substring(startAPoint, endAPoint - startAPoint).Split(',');
    string[] pointB = line.Substring(startBPoint, endBPoint - startBPoint).Split(',');

    return (pointA, pointB);

}


// расчет расстояния между точками
double CalculateLength(string[] pointA, string[] pointB)
{
    return Math.Sqrt(
        Math.Pow(int.Parse(pointB[0]) - int.Parse(pointA[0]), 2) +
        Math.Pow(int.Parse(pointB[1]) - int.Parse(pointA[1]), 2) +
        Math.Pow(int.Parse(pointB[2]) - int.Parse(pointA[2]), 2)
        );
}


// вывод результата
void PrintResult(double length)
{
    Console.WriteLine("Расстояние межу точками равно {0}", Math.Round(length, 2));
}


void program()
{
    try
    {
        (string[] pointA, string[] pointB) = PointParser(ReadData("Введите координаты точек в формате A(x,y,z,);B(x,y,z)"));
        PrintResult(CalculateLength(pointA, pointB));
    }
    // если формат данных не позволяет считать значения
    catch (Exception ex)
    {
        if (ex is FormatException || ex is ArgumentOutOfRangeException)
        {
            Console.WriteLine("данный формат записи не поддерживается, возможно вы допустили ошибку!");
            return;
        }
        throw;
    }
}


program();