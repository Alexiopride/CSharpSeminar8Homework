// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter  number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
Console.WriteLine();


void SortRowOfArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j + 1] > array[i, j])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
}


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine();
SortRowOfArray(array);
PrintArray(array);