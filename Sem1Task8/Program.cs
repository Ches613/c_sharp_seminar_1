// =========================================================================
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// =========================================================================

while (true)
{
    Console.WriteLine("Enter number:");
    string? inputLine = Console.ReadLine();

    if (int.TryParse(inputLine, out int number))
    {
        int outputNumber = 2;
        List<int> outputNumbers = new List<int>();
        while (outputNumber <= number)
        {
            outputNumbers.Add(outputNumber);
            outputNumber += 2;
        }
        Console.WriteLine(string.Join(", ", outputNumbers));
        return 0;
    }
}