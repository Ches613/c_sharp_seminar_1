// ====================================================================
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// ====================================================================

// вернет массив неповторяющихся случайных двузначных чисел
int[] RandomUniqueValues(int size, int downBorder, int topBorder)
{
    HashSet<int> values = new HashSet<int>();
    Random rand = new Random();
    
    while (values.Count < size)
    {
        values.Add(rand.Next(downBorder, topBorder + 1));
    }
    return values.ToArray<int>();
}

// Создает трехмерный массив размером x × y x z
int[,,] Generate3DArray(int countX, int countY, int countZ, int[] values)
{
    int count = 0;
    Random rand = new Random();
    int[,,] array = new int[countX, countY, countZ];
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = values[count++];
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

int x = 2;
int y = 2;
int z = 2;
int[] values = RandomUniqueValues(size: x * y * z, 10, 99);
Print3DArray(Generate3DArray(x, y, z, values));