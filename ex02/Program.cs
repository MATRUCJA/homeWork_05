//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
            Console.Write($"{matr[i, j]}\t"); 
        }
        Console.WriteLine();
    }
}
void SwapRowOfMatrix(int[,] matr)
{
    int rows = matr.GetLength(0) - 1;
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                temp = matr[i, j];
                matr[i, j] = matr[rows, j];
                matr[rows, j] = temp;
            }

        }
    }

}
int[,] res = CreateMatrix(3, 4, 0, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(res);
Console.WriteLine("Новый массив:");
SwapRowOfMatrix(res);
PrintMatrix(res);



