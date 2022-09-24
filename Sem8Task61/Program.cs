// ====================================================================
// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде 
// равнобедренного треугольника
// ====================================================================


// чтение челого числа из сонсоли
int ReadIntData(string line)
{
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    return Convert.ToInt32(Console.ReadLine());
}


// Возвращает факториал n
float Factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}


// Печать первых n строк треугольника Паскаля
void PrintPascalTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("".PadLeft(n - i));
        for (int j = 0; j <= i; j++)
        {
            Console.Write($"{Factorial(i) / (Factorial(j) * Factorial(i - j))} ");
        }
        Console.WriteLine();
    }
}


PrintPascalTriangle(ReadIntData("Введите количество строк треугольника Паскаля"));