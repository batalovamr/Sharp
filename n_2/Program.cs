// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int CalculateSumm(int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
    }
    return (end + start) * (end - start + 1) / 2; // по формуле суммы членов арифметической прогрессии
}
int Prompt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
bool IsInputValid(int n, int m)
{
    if (n <= 0 || m <= 0) return false;
    else return true;
}

int n = Prompt("Введите значение N: ");
int m = Prompt("Введите значение M: ");
if (IsInputValid(n, m)) Console.WriteLine("Sum = " + CalculateSumm(n, m));
else Console.WriteLine("Неправильные данные!");