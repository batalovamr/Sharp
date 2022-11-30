// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
int Prompt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
bool IsInputValid(int n, int m)
{
    if (m < 0 || n < 0) return false;
    else return true;
}

int m = Prompt("Введите значение M: ");
int n = Prompt("Введите значение N: ");
if (IsInputValid(m, n)) Console.WriteLine("A(m, n) = " + AkkermanFunc(m, n));
else Console.WriteLine("Неправильные данные!");