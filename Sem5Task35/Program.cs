// ====================================================================
// Задайте одномерный массив из 123 случайных чисел. Найдите количество
// элементов массива,
// значения которых лежат в отрезке [10,99].
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

// подсчитывает количество элементов в отрезке
int CountElement(int[] array, int min, int max)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item >= min && item <= max)
            count++;
    }
    return count;
}

// вывод массив
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// вывод ответа
void PrintAnswer(int answer)
{
    Console.WriteLine("Колличество элементов в отрезке [10,99] -> {0}", answer);
}


int[] array = FillArray(123, 0, 800);
Print1DArray(array);
PrintAnswer(CountElement(array, 10, 99));
