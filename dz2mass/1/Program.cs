// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int [,] array = new int[5,5];

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
void FindElement()
{
    Console.WriteLine("Введите позицию строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    if (i > array.GetLength(0) || i < 0)
    {
        Console.WriteLine("Такого элемента нет");
        return;
    }
    Console.WriteLine("Введите позицию столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (j > array.GetLength(1) || j < 0)
    {
        Console.WriteLine("Такого элемента нет");
        return;
    }
    Console.WriteLine();
    Console.WriteLine(array[i,j]);
}

CreateArray();
PrintArray();
FindElement();

