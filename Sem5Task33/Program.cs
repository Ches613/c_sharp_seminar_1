// ====================================================================
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
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

// определяет является ли value элементом массива
bool Contains(int[] array, int value)
{
    foreach (int item in array)
    {
        if(item == value)
        return true;
    }
    return false;
}

// вывод массив
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// вывод ответа
void PrintAnswer(bool answer)
{
    Console.WriteLine(answer ? "Да" : "Нет");
}


int elem = 9;
int[] array = FillArray(10, 0, 10);
Print1DArray(array);
Console.Write($"Число {elem} -> ");
PrintAnswer(Contains(array, elem));