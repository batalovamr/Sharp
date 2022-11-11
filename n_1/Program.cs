// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
//(Округление до 2х знаков после запятой - Math.Round(value, 2))

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
double[,] CreateArray(int n, int m)
{
    double[,] a = new double[n, m];
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            a[row, col] = Math.Round(new Random().NextDouble() * 10.0, 1);
        }
    }
    return a;
}
void PrintArray(double[,] array)
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

int n = Prompt("Введите кол-во строк: ");
int m = Prompt("Введите кол-во столбцов: ");
if (IsInputLengthValid(n, m))
{
    double[,] array = CreateArray(n, m);
    PrintArray(array);
}
else Console.WriteLine("Неправильные данные!");
