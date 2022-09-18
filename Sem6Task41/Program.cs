// ===============================================================================
//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
// ===============================================================================
using System.Text.RegularExpressions;


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


// возвращает строку введенную пользователем за NumOfChar нажатий
string LineOfNumOfChar(int NumOfChar)
{
    string ret = "";
    for (int i = 0; i < NumOfChar; i++)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        ret += key.KeyChar;

    }
    return ret;
}


// извлекает числа из строки
string[] parseString(string line)
{
    Regex extractNumberrRegex = new Regex(@"[-+]?[0-9]*\,?[0-9]+");
    return extractNumberrRegex.Matches(line)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
}


// подсчитывает количество чисел больше 0
int Count(string[] nums)
{
    int count = 0;
    foreach (string num in nums)
    {
        Console.WriteLine(num);
        if (double.Parse(num) > 0) count++;
    }
    return count;
}

// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}


int NumOfChar = ReadIntData("Введите число нажатий");
string[] nums = parseString(LineOfNumOfChar(NumOfChar));
string title = $"За {NumOfChar} нажатий вы ввели числа " +
               $"{string.Join(" | ", nums)} из них больше 0";

PrintAnswer(Count(nums).ToString(), title);