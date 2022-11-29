// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
void Sort(int [,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1) - 1; col++)
        {
            int maxPos = col;
            for (int i = col + 1; i < array.GetLength(1); i++)
            {
                if (array[row, i] > array[row, maxPos]) maxPos = i;
            }
            int temp = array[row, col];
            array[row, col] = array[row, maxPos];
            array[row, maxPos] = temp;
        }
    }
    
}

int n = Prompt("Введите кол-во строк: ");
int m = Prompt("Введите кол-во столбцов: ");
if (IsInputLengthValid(n, m))
{
    int[,] array = CreateArray(n, m, -10, 10);
    PrintArray(array);
    Console.WriteLine();
    Sort(array);
    PrintArray(array);
}
else Console.WriteLine("Неправильные данные!");