// ====================================================================
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// ====================================================================


// Универсальный метод генерации и заполнение массива
int[] FillArray(int length,int topBorder, int downBorder)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}

// изменяет знак всех положительных элементов
void InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) array[i] = array[i] * -1;
    }
}


// вывод массив
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}


int[] array = FillArray(10, -9, 9);
Print1DArray(array);
InverseArray(array);
Print1DArray(array);