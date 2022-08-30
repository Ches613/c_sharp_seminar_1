// =========================================================================
// Напишите программу которая на вход принимает число и выдает его
// квадрат.
// =========================================================================

while (true)
{
    Console.WriteLine("Enter number:");
    string? inputLine = Console.ReadLine();
    if (int.TryParse(inputLine, out int number))
    {
        Console.WriteLine(Math.Pow(number, 2));
        return;
    }

}
