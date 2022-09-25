/*Задача 50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
(1,7) -> такого числа в массиве нет
*/

Console.WriteLine("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, columns];

numbers = Fill2DArray(numbers);
Print2DArray(numbers);

Console.WriteLine("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

if ((row > rows || row < 0) || (column > columns || column < 0))
{
    System.Console.WriteLine("индексы вне диапозона!");
}
else
{
    System.Console.WriteLine($"Число в строке {row}, столбце {column} равно " + numbers[row, column]);
}

int[,] Fill2DArray(int[,] arr)
{
    var random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 10);
        }
    }
    return arr;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}