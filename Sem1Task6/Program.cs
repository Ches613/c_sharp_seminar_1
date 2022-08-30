// =========================================================================
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// =========================================================================

while (true)
{
    Console.WriteLine("Enter number:");
    string? inputLine = Console.ReadLine();

    if (int.TryParse(inputLine, out int number))
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
        return 0;
    }
}