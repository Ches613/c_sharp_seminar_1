// ====================================================================
// Задайте массив из 12 элементов, заполненный случайными числами из
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных
// элементов массива.
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


// Универсальный метод генерации и заполнение массива
// на вход Tuple<нижняя граница, верхняя, int>
int[] FillArray(Tuple<int, int, int> param)
{
    Random rand = new Random();
    int[] array = new int[param.Item3];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(param.Item1, param.Item2 + 1);
    }
    return array;
}

// считает суммы отрицательных и положительных элементов массива
int[] NegativePositiveSum(int[] array)
{
    int[] sums = new int[] { 0, 0 };
    foreach (int num in array)
    {
        if (num > 0)
            sums[0] += num;
        else
            sums[1] += num;
    }
    return sums;
}


// вывод массив
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}


int[] array = FillArray(ReadData("Введите, нижнюю границу, верхнюю границу, " +
                               "длинну массива (через запятую)"));
Print1DArray(array);
Print1DArray(NegativePositiveSum(array));