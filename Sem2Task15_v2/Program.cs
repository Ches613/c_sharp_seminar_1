// =========================================================================
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// =========================================================================


string IsWeekend(Dictionary<int, bool> days, string dayNumber) =>
    int.TryParse(dayNumber, out int i) ?
    (
        days.ContainsKey(i) ?
        (
            days[i] ?
                "да" :
                "нет"
        ) :
        "такого дня не существует"
    ) :
    "Это вообще не цифра!(";

void PrintResult(string output) => Console.WriteLine(output);

void Program()
{
    var days = new Dictionary<int, bool>
    {
        { 1, false },
        { 2, false },
        { 3, false },
        { 4, false },
        { 5, false },
        { 6, true },
        { 7, true }
    };
    Console.Write("Введите номер дня недели: ");
    PrintResult(IsWeekend(days, Console.ReadLine() ?? "0"));
}

Program();