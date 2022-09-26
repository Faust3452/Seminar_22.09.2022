// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool IsFiveDigit(int num)
{
    return (num < 99999 && num > 10000);
}

bool Palindrome(int num)
{
    int firstPart = Math.Abs(num) / 1000;
    int secondPart = Math.Abs(num) % 100;
    return ((firstPart / 10) == (secondPart % 10) && (firstPart % 10) == (secondPart / 10));
}

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine("Вы ввели отрицательное значение, попробуйте еще раз!");
else
{
    if (IsFiveDigit(number))
    {
        bool result = Palindrome(number);
        if (result == true) Console.WriteLine($"{number} -> да");
        else Console.WriteLine($"{number} -> нет");
    }
    else Console.WriteLine("Вы ввели не пятизначное число, попробуйте еще раз!");
}