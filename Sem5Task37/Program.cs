// ====================================================================
// Найдите произведение пар чисел в одномерном массиве. Парой считаем 
// первый и последний элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
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


// подсчитывает произведение пар чисел в одномерном массиве
int[] MultiOfPairsOfNumbers(int[] array)
{   
    int[] outArray = new int[(int)array.Length/2];
    for (int i = 0; i < outArray.Length; i++)
    {
        outArray[i] = array[i] * array[array.Length - i -1];
    }
    return outArray;
}

// вывод массив
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}


int[] array = FillArray(10, 0, 30);
Print1DArray(array);
Print1DArray(MultiOfPairsOfNumbers(array));