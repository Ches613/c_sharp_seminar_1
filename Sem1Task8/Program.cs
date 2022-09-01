// =========================================================================
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// =========================================================================

const string ExitCommand = "q";

int outputNumber = 2;
List<int> outputNumbers = new List<int>();

Console.WriteLine("Enter '" + ExitCommand + "' for exit from program.");
int number = RequestNumber(exitCmd: ExitCommand);

while (outputNumber <= number) // пока outputNumber <= числа введенного пользователем наполняем список четными числами.
{
    outputNumbers.Add(outputNumber);
    outputNumber += 2;
}

Console.WriteLine("\n" + string.Join(", ", outputNumbers)); // превращаем элементы списка в строку с запятой в качестве разделителя и выводим в консоль


// запрашивает число у пользователь, в качестве аргумента принимает текст запроса и команду выхода из программы.
int RequestNumber(string text = "Enter number", string exitCmd = "q")
{

    while (true) // код в цикле выполняется пока пользователь не введет целое число или команду выхода из программы
    {
        Console.Write(text + ": ");
        string? inputLine = Console.ReadLine();

        if (inputLine == null)
        {
            continue;
        }
        if (inputLine.ToLower() == exitCmd)
        {
            Environment.Exit(0);
        }
        if (int.TryParse(inputLine, out int number))
        {
            return number;
        }
    }
}
