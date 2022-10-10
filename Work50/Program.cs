// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue,maxValue);
        }
    }
}

string FoundElementInArray(int[,] array, int row, int column)
{
  string result;

  if (row > array.GetLength(0) - 1 || column > array.GetLength(1) - 1)
  {
    return result = $"Позиции ({row}, {column}) в массиве нет";
  }  

  int foundElement = array[row, column];

  return result = $"В позиции массива ({row}, {column}) находится число: {foundElement}";
  
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

int row = GetRandomValue(2, 10);
int column = GetRandomValue(2, 10);
int[,] array = InitializateArray(row, column);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
PrintArray(array);
int rowFound = GetNumberFromConsole("Введите номер строки массива");
int columnFound = GetNumberFromConsole("Введите номер столбца массива");
Console.WriteLine(FoundElementInArray(array, rowFound, columnFound));
