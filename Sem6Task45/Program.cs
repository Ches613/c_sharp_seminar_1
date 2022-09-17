// ====================================================================
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// * Отсортируйте массив методом вставки и методом подсчета, а затем 
// найдите разницу между первым и последним элементом. Для задачи со 
// звездочкой использовать заполнение массива целыми числами.
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


// создает копию массива
int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}

// вывод массив вещественныx чисел
void Print1DArray(int[] array, string title = "")
{
    PrintAnswer($"[{string.Join(", ", array)}]", title);
}


int[] array = FillArray(10, 0, 1000);
Print1DArray(array, "Исходный массив");
Print1DArray(CopyArray(array), "Копия массива");