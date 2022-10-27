int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int N = PrintAndGetValue("Введите число N: ");
if (N > 0)
{
    for (int i = 1; i <= N; i++) Console.Write(Math.Pow(i, 3) + "  ");
}
else if (N < 0)
{
    for (int i = N; i < 0; i++) Console.Write(Math.Pow(i, 3) + "  ");
}
else Console.WriteLine("Error");