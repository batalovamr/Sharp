//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
int Prompt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
bool IsInputLengthValid(int n1, int m2)
{
    if (m2 != n1) return false;
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
int[,] MatrixMultiplication(int [,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int row = 0; row < array1.GetLength(0); row++)
    {
        for (int col = 0; col < array2.GetLength(1); col++)
        {
            resultArray[row, col] = 0;
            for (int i = 0; i < array1.GetLength(1); i++)
            {
                resultArray[row, col] += array1[row, i] * array2[i, col];
            }
        }
    }
    return resultArray;
}

int n1 = Prompt("Введите кол-во строк в 1 матрице: ");
int m1 = Prompt("Введите кол-во столбцов в 1 матрице: ");
int n2 = Prompt("Введите кол-во строк во 2 матрице: ");
int m2 = Prompt("Введите кол-во столбцов во 2 матрице: ");
if (IsInputLengthValid(n1, m2))
{
    int[,] array1 = CreateArray(n1, m1, -10, 10);
    PrintArray(array1);
    Console.WriteLine();
    int[,] array2 = CreateArray(n2, m2, -10, 10);
    PrintArray(array2);
    Console.WriteLine();
    int[,] result = MatrixMultiplication(array1, array2);
    PrintArray(result);
}
else Console.WriteLine("Неправильные данные!");