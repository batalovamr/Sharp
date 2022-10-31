double InputValue (string message)
{
    Console.WriteLine(message);
    double num = double.Parse(Console.ReadLine());
    return num;
}

bool IsInputValid(double a)
{
    if (a < 1 || a % 1 != 0) return false;
    else return true;
}

double CalculatePow (double a, double b)
{
    double c = 1;
    for (int i = 1; i <= b; i++) c = c*a;
    return c;
}

double A = InputValue("Введите число А: ");
double B = InputValue("Введите число B: ");
bool IsValid = IsInputValid(B);
if (IsValid)
{
    double num = CalculatePow(A, B);
    Console.WriteLine("А в степени В = " + num);
}
else Console.WriteLine("Неправильные данные");