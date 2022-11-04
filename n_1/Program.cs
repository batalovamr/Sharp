int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Ведите массив трехзначных чисел: ");
string getArray = Console.ReadLine();
string[] array = getArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < array.Length; i++)
int[] arr = new int[array.Length];
for (int i = 0; i < array.Length; i++) arr[i] = int.Parse(array[i]);
Console.WriteLine(Count(arr));