Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
int count = 0;
int N = A;
int B = 0;
int sum = 0;
while (N != 0)
{
    B = N % 10;
    N = N / 10;
    sum = sum + B;
    count++;
}
Console.WriteLine(sum);