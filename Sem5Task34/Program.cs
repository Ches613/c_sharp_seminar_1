// ====================================================================
// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.
// * Отсортировать массив методом пузырька
// ====================================================================


// Mетод генерации и заполнения  массива 
// случайными положительными трёхзначными числами
int[] FillThreeDigitArray(int length)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = rand.Next(100, 1000);
    }
    return array;
}


// подсчитывает количество чётных чисел в массиве
int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

// сортировка методом пузырька
void BubbleSort(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
}

// вывод массив
void Print1DArray(int[] array, string title = "")
{
    Console.WriteLine("{0} -> [{1}]", title, string.Join(", ", array));
}

// вывод ответа
void PrintAnswer(int answer)
{
    Console.WriteLine(
        "Колличество трёхзначныx чётных чисел в массиве -> {0}",
        answer
     );
}


int[] array = FillThreeDigitArray(10);
Print1DArray(array);
PrintAnswer(CountEvenNumbers(array));
BubbleSort(array);
Print1DArray(array, "Сортированный массив методом пузырька");
