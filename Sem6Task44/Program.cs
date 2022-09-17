// ===============================================================================
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// ===============================================================================


// чтение челого числа из сонсоли
int ReadIntData(string line, int numLength = 0)
{
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);

    // Считываем данные, проверяем число ли это и количество знаков
    // (если < 1, то любое)
    if (int.TryParse(Console.ReadLine(), out int number) &&
        numLength > 0 ? (int)Math.Log10(number) + 1 == numLength : true)

    {
        return number; // Возвращаем значение 
    }
    return -1; // если значение некорректно
}


// выводит первые N чисел Фибоначчи без рекурсии
int[] FibNums(int number)
{
    int[] fibNums = new int[number + 1];
    int first = 1;
    int last = 1;
    int buf = 0;
    fibNums[0] = 0;

    if (number < 1) return fibNums;
    
    fibNums[1] = 1;
    for (int i = 2; i < fibNums.Length; i++)
    {
        fibNums[i] = last;
        buf = first + last;
        first = last;
        last = buf;
    }
    return fibNums;
}

// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}


int[] fibNums = FibNums(ReadIntData("Введите целое число"));
for (int i = 0; i < fibNums.Length; i++)
{
    PrintAnswer(fibNums[i].ToString(), i.ToString());
}
