// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;

int [,] array = new int[3,5];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] +" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int FindMinSumLine()
{
   
    int minSum = int.MaxValue;
    int minSumLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumEl = array[0,0];
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            sumEl+= array[i,j];
        }
        if (sumEl < minSum)
        {    
            minSum = sumEl;
            minSumLine = i;
        }
    }
    return minSumLine;
}
        
CreateArray();
PrintArray();
FindMinSumLine();
Console.Write($"Строка с наименьшей суммой элементов (отсчет начинается с 0 строки): {FindMinSumLine()}");

