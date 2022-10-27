bool IsPalindrome(string number)
{
    if (number.Length == 5 && number[0] == number[4] && number[1] == number[3]) return true;
    else return false;
}


Console.WriteLine("Введите положительное пятизначное число");
string n = Console.ReadLine();
bool nn = IsPalindrome(n);
if (nn == true) Console.WriteLine("Это число палиндром");
else Console.WriteLine("Это число не палиндром");

