/*
Задача 4
Напишите программу, которая принимает на вход три числа и
выдаёт максимальное из этих чисел.
*/

int firstNumber = new Random().Next(1,11);
int secondNumber = new Random().Next(1,11);
int thirdNumber = new Random().Next(10,11);
int maxNumber = firstNumber;

Console.WriteLine($"Ваши три числа: {firstNumber} \t{secondNumber} \t {thirdNumber}");
if (secondNumber > maxNumber)
{
    maxNumber = secondNumber;
}
if (thirdNumber > maxNumber)
{
    maxNumber = thirdNumber;
}
Console.WriteLine($"Максимальное число из трёх: {maxNumber}");