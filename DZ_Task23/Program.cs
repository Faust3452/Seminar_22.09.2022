// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void TableCube(int num)
{
    Console.Write($"{num} ->");
    for (int i = 1; i < num + 1; i++)
    {
        int cube = Convert.ToInt32(Math.Pow(i, 3));
        if (i == num) Console.Write($" {cube}");
        else Console.Write($" {cube},");
    }
}

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine("Вы ввели отрицательное число, введите положительное число: ");
else TableCube(number);