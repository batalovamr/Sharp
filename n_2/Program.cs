// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
void Search(int [,] array)
{
    int sum = 0;
    int index = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        int temp = 0;
        for (int col = 0; col < array.GetLength(1); col++) temp += array[row, col];
        if (temp < sum)
        {
            sum = temp;
            index = row + 1;
        }
    }
    Console.WriteLine("Строка " + index);
}

int n = Prompt("Введите кол-во строк: ");
int m = Prompt("Введите кол-во столбцов: ");
if (IsInputLengthValid(n, m))
{
    int[,] array = CreateArray(n, m, -10, 10);
    PrintArray(array);
    Console.WriteLine();
    Search(array);
}
else Console.WriteLine("Неправильные данные!");