// ==========================================================================================
// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
// ==========================================================================================


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


//  последнии 2 цифры палиндрома по первым 2-м
int SecondPartPalindrome(int firstPart)
{
    int secondPart = (firstPart % 10) * 10;
    return secondPart += firstPart / 10;
}


// формируем словарь палиндромов
HashSet<int> GeneratePalindromeHashSet()
{
    HashSet<int> palindromes = new HashSet<int>();

    // перебор значений первых 2-ух цифр 4-ех значных палиндромов
    foreach (int firstPart in Enumerable.Range(10, 90))
    {
        palindromes.Add(firstPart * 100 + SecondPartPalindrome(firstPart));
    }
    return palindromes;
}


// является ли число палиндромом
bool IsPalindrome(int number)
{
    //выбрасываем среднее число из number, проверяем
    return GeneratePalindromeHashSet().Contains(number / 1000 * 100 + number % 100);
}


// печатаем ответ
void PrintAnswer(int number)
{
    if (number != -1)
        Console.WriteLine(IsPalindrome(number) ? "Да" : "Нет");
    else
        Console.WriteLine("Введено некорректное значение");

}


PrintAnswer(ReadIntData("Введите пятизначное число", 5));