// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)



int[,,] CreateRandom3DArray(int str, int rows, int columns, int minValue, int maxValue)
{
    int[,,] newArray = new int[str, rows, columns];

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }

    return newArray;
}

void Print3DArrayWithIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}  ({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] newArray = CreateRandom3DArray(2, 2, 2, 10, 99);
Print3DArrayWithIndex(newArray);