// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputValue(string message)
{
    Console.Write(message);
    double result = int.Parse(Console.ReadLine());
    return result;
}

string SweepPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    string msg = "(" + x + ";" + y + ")";
    return msg;
}

double k1 = InputValue("Введите число k1: ");
double b1 = InputValue("Введите число b1: ");
double k2 = InputValue("Введите число k2: ");
double b2 = InputValue("Введите число b2: ");

Console.WriteLine(SweepPoint(k1, b1, k2, b2));