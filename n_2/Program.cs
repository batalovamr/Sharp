int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int[] arr = CreateRandomArray(5, -100, 100);
int sum = 0;
int i = 0;
while(i < arr.Length)
{
    sum = sum + arr[i];
    i = i + 2;
}
string inputString = string.Join(",", arr);
Console.WriteLine("Array = " + inputString);
Console.WriteLine("Sum = " + sum);

