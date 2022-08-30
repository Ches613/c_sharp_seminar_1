// =========================================================================
// Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает последнюю цифру этого числа.
// =========================================================================

while (true)
{
    Console.WriteLine("Enter three-digit number:");
    string? inputLineN = Console.ReadLine();

    if (int.TryParse(inputLineN, out int inputNumberN) && inputNumberN < 1000 && inputNumberN > 99)
    {
            Console.Write(inputNumberN % 10);
        return;
    }
}