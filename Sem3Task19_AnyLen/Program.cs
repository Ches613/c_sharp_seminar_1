// ==========================================================================================
// №19 Напишите программу, которая принимает на вход число любой длинны и проверяет,
// является ли оно палиндромом.
// ==========================================================================================


//чтение данных из сонсоли 
string ReadData(string line)
{
    //Выводим сообщение 
    Console.WriteLine(line + ": ");
    //Возвращаем значение 
    return Console.ReadLine() ?? "0";
}


// является ли строка палиндромом 
bool IsPalindrome(string line)
{
    // получаем массив символов в нижнем регистре без пробелов
    char[] charArray = line.Replace(" ", "").ToLower().ToCharArray();

    // циклом сравниваем первый символ с последним
    // второй с предпоследним и т.д.
    for (int i = 0; i < (int)(charArray.Length / 2); i++)
    {
        if (charArray[i] != (charArray[charArray.Length - 1 - i])) // если не равны возвращаем false
        {
            return false;
        }
    }

    return true; // если все равны true
}

// печатаем ответ
void PrintAnswer(bool IsPalindrome)
{
    Console.WriteLine(IsPalindrome ? "Да" : "Нет");
}


PrintAnswer(IsPalindrome(ReadData("Введите число, но на самом деле можно и слово или даже предложение!))")));