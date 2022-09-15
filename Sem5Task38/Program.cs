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

// метод сортировки выбором из лекции
long SelectionSort(int[] array)
{
    long count = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {

            if (array[j] < array[minPosition])
            {
                minPosition = j;
                count++;
            }
        }
        count++;
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
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
    TimeSpan deltaTime;

    DateTime dtStart = DateTime.Now;
    long InsertionSortCount = InsertionSort(array);
    deltaTime = DateTime.Now - dtStart;

    Console.WriteLine("------------- Сортировка вставками ------------- ");
    if (printSorted)
        Print1DArray(array, "Отсортированный вставками массив целых чисел");

    PrintAnswer(InsertionSortCount.ToString(), "Количество итераций цикла вставками");
    PrintAnswer(deltaTime.ToString(), "Время выполнения сортировки вставками");
}

// задание метод сортировки подсчетом
void CountingSortTask(int[] array, int maxValueOfNumber, bool printSorted = false)
{
    TimeSpan deltaTime;

    DateTime dtStart = DateTime.Now;
    long CountingSortCount = CountingSort(array, maxValueOfNumber);
    deltaTime = DateTime.Now - dtStart;

    Console.WriteLine("------------- Сортировка подсчетом ------------- ");
    if (printSorted)
        Print1DArray(array, "Отсортированный методом подсчета массив целых чисел");

    PrintAnswer(CountingSortCount.ToString(), "Количество итераций цикла ");
    PrintAnswer(deltaTime.ToString(), "Время выполнения сортировки методом подсчета");
}

// задание метод сортировки выбором из лекции
void SelectionSortTask(int[] array, bool printSorted = false)
{
    TimeSpan deltaTime;

    DateTime dtStart = DateTime.Now;
    long CountingSortCount = SelectionSort(array);
    deltaTime = DateTime.Now - dtStart;

    Console.WriteLine("------------- Сортировка выбором ------------- ");
    if (printSorted)
        Print1DArray(array, "Отсортированный методом выбора массив целых чисел");

    PrintAnswer(CountingSortCount.ToString(), "Количество итераций цикла выбором");
    PrintAnswer(deltaTime.ToString(), "Время выполнения сортировки методом выбора");
}

// тест скорости
void SpeedTest(int arrayLength, int maxValue, bool printArrays = false)
{
    Console.WriteLine("\n================= ТЕСТ СКОРОСТИ ================= ");
    int[] array = FillArray(arrayLength, 0, maxValue);
    int[] arrayClone = (int[])array.Clone();
    int[] arrayClone2 = (int[])array.Clone();

    if (printArrays)
        Print1DArray(array, "\nИсходный массив");

    Console.WriteLine($"число элементов  -> {arrayLength}");
    Console.WriteLine($"максимальное значение -> {maxValue}");

    new Thread(() => CountingSortTask(array, maxValue, printArrays)).Start();
    new Thread(() => InsertionSortTask(arrayClone, printArrays)).Start();
    new Thread(() => SelectionSortTask(arrayClone2, printArrays)).Start();
// SelectionSortTask(arrayClone2);
// InsertionSortTask(arrayClone, printArrays);
// CountingSortTask(array, maxValue, printArrays);
}


Console.Clear();
MainTask();
// SpeedTest(10, 100, true);
SpeedTest(100000, 1000);
// SpeedTest(100000, Int32.MaxValue / 2);
// SpeedTest(10000, Int32.MaxValue / 2);