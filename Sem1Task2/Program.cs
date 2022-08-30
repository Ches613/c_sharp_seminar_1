// =========================================================================
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
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
                if (number1 > number2)
                {
                    Console.WriteLine("max = " + number1);
                }
                else
                {
                    Console.WriteLine("max = " + number2);
                }
                return 0;
            }
        }
    }
}
