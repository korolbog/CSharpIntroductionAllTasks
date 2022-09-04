/*
Задача 6
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/

int number = new Random().Next(1,11);
Console.WriteLine($"Ваше случайное число: {number}");
if (number%2==0)
{
    Console.WriteLine($"{number} - четное число.");
}
else
{
    Console.WriteLine($"{number} - нечетное число.");
}
