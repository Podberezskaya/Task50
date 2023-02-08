//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [5,5];
InputMatrix(matrix);
Release(matrix);
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(-10, 11);
            }  
        }
}
void Release(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        } 
        Console.WriteLine();
    }
}
if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("Элемент отсутствует");
}
else
{
    Console.WriteLine($"Значение элемента равно {matrix[n-1,m-1]}");
}