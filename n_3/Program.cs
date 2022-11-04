int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int[] SelectionSort1(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}
int[] arr = CreateRandomArray(5, 1, 100);
string array = string.Join(",", arr);
Console.WriteLine(array);
int[] arr1 = SelectionSort1(arr);
string array1 = string.Join(",", arr);
Console.WriteLine(array1);
Console.WriteLine(arr1[arr1.Length-1] - arr1[0]);





