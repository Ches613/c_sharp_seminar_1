// =======================================================================================
// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. 
// =======================================================================================


void MyVariant()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    char [] charArray = number.ToString().ToCharArray();

    Console.WriteLine("" + charArray[0] + charArray[2]);
}

MyVariant();