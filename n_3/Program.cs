int[] RandomArray( int ln, int mn, int mx)
{
    int[] array = new int[ln];
    for (int i = 0; i < ln; i ++) 
    {
        array[i] = new Random().Next(mn, mx + 1);
    } 
    return array;
}
 string PrintArray(int[] array)
 {
    string msg = "[";
    for (int i = 0; i < array.Length - 1; i++)
    {
        msg += array[i] + ",";
    }
    msg += array[array.Length - 1] + "]";
    return msg;
 }
int InputValue (string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int N = InputValue("Введите длину массива: ");
int min = InputValue("Введите минимальное значение элемента: ");
int max = InputValue("Введите максимальное значение элемента: ");
Console.WriteLine(PrintArray(RandomArray(N, min, max)));