// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//(Округление до 2х знаков - Math.Round(value, 2)

int Prompt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
bool IsInputLengthValid(int n, int m)
{
    if (n <= 0 || m <= 0) return false;
    else return true;
}
int[,] CreateArray(int n, int m, int min, int max)
{
    int[,] a = new int[n, m];
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            a[row, col] = new Random().Next(min, max + 1);
        }
    }
    return a;
}
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]} ");
        }
        Console.WriteLine();
    }
}
double[] ColAverage(int [,] array)
{
    double[] arr = new double[array.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sum = sum + array[row, i];
        }
        arr[i] = Math.Round(sum / array.GetLength(0), 1);
    }
    return arr;
}

int n = Prompt("Введите кол-во строк: ");
int m = Prompt("Введите кол-во столбцов: ");
if (IsInputLengthValid(n, m))
{
    int[,] array = CreateArray(n, m, -10, 10);
    PrintArray(array);
    Console.WriteLine(String.Join("; ", ColAverage(array)));
}
else Console.WriteLine("Неправильные данные!");
