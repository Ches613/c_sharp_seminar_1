// ====================================================================
// Задайте одномерный массив, заполненный случайными числами. Найдите
// сумму элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю
// ====================================================================


// Универсальный метод генерации и заполнение массива
int[] FillArray(int length, int topBorder, int downBorder)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}


// подсчитывает сумму элементов, стоящих на нечётных позициях
int SumOfOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i + 1) % 2 != 0) sum += array[i];
    }
    return sum;
}

// поиск пар чисел в массива
List<(int Number, int FirstIndex, int SecondIndex)> FindPairsOfNumbers(int[] array)
{
    // список кртежей пар чисел с положением в массиве
    List<(int Number, int FirstIndex, int SecondIndex)> 
    pairs = new List<(int Number, int FirstIndex, int SecondIndex)>();

    // для каждого числа в массиве
    for (int i = 0; i < array.Length - 1; i++)
    {
        //все числа начиная со следующего после проверяемого
        for (int j = i + 1; j < array.Length; j++) 
        {
            if (array[i] == array[j]) // проверяем на парность
            {
                pairs.Add((array[i], i, j));
            }
        }
    }
    return pairs;
}


// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}


// вывод массив
void Print1DArray(int[] array, string title = "")
{
    PrintAnswer($"[{string.Join(", ", array)}]", title);
}


// вывод списка пар чисел массива
void PrintListOfPairs(List<(int Number, int FirstIndex, int SecondIndex)> pairs)
{
    Console.WriteLine("\nПары чисел в массиве в формате (число -> первый индекс в массиве, второй индекс):");
    pairs.Sort(); // сортируем для удобства
    
    // выводим значения в цикле
    foreach (var pair in pairs)
    {
        PrintAnswer($"{pair.FirstIndex}, {pair.SecondIndex}", pair.Number.ToString());
    }
}


int[] array = FillArray(10, 1, 10);
Console.Clear();
Print1DArray(array, "Исходный массив");
PrintAnswer(SumOfOddPositions(array).ToString(), "\nСумма элементов, стоящих на нечётных позициях");
PrintListOfPairs(FindPairsOfNumbers(array));