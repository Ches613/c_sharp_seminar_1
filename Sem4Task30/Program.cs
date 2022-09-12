// ====================================================================
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// ====================================================================


// Создаем массив
int[] GenerateArray()
{
    Random rand = new Random();
    int[] array = new int[8];
   for (int i = 0; i < array.Length; i++)
   {
    array[i] = rand.Next(0, 2);
   }
    return array;
}


// вывод массив
void PrintArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}


DateTime d1 = DateTime.Now;
PrintArray(GenerateArray());
Console.WriteLine(DateTime.Now - d1);