//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
using System.Globalization;

int numberI;
int numberJ;
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = tab
        }
        Console.WriteLine();
    }
}
void FindElementOfMatrix(int[,] matr, int numberI, int numberJ)
{
    if (numberI <= matr.GetLength(0) && numberJ <= matr.GetLength(1))
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            if (i == numberI)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (j == numberJ) { Console.WriteLine(matr[i, j]); break; }
                }
            }//else Console.WriteLine("no element"); 
        }
    }
    else Console.WriteLine("no element");
}

int[,] res = CreateMatrix(3, 4, 0, 10);
PrintMatrix(res);
Console.WriteLine("Введите позицию элемента i:\t");
numberI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента j:\t");
numberJ = Convert.ToInt32(Console.ReadLine());

FindElementOfMatrix(res, numberI, numberJ);




