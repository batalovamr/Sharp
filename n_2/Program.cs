// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет
//(row ,colum - входные данные)

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
bool IsInputCoordinateValid(int[,] array, int a, int b)
{
    if (a > array.GetLength(0) || b > array.GetLength(1)) return false;
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
int Search(int[,] array, int a, int b)
{
    int num = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (row == a - 1 && col == b - 1) num = array[row, col]; 
        }
    }
    return num;
}

int n = Prompt("Введите кол-во строк: ");
int m = Prompt("Введите кол-во столбцов: ");
if (IsInputLengthValid(n, m))
{
    int[,] array = CreateArray(n, m, -10, 10);
    PrintArray(array);
    int a = Prompt("Введите координату по строкам: ");
    int b = Prompt("Введите координату по столбцам: ");
    if (IsInputCoordinateValid(array, a, b))
    {
        Console.WriteLine(Search(array, a, b));
    }
    else Console.WriteLine("Такого числа в массиве нет!");
}
else Console.WriteLine("Неправильные данные!");

