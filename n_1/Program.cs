//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Print (int n)
{
    
    if (n==1) Console.Write("{0}", n);
    if (n > 1)
    {
        Console.Write("{0}, ", n);
        Print(n - 1);
    }
    
}
int Prompt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
bool IsInputValid(int n)
{
    if (n <= 0) return false;
    else return true;
}

int n = Prompt("Введите значение N: ");
if (IsInputValid(n)) 
{
    Console.Write('"');
    Print(n);
    Console.Write('"');
}
else Console.WriteLine("Неправильные данные!");