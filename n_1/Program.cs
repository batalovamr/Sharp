// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) count++;
    }
    return count;
}

Console.Write("Введите массив чисел: ");
string getArray = Console.ReadLine();
string[] array = getArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] inputArray = new int[array.Length];
for (int i = 0; i < array.Length; i++) inputArray[i] = int.Parse(array[i]);
Console.WriteLine(Count(inputArray));
