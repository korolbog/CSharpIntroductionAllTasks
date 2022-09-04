/*
Задача 8
Напишите программу, которая на вход принимает число (N), а на
выходе показывает все чётные числа от 1 до N.
*/

int number = new Random().Next(1,11);
int i = 1;
string result = String.Empty;

Console.WriteLine($"Ваше случайное число: {number}");
if (number < 2)
{
    Console.WriteLine("Четных чисел нет");
    return;
}
else while (i <= number)
{
    if (i % 2 == 0)
    {
        result += ($"{i} "); 
    }
    i++;
}
Console.WriteLine($"Четные числа от 1 до {number}:");
Console.WriteLine(result);
