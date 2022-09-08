//чтение данных из сонсоли 
int ReadData(string line)
{ 
    //Выводим сообщение 
    Console.WriteLine(line + ": ");
    //Считываем число 
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение 
    return number;
}


// является ли строка палиндромом 
bool IsPalindrome(int number)
{
    int length = (int)Math.Log10(number) + 1;

    // сравниваем первую цифру с последней
    // вторую с предпоследней и т.д.
    for (int i = 0; i < (int)(length/2); i++)
    {
        int a = (int)(number / Math.Pow(10, length -1 - i) % 10); // получаем цифры с начала числа
        int b =  (int)(number / Math.Pow(10, i) % 10); // получаем цифры с конца числа

        if (a != b) // если не равны возвращаем false
        {
            return false;
        }
    }

    return true; // если все равны true
}

// печатаем ответ
void PrintAnswer(bool answer)
{
    Console.WriteLine(answer ? "Да" : "Нет");
}


PrintAnswer(IsPalindrome(ReadData("Введите число")));