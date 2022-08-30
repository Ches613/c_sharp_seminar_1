// =========================================================================
// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// =========================================================================

while (true)
{
    Console.WriteLine("Enter first number:");
    string? inputLine1 = Console.ReadLine();
    int[] numbers = new int[3];

    if (int.TryParse(inputLine1, out numbers[0]))
    {
        while (true)
        {
            Console.WriteLine("Enter second number:");
            string? inputLine2 = Console.ReadLine();
            if (int.TryParse(inputLine2, out numbers[1]))
            {
                while (true)
                {
                    Console.WriteLine("Enter third number:");
                    string? inputLine3 = Console.ReadLine();
                    if (int.TryParse(inputLine3, out numbers[2]))
                    {
                        Console.WriteLine(numbers.Max());
                        return 0;
                    }
                }
            }
        }
    }
}