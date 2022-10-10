// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void PrintTwoDimensionalArray(int[,] arr)
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

double[] GetMedianArithmeticColumns(int[,] array)
{  
  int sum = 0;
  double[] medianArithmeticArray = new double[array.GetLength(1)];

  for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      sum += array[j,i];
    }
    medianArithmeticArray[i] = Math.Round(Convert.ToDouble(sum) / Convert.ToDouble(array.GetLength(0)), 2);
    sum = 0;
  }
  return medianArithmeticArray;
}

void PrintArray(double[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write(arr[i] + " ");
  }
  Console.WriteLine();

}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
PrintTwoDimensionalArray(array);
Console.WriteLine($"Среднее арифметическое элементов в столбцах:");
PrintArray(GetMedianArithmeticColumns(array));
