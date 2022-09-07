// =======================================================================================
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве. 
// =======================================================================================

//чтение данных из сонсоли 
int ReadData(string line)
{
    //Выводим сообщение 
    Console.WriteLine(line + ": ");
    //Считываем число 
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение 
    return number;
}

// условия четверти
double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите x точки 1");

int y1 = ReadData("Введите y точки 1");

int x2 = ReadData("Введите x точки 2");

int y2 = ReadData("Введите y точки 2");
PrintResult($"Расстояние между точками равно {Math.Round(Distance(x1, y1, x2, y2), 2)}");