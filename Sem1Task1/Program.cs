// =========================================================================
// Напишите программу, которая на вход принимает два числа и
// проверяет является ли первое число квадратом второго
// =========================================================================

while (true)
{
    Console.WriteLine("Enter first number:");
    string? inputLine1 = Console.ReadLine();

    if (int.TryParse(inputLine1, out int number1))
    {
        while (true)
        {
            Console.WriteLine("Enter second number:");
            string? inputLine2 = Console.ReadLine();
            if (int.TryParse(inputLine2, out int number2))
            {
                Console.WriteLine(Math.Sqrt(number2) == number1);
                return 0;
            }
        }
    }
}
