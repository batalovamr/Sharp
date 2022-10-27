int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double len = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return len;
}
int xa = PrintAndGetValue("Введите координату Х точки А: ");
int ya = PrintAndGetValue("Введите координату Y точки А: ");
int za = PrintAndGetValue("Введите координату Z точки А: ");
int xb = PrintAndGetValue("Введите координату Х точки B: ");
int yb = PrintAndGetValue("Введите координату Y точки B: ");
int zb = PrintAndGetValue("Введите координату Z точки B: ");

Console.WriteLine(GetDistance(xa, ya, za, xb, yb, zb));