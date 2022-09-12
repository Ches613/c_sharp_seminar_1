// ====================================================================
// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. 
// *Написать калькулятор с операциями +, -, /, * и возведение в степень
// ====================================================================


// чтение данных из сонсоли, возвращает
// Определение <число А, число В, знак операции>
Tuple<double, double, char> ReadData(string line)
{
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";

    // получаем десятичный разделитель из текущего потока
    string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
    // парсим полученную строку
    string[] inputLineItems = inputLine.Split(",");

    return Tuple.Create(
            double.Parse(inputLineItems[0].Replace(".", decimalSeparator)),
            double.Parse(inputLineItems[1].Replace(".", decimalSeparator)),
            char.Parse(inputLineItems[2])
           );
}


// расчет значения
// mathExpression <число А, число В, знак операции>
double Calculate(Tuple<double, double, char> mathExpression)
{

    switch (mathExpression.Item3)
    {
        case '/':
            return mathExpression.Item1 / mathExpression.Item2;
        case '*':
            return mathExpression.Item1 * mathExpression.Item2;
        case '+':
            return mathExpression.Item1 + mathExpression.Item2;
        case '-':
            return mathExpression.Item1 - mathExpression.Item2;
        case '^':
            return Math.Pow(mathExpression.Item1, mathExpression.Item2);
        default:
            throw new FormatException("Введен не поддерживающийся знак");
    }
}


// вывод результата
void PrintResult(double result)
{
    Console.WriteLine(Math.Round(result, 2));
}


void main()
{
    try
    {
        PrintResult(Calculate(ReadData("Введите выражение A, B, знак операции(+, -, /, *, ^) \n" +
                                       "*дробная часть через точку")));
    }
    // была введена не корректная строка
    catch (System.FormatException)
    {
        Console.WriteLine("Вы ввели не корректные данные");
    }
}


main();