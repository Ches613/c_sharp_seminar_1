// =========================================================================
// Напишите программу которая принимает число N и выводит 
// числа от -N до N
// =========================================================================

while (true)
{
    Console.WriteLine("Enter number:");
    string? inputLineN = Console.ReadLine();

    if (int.TryParse(inputLineN, out int inputNumberN))
    {
        int startNumber = (-1) * inputNumberN;
        while (startNumber <= inputNumberN)
        {
            Console.Write(startNumber + " ");
            startNumber++;
        }
        return;
    }
}