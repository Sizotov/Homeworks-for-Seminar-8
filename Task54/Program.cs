//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

using System;
using static System.Console;
Clear();
Write("Введите размерность m массива: ");
int m = int.Parse (ReadLine());
Write("Введите размерность n массива: ");
int n = int.Parse (ReadLine());
int k = int.Parse (ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1,10);
}
}
}
void printm(int[,] array)
{
int i,j;
for (i = 0; i < array.GetLength(0); i++)
{
WriteLine();
for (j = 0; j < array.GetLength(1); j++)
{
Write($"{randomArray[i,j]} ");
}
WriteLine();
}
}
mas(m,n);
WriteLine("Исходный массив: ");
printm(randomArray);

void sorti (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
for (int k = 0; k < array.GetLength(1) - 1; k++)
{
if (array[i, k] < array[i, k + 1])
{
int temp = array[i, k + 1];
array[i, k + 1] = array[i, k];
array[i, k] = temp;
}
}
}
}
}

sorti(randomArray);
WriteLine("Отсортированный массив: ");
printm(randomArray);