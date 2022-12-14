// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] NewArray(int[,] array1, int[,]array2)
{
    int[,] newArray = new int[array1.GetLength(0),array1.GetLength(1)];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        newArray[i,j]=array1[i,j]*array2[i,j];
    }
}
    return newArray;
}

int[,] array1 = CreateRandom2DArray(6, 4, 0, 10);
int[,] array2 = CreateRandom2DArray(6, 4, 0, 10);
Print2DArray(array1);
Print2DArray(array2);

int[,] newArray = NewArray(array1,array2);

Print2DArray(newArray);