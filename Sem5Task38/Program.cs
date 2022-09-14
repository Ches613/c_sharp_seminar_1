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


// Универсальный метод генерации и заполнение массива 
// вещественными числами
double[] FillArrayOfDoubleNumbers(int length)
{
    Random rand = new Random();
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 100, 1);
    }
    return array;
}


// Разница между максимальным и минимальным значениями массива
double DiffOfMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return Math.Round(max - min, 1);
}

// Сортировка вставками
long InsertionSort(int[] array)
{
    int temp = 0;
    long count = 0; // подсчет количества итераций
    // для каждого числа в массиве
    for (int i = 0; i < array.Length; i++)
    {
        // проходим в обратном направлении пока не достигним 
        // меньшего числа или начала массива
        for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
        {
            // меняем местами
            count++;
            temp = array[j];
            array[j] = array[j - 1];
            array[j - 1] = temp;
        }
    }
    return count;
}

// простая сортировка методом подсчета
long CountingSort(int[] array, int maxValue)
{
    // временный массив для подсчета количества чисел
    int[] numCountArray = new int[maxValue + 1];
    long count = 0; // количество итераций
    int position = 0;

    // для каждого числа в массиве
    for (int i = 0; i < array.Length; i++)
    {
        // индекс числа соответствует числу, 
        // а значение количеству повторений в исходном массиве
        numCountArray[array[i]] += 1;
        count++;
    }

    // проходим все числа до maxValue
    for (int num = 0; num < numCountArray.Length; num++)
    {
        // вставляем числа в исходный массив
        for (int j = 0; j < numCountArray[num]; j++)
        {
            array[position] = num;
            position++;
            count++;
        }
    }
    return count;
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

// вывод массив
void Print1DArrayOfDouble(double[] array, string title = "")
{
    PrintAnswer($"[{string.Join(", ", array)}]", title);
}

// основное задание
void MainTask()
{
    Console.WriteLine("\n================= ОСНОВНОЕ ЗАДАНИЕ ================= ");
    double[] arrayOfDouble = FillArrayOfDoubleNumbers(10);

    Print1DArrayOfDouble(arrayOfDouble, "Исходный массив вещественныx чисел");

    PrintAnswer(DiffOfMinMax(arrayOfDouble).ToString(), 
                "Разница между максимальным и минимальным значениями массива");
}

// задание метод сортировки вставками
void InsertionSortTask(int[] array, bool printSorted = false)
{
    Console.WriteLine("------------- Сортировка вставками ------------- ");
    TimeSpan InsertionSortTime;

    DateTime dtStart = DateTime.Now;
    long InsertionSortCount = InsertionSort(array);
    InsertionSortTime = DateTime.Now - dtStart;

    if (printSorted)
        Print1DArray(array, "Отсортированный вставками массив целых чисел");

    PrintAnswer(InsertionSortCount.ToString(), "Количество итераций цикла");
    PrintAnswer(InsertionSortTime.ToString(), "Время выполнения сортировки вставками");
}

// задание метод сортировки подсчетом
void CountingSortTask(int[] array, int maxValueOfNumber, bool printSorted = false)
{
    Console.WriteLine("------------- Сортировка подсчетом ------------- ");
    TimeSpan CountingSortTime;

    DateTime dtStart = DateTime.Now;
    long CountingSortCount = CountingSort(array, maxValueOfNumber);
    CountingSortTime = DateTime.Now - dtStart;

    if (printSorted)
        Print1DArray(array, "Отсортированный методом подсчета массив целых чисел");

    PrintAnswer(CountingSortCount.ToString(), "Количество итераций цикла ");
    PrintAnswer(CountingSortTime.ToString(), "Время выполнения сортировки методом подсчета");
}

// тест скорости
void speedTest(int arrayLength, int maxValue, bool printArrays = false)
{
    Console.WriteLine("\n================= ТЕСТ СКОРОСТИ ================= ");
    int[] array = FillArray(arrayLength, 0, maxValue);
    int[] arrayClone = (int[])array.Clone();

    if (printArrays)
        Print1DArray(array, "\nИсходный массив");

    Console.WriteLine($"число элементов  -> {arrayLength}");
    Console.WriteLine($"максимальное значение -> {maxValue}");

    CountingSortTask(array, maxValue, printArrays);
    InsertionSortTask(arrayClone, printArrays);
}


Console.Clear();
MainTask();
speedTest(10, 100, true);
// speedTest(100000, 1000);
// speedTest(100000, Int32.MaxValue / 2);
// speedTest(10000, Int32.MaxValue / 2);