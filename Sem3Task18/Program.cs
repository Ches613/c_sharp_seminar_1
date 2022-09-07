// =======================================================================================
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.  
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
string QuterBorderAsk(int numQuter)
{
    switch (numQuter)
    {
        case 1:
            return "x>0 && y>0";
        case 2:
            return "x<0 && y>0";
        case 3:
            return "x<0 && y<0";
        case 4:
            return "x>0 && y<0";

        default:
            return "";
    }
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numQuter = ReadData("Введите четверть");
PrintResult($"очики в четверти отвечают условие{QuterBorderAsk(numQuter)}");