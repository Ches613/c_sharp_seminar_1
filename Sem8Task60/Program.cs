// ====================================================================
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// ====================================================================


// Создает трехмерный массив размером x × y x z
int[,,] Generate3DArray(int countX, int countY, int countZ, int downBorder, int topBorder)
{
    Random rand = new Random();
    int[,,] array = new int[countX, countY, countZ];
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = rand.Next(downBorder, topBorder + 1);
            }
        }
    }
    return array;
}


// вывод трехмерного массива
void Print3DArray(int[,,] array)
{
    // изменение z выводится в конце (как в примере)
    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
    }
}


Print3DArray(Generate3DArray(2, 2, 2, 10, 99));