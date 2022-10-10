// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double GetRandomValue(int integerPart, int fractionalPart )
{
  double startNumber = new Random().NextDouble();
  double readyDoubleNumber = Math.Round(startNumber * Math.Pow(10, integerPart), fractionalPart);
  return readyDoubleNumber;
}

void FillArray(double[,] arr, int integerPart, int fractionalPart)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(integerPart, fractionalPart);
        }
    }
}

void PrintArray(double[,] arr)
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

double[,] InitializateArray(int m, int n)
{
    return new double[m,n];
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите число строк массива m: ");
int n = GetNumberFromConsole("Введите число столбцов массива n: ");
double[,] array = InitializateArray(m,n);
int integerPart = GetNumberFromConsole("Введите количество знаков до запятой");
int fractionalPart = GetNumberFromConsole("Введите количество знаков после запятой");
FillArray(array,integerPart,fractionalPart);

PrintArray(array);
