// ====================================================================
// Напишите программу, которая задаёт массив из 8 элементов и выводит 
// их на экран. * Ввести с клавиатуры длину массива и диапазон 
// значений элементов 
// ====================================================================


// чтение данных из сонсоли, возвращает
// Определение <начало диапазона, конец диапазона, длинна массива>
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

// Создаем массив принимает диапазот значений(от, до), длинна массива
int[] GenerateArray(Tuple<int, int, int> param)
{
    Random rand = new Random();
    int[] array = new int[param.Item3];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(param.Item1, param.Item2 + 1);
    }
    return array;
}


// вывод массив
void PrintArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}


void main()
{
    try
    {
        Tuple<int, int, int> param = ReadData("Введите через запятую начало диапазона " +
                                              "значений, конец диапазона, длинну массива");
        PrintArray(GenerateArray(param));
    }
    // была введена не корректная строка
    catch (System.FormatException)
    {
        Console.WriteLine("Вы ввели не корректные данные");
    }
}


main();