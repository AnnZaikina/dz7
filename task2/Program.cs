/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine()!);
int[,] array = GetArray(rows, columns,-10,10);
PrintArray(array);
Write("Введите номер строки ");
int iElement = int.Parse(ReadLine()!);
Write("Введите номер столбца ");
int jElement = int.Parse(ReadLine()!);
FindElement (array, iElement, jElement);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}

void FindElement(int[,] array, int iElement, int jElement)
{
    if (iElement <= array.GetLength(0))
        if (jElement<= array.GetLength(1))
        {
            int element = array [iElement-1, jElement-1];
            Write($"Значение вашего элемента = {element}");
        }
        else
        {
            Write("Элемент не найден");
        }
    else
    {
        Write("Элемент не найден");
    }
}




