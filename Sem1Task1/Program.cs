// =========================================================================
// Напишите программу которая принимает два числа и выводит является ли
//  второе число квадратом первого
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
                Console.WriteLine(Math.Sqrt(number2) == double.Parse(inputLine1));
                return 0;
            }
        }
    }
}
