// =========================================================================
// Напишите программу которая принимает число и выводит 
// Соответствующий день недели
// =========================================================================

while (true)
{
    Console.WriteLine("Enter day number:");
    string? inputLine = Console.ReadLine();

    if (int.TryParse(inputLine, out int inputDayOfWeek))
    {
        string[] dayOfWeek = new string[7];
        dayOfWeek[0] = "Monday";
        dayOfWeek[1] = "Tuesday";
        dayOfWeek[2] = "Wednesday";
        dayOfWeek[3] = "Thursday";
        dayOfWeek[4] = "Friday";
        dayOfWeek[5] = "Saturday";
        dayOfWeek[6] = "Sunday";
        if (inputDayOfWeek <= dayOfWeek.Length)
        {
            Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
            return;
        }
        else
        {
            Console.WriteLine("there is no such day of the week!");
        }
    }
}